import { Component, OnInit, ViewChild, EventEmitter, Input } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatAutocompleteSelectedEvent, MatInput, MatBottomSheet } from '@angular/material';
import { merge, Observable, Subject } from 'rxjs';
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
import { Model } from '../../recommendation/list/list.component';

@Component({
  selector: 'app-recomm',
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
    // { columnDef: 'codeRecommendation', headName: 'CODE' },
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
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });
  //
  displayedColumns = this.columnDefs.map(e => e.columnDef);

  @Input() fromParent = new Subject<Model>();

  o = new Model();
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
  progress = 0;
  message: any;
  formData = new FormData();
  myAuto = new FormControl('');
  filteredOptions: Observable<any>;
  constructor(private uow: UowService, public session: SessionService, private bottomSheet: MatBottomSheet
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.isLoadingResults = false;
    // this.searchAndGet(this.o);
    // this.fromParent.subscribe(o => {
    //   o.idOrganisme = this.session.isPointFocal || this.session.isProprietaire ? this.session.user.idOrganisme : o.idOrganisme;

    //   o.startIndex = 0;
    //   o.pageSize = 10;
    //   o.sortBy = 'id';
    //   o.sortDir = 'desc';
    //   o.nom = '';
    //   o.idPays = 0;

    //   console.log(o.mecanisme)

    //   this.uow.recommendations.searchAndGet(o).subscribe((r: any) => {
    //     console.log(r.list);
    //     this.dataSource = r.list;
    //     this.resultsLength = r.count;
    //     this.isLoadingResults = false;
    //   });
    // });

    merge(...[this.sort.sortChange, this.paginator.page, this.fromParent]).subscribe(
      o => {


        if (o.mecanisme !== undefined) {
          this.o = o;
          // console.log(this.o)
        }
        // r === true ? this.paginator.pageIndex = 0 : r = r;
        !this.paginator.pageSize ? this.paginator.pageSize = 10 : o = o;
        // this.o = new Model();
        this.o.startIndex = this.paginator.pageIndex * this.paginator.pageSize;
        this.o.pageSize = this.paginator.pageSize;
        this.o.sortBy = this.sort.active ? this.sort.active : 'id';
        this.o.sortDir = this.sort.direction ? this.sort.direction : 'desc';
        this.o.nom = '';
        this.o.idPays = 0;
        this.isLoadingResults = true;
        this.o.idOrganisme = this.session.isPointFocal || this.session.isProprietaire ? this.session.user.idOrganisme : o.idOrganisme;

        this.uow.recommendations.searchAndGet(this.o).subscribe((r: any) => {
          // console.log(r.list);
          this.dataSource = r.list;
          this.resultsLength = r.count;
          this.isLoadingResults = false;
        });
      }
    );
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'recommandation'}});
  }



}


