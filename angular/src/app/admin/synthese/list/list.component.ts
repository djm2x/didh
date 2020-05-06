import { ActivatedRoute } from '@angular/router';

import { Component, OnInit, ViewChild, EventEmitter } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatAutocompleteSelectedEvent } from '@angular/material';
import { merge, Observable } from 'rxjs';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { Visite, Recommendation } from 'src/app/Models/models';
import { DeleteService } from '../../components/delete/delete.service';
import { DetailComponent } from '../detail/detail.component';
import { FormControl } from '@angular/forms';
import { SessionService } from 'src/app/shared';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;
  dataSource = [];
  columnDefs = [
    { columnDef: 'code', headName: 'CODE' },
    { columnDef: 'detail', headName: 'DETAIL' },
    { columnDef: 'option', headName: 'OPTION' },
  ];
  axes = this.uow.axes.get();
  sousAxes = [];
  traites = this.uow.traites.get();
  organismes = this.uow.organismes.get();
  rapports = [];
  idTraite = new FormControl(0);
  idAxe = new FormControl(0);
  idSousAxe = new FormControl(0);
  idRapport = new FormControl(0);
  idOrganismeEmetteur = new FormControl(0);

  panelOpenState = false;

  displayedColumns = this.columnDefs.map(e => e.columnDef);
  myAuto = new FormControl('');
  filteredOptions: Observable<any>;
  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , private snack: SnackbarService, private route: ActivatedRoute, public session: SessionService) { }

  ngOnInit() {
    this.getPage(0, 10, 'id', 'desc', this.session.user.idOrganisme, 0, 0, 0, 0, 0);
    merge(...[this.sort.sortChange, this.paginator.page, this.update]).subscribe(
      r => {
        r === true ? this.paginator.pageIndex = 0 : r = r;
        !this.paginator.pageSize ? this.paginator.pageSize = 10 : r = r;
        const startIndex = this.paginator.pageIndex * this.paginator.pageSize;
        this.isLoadingResults = true;
        this.getPage(
          startIndex,
          this.paginator.pageSize,
          this.sort.active ? this.sort.active : 'id',
          this.sort.direction ? this.sort.direction : 'desc',
          this.session.user.idOrganisme,
          this.idOrganismeEmetteur.value ? this.idOrganismeEmetteur.value : 0,
          this.idTraite.value ? this.idTraite.value : 0,
          this.idRapport.value ? this.idRapport.value : 0,
          this.idAxe.value ? this.idAxe.value : 0,
          this.idSousAxe.value ? this.idSousAxe.value : 0,
        );
      }
    );
    this.route.queryParams.subscribe(params => {
      const id = params['data'];
      if (id) {
        this.uow.syntheses.getDetail(id).subscribe(r => {
          this.openDialog(r);
        });
      }
    });
    this.autoComplete();
  }

  autoComplete() {
    this.filteredOptions = this.myAuto.valueChanges.pipe(
      // startWith(''),
      switchMap((value: string) => value.length > 1 ? this.uow.organismes.autocompletePost('label', value) : []),
      // map(r => r)
    );
  }

  selected(event: MatAutocompleteSelectedEvent): void {
    const o = event.option.value as any;
    // console.log(o);
    this.myAuto.setValue(o.label);
    this.idOrganismeEmetteur.setValue(o.id);
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idOrganisme, idOrganismeEmetteur, idTraite, idRapport, idAxe, idSousAxe) {
    this.uow.syntheses.getAll(
      startIndex, pageSize, sortBy, sortDir, idOrganisme, idOrganismeEmetteur, idTraite, idRapport, idAxe, idSousAxe).subscribe(
      (r: any) => {
        // console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }


  async delete(o: Recommendation) {
    const r = await this.mydialog.openDialog('synthèse').toPromise();
    if (r === 'ok') {
      this.uow.syntheses.delete(o.id).subscribe(() => this.update.next(true));
    }
  }

  detail(o) {
    this.uow.syntheses.getDetail(o.id).subscribe(r => {
      this.openDialog(r);
    });
  }

  axeChange(idAxe: number) {
    this.uow.sousAxes.getByIdAxe(idAxe).subscribe(r => {
      this.sousAxes = r as any[];
    });
  }

  search() {
    if (Number(this.idTraite.value) === 0 && Number(this.idRapport.value) === 0
    && Number(this.idOrganismeEmetteur.value) === 0 && Number(this.idAxe.value) === 0 && Number(this.idSousAxe.value) === 0) {
      return;
    }
    this.update.next(true);
  }

  openDialog(o: any) {
    const dialogRef = this.dialog.open(DetailComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: 'Synthèse' }
    });

    return dialogRef.afterClosed();
  }

  selectChange(idTraite: number) {
    this.uow.rapports.getByIdTraite(idTraite).subscribe(r => {
      this.rapports = r as any[];
      console.log(r);
    });
  }

  subString(detail: string) {

    return detail.length > 255 ? `${detail.substring(0, 255)}...` : detail;
  }

  get isAllEmpty(): boolean {
    if (this.idTraite.value === 0 && this.idRapport.value === 0
      && this.idOrganismeEmetteur.value === 0 && this.idAxe.value === 0 && this.idSousAxe.value === 0) {
      return true;
    }
    return false;
  }

  reset() {
    this.idTraite.setValue(0);
    this.idRapport.setValue(0);
    this.idOrganismeEmetteur.setValue(0);
    this.getPage(0, 10, 'id', 'desc', this.session.user.idOrganisme, 0, 0, 0, 0, 0);
  }

}


