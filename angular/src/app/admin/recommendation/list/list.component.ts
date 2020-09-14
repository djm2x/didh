import { DetailComponent } from '../detail/detail.component';

import { Component, OnInit, ViewChild, EventEmitter } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatAutocompleteSelectedEvent, MatInput, MatBottomSheet } from '@angular/material';
import { merge, Observable } from 'rxjs';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { Visite, Recommendation } from 'src/app/Models/models';
import { DeleteService } from '../../components/delete/delete.service';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { SessionService } from 'src/app/shared';
import { switchMap } from 'rxjs/operators';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  // @ViewChild('myAutocomplete', { static: true }) myAutocomplete: MatInput;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;
  dataSource = [];
  columnDefs = [
    { columnDef: 'codeRecommendation', headName: 'CODE' },
    { columnDef: 'nom', headName: 'INTITULE' },
    { columnDef: 'mecanisme', headName: 'mecanisme' },
    { columnDef: 'axe', headName: 'Axe' },
    { columnDef: 'sousAxe', headName: 'SOUS AXE' }, 
    { columnDef: 'organismes', headName: 'DEPARTEMENT' }, 
    { columnDef: 'etat', headName: 'ETAT DE MISE EN OEUVRE' },
    { columnDef: 'observation', headName: '' },
    { columnDef: 'complement', headName: '' },
    { columnDef: 'pieceJointe', headName: '' },
    { columnDef: 'option', headName: '' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });
  //
  panelOpenState = false;
  //
  organismes = this.uow.organismes.get();
  axes = this.uow.axes.get();
  sousAxes = [];
  mecanismes = this.uow.mecanismes;
  visites = this.uow.visites.get();
  organes = this.uow.organes.get();
  pays = this.uow.pays.get();
  cycles = [];
  etats = this.uow.etats;
  myForm: FormGroup;
  //
  displayedColumns = this.columnDefs.map(e => e.columnDef);
  progress = 0;
  message: any;
  formData = new FormData();
  o = new Model();
  myAuto = new FormControl('');
  filteredOptions: Observable<any>;
  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , public mytranslate: MyTranslateService, private fb: FormBuilder, public session: SessionService
    , private route: ActivatedRoute, private bottomSheet: MatBottomSheet) { }

  ngOnInit() {
    this.createForm();
    this.isLoadingResults = false;
    // this.searchAndGet(this.o);
    merge(...[this.sort.sortChange, this.paginator.page, this.update]).subscribe(
      r => {
        r === true ? this.paginator.pageIndex = 0 : r = r;
        !this.paginator.pageSize ? this.paginator.pageSize = 10 : r = r;
        // this.o = new Model();
        this.o.startIndex = this.paginator.pageIndex * this.paginator.pageSize;
        this.o.pageSize = this.paginator.pageSize;
        this.o.sortBy = this.sort.active ? this.sort.active : 'id';
        this.o.sortDir = this.sort.direction ? this.sort.direction : 'desc';
        this.isLoadingResults = true;

        this.searchAndGet(this.o);
      }
    );

    this.uow.cycles.get().subscribe(r => {
      this.cycles = r as any[];
      if (this.cycles.length !== 0) {
        this.myForm.get('idCycle').patchValue(this.cycles[0].id);
      }
    });

    this.route.queryParams.subscribe(params => {
      const id = params['data'];
      if (id) {
        this.uow.recommendations.getDetail(id).subscribe(r => {
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
    console.log(o);
    this.myAuto.setValue(o.label);
    (this.myForm.get('idOrganisme') as FormControl).setValue(o.id);
  }

  createForm() {
    this.myForm = this.fb.group({
      idOrganisme: this.o.idOrganisme,
      mecanisme: this.o.mecanisme,
      idCycle: this.o.idCycle,
      idOrgane: this.o.idOrgane,
      idVisite: this.o.idVisite,
      idAxe: this.o.idAxe,
      nom: this.o.nom,
      etat: this.o.etat,
      idPays: this.o.idPays,
      idSousAxe: this.o.idSousAxe,
      startIndex: this.o.startIndex,
      pageSize: this.o.pageSize,
      sortBy: this.o.sortBy,
      sortDir: this.o.sortDir,
    });
  }

  get mecanisme() { return this.myForm.get('mecanisme') as FormControl; }
  get idVisite() { return this.myForm.get('idVisite') as FormControl; }
  get idCycle() { return this.myForm.get('idCycle') as FormControl; }
  get idOrgane() { return this.myForm.get('idOrgane') as FormControl; }

  get cycleActive() {
    return this.mecanisme.value === 'Examen périodique universal';
  }

  get visiteActive() {
    return this.mecanisme.value === 'Procédure spéciale';
  }

  get organeActive() {
    return this.mecanisme.value === 'Organes de traités';
  }

  selectChange(mecanisme) {
    this.idVisite.setValue(0);
    this.idCycle.setValue(0);
    this.idOrgane.setValue(0);
    // if (this.cycleActive) {
    //   this.idCycle.setValue(null);
    // } else {

    // }
  }

  reset() {
    this.o = new Model();
    this.createForm();
    this.searchAndGet(this.o);
  }

  search(o: Model) {
    this.searchAndGet(o);
  }

  detail(o) {
    this.uow.recommendations.getDetail(o.id).subscribe(r => {
      this.openDialog(r);
    });
  }

  openDialog(o: any) {
    const dialogRef = this.dialog.open(DetailComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: 'Recommdandation' }
    });

    return dialogRef.afterClosed();
  }

  searchAndGet(o: Model) {
    console.log(o);
    this.o = o;
    this.o.idOrganisme = this.session.isPointFocal || this.session.isProprietaire ? this.session.user.idOrganisme : this.o.idOrganisme;
    this.uow.recommendations.searchAndGet(this.o).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }, e => this.isLoadingResults = false,
    );
  }

  async delete(o: Recommendation) {
    const r = await this.mydialog.openDialog('recommandation').toPromise();
    if (r === 'ok') {
      // console.log(o);
      let list = [];

      o.pieceJointe !== '' ? list.push(...this.uow.decoupe(o.pieceJointe)) : list = list;

      this.uow.files.deleteFiles(list, 'recommandation').subscribe(res => {
        this.uow.recommendations.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'recommandation'}});
  }

  axeChange(idAxe: number) {
    this.uow.sousAxes.getByIdAxe(idAxe).subscribe(r => {
      this.sousAxes = r as any[];
    });
  }

  get isAllEmpty(): boolean {
    if (this.myForm.get('idAxe').value.toString() === '0' &&
      this.myForm.get('idCycle').value.toString() === '0' &&
      this.myForm.get('idSousAxe').value.toString() === '0' &&
      this.myForm.get('idOrganisme').value.toString() === '0' &&
      this.myForm.get('idOrgane').value.toString() === '0' &&
      this.myForm.get('idPays').value.toString() === '0' &&
      this.myForm.get('nom').value.toString() === '' &&
      this.myForm.get('etat').value.toString() === '' &&
      this.myForm.get('idVisite').value.toString() === '0' &&
      this.myForm.get('mecanisme').value.toString() === '') {
      return true;
    }
    return false;
  }

}

export class Model {
  idAxe = 0;
  idSousAxe = 0;
  idOrganisme = 0;
  mecanisme = '';
  idCycle = 0;
  idOrgane = 0;
  idVisite = 0;
  nom = '';
  etat = '';
  idPays = 0;
  startIndex = 0;
  pageSize = 10;
  sortBy = 'id';
  sortDir = 'desc';
}


