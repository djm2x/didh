import { DetailComponent } from '../detail/detail.component';

import { Component, OnInit, ViewChild, EventEmitter } from '@angular/core';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
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
import { MatDialog } from '@angular/material/dialog';
import { MatAutocompleteSelectedEvent } from '@angular/material/autocomplete';

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
  // columnDefs = [];
  columnDefs = [
    { columnDef: 'codeRecommendation', headName: 'CODE', show: true },
    { columnDef: 'nom', headName: 'INTITULE', show: true },
    { columnDef: 'mecanisme', headName: 'mecanisme', show: true },
    { columnDef: 'axe', headName: 'Axe', show: true },
    { columnDef: 'sousAxe', headName: 'SOUS AXE', show: true },
    { columnDef: 'organismes', headName: 'DEPARTEMENT', show: false },
    { columnDef: 'etat', headName: 'ETAT DE MISE EN OEUVRE', show: false },
    { columnDef: 'pieceJointe', headName: '', show: false },
    { columnDef: 'complement', headName: '', show: false },
    { columnDef: 'option', headName: '', show: true },
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
  annee = [];

  mecanismes = this.uow.mecanismes;
  visites = this.uow.visites.get();
  organes = this.uow.organes.get();
  pays = this.uow.pays.get();
  cycles = this.uow.cycles.get();
  etats = this.uow.etats;
  myForm: FormGroup;
  //


  departementList: { name: string, p: number, r: number, t: number, type: string }[] = [];

  displayedColumns = this.columnDefs.map(e => e.columnDef);

  progress = 0;
  message: any;
  formData = new FormData();
  o = new Model();
  myAuto = new FormControl('');
  filteredOptions: Observable<any>;
  constructor(public uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , public mytranslate: MyTranslateService, private fb: FormBuilder, public session: SessionService
    , private route: ActivatedRoute, private bottomSheet: MatBottomSheet) {

    if (this.session.isPublic) {
      this.columnDefs = this.columnDefs.filter(e => e.show);

      this.displayedColumns = this.columnDefs.map(e => e.columnDef);
    }

    // console.log(this.columnDefs);
  }

  ngOnInit() {
    this.createForm();
    this.isLoadingResults = false;

    this.uow.recommendations.annee().subscribe(e => {
      this.annee = e;
      this.myForm.get('annee').setValue(this.annee[0]);
    });

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

        console.log(this.o);

        this.searchAndGet(this.o);
      }
    );

    // this.uow.cycles.get().subscribe(r => {
    //   this.cycles = r as any[];
    //   if (this.cycles.length !== 0) {
    //     this.myForm.get('idCycle').patchValue(this.cycles[0].id);
    //   }
    // });

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

  displayFrIfArNull(fr: string, ar: string) {
    if (ar === null || ar === undefined || ar === '' || ar === 'null') {
      return fr;
    } else {
      return ar;
    }
  }

  displayMulti(mc: string, et: string) {
    // console.log(mc, et)
    const etat = [
      { fr: 'Réalisé', ar: 'منجز' },
      { fr: 'Non Réalisé', ar: 'غير منجز' },
      { fr: 'En cours', ar: 'في طور الإنجاز' }
    ];

    const mecanisme = [
      { fr: 'Examen périodique universal', ar: 'الاستعراض الدوري الشامل' },
      { fr: 'Organes de Traités', ar: 'هيئات المعاهدات' },
      { fr: 'Procédures spéciales', ar: 'الاجراءات الخاصة' },
    ];

    if (this.mytranslate.langSync === 'fr') {
      return { m: mc, e: et };
    } else {
      const m = mecanisme.find(o => mc.toLowerCase().includes(o.fr.toLowerCase().substring(0, 6)));
      const e = etat.find(o => o.fr.toLowerCase() === et.toLowerCase())
      return {
        m: m ? m.ar : mc,
        e: e ? e.ar : et,
      };
    }
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
      annee: this.o.annee,
      // idDepartement: this.o.idDepartement,
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
    this.myForm.get('annee').setValue(this.annee[0]);
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
  stateDepartement(r: { name: string, p: number, r: number, t: number, type: string }[]) {
    console.log(r);
    const listToDeletePE = [
      'DGSN',
      'Fonction Public',
      'pêche',
      'Eau',
      'Environnement',
      'Culture',
      'gendarmerie',
      'chef de gouvernement',
    ]

    const listToShowPE = [
      'Intérieur et DGSN',
      'Finance et Fonction Public',
      'Agriculture et pêche',
      'Equipement, Eau et Environnement',
      'Communication et Culture',
      'Défense et gendarmerie',
      'Droits de l’Homme et Relations avec le parlement',
      'Développement social et solidarité',
      'Supprimer le chef de gouvernement',
      'Supprimer l’Observatoire des droits de l’homme',
    ]

    const listToDeleteAutre = [
      'Observatoire des droits de l’homme',
    ]

    // this.uow.recommendations.stateRecommendationByOrganisme().subscribe((r: { name: string, p: number, r: number, t: number, type: string }[]) => {

    r = r.filter(e => e.name !== null);
    // console.log(r);

    // r = r.filter(e => ).map(e => {

    //   return e;
    // })
    const barChartLabelsPE = r.filter(e => e.type === 'PE').map(e => e.name);

    const barChartLabelsIN = r.filter(e => e.type === 'IN').map(e => e.name);
    const barChartLabelsPG = r.filter(e => e.type === 'PG').map(e => e.name);
    const barChartLabelsAutre = r.filter(e => e.type === 'Autre').map(e => e.name);

    // console.log(barChartLabels)
    // console.log(barChartLabels1)

    const barChartDataPE = [
      { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
      { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
      { data: [], label: 'Non réalisé'/*, stack: 'a'*/ },
    ];

    const barChartDataIN = barChartDataPE;
    const barChartDataPJ = barChartDataPE;
    const barChartDataAutre = barChartDataPE;

    // const barChartData1 = [
    //   { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
    //   { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
    //   { data: [], label: 'Non réalisé'/*, stack: 'a'*/ },
    // ];


    r.forEach(e => {
      if (e.type === 'PE') {
        barChartDataPE[0].data.push((e.p * e.t / 100).toFixed(0));
        barChartDataPE[1].data.push((e.r * e.t / 100).toFixed(0));
        barChartDataPE[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
      } else if (e.type === 'Autre') {
        barChartDataAutre[0].data.push((e.p * e.t / 100).toFixed(0));
        barChartDataAutre[1].data.push((e.r * e.t / 100).toFixed(0));
        barChartDataAutre[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
      } else if (e.type === 'IN') {
        barChartDataIN[0].data.push((e.p * e.t / 100).toFixed(0));
        barChartDataIN[1].data.push((e.r * e.t / 100).toFixed(0));
        barChartDataIN[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
      } else if (e.type === 'PJ') {
        barChartDataPJ[0].data.push((e.p * e.t / 100).toFixed(0));
        barChartDataPJ[1].data.push((e.r * e.t / 100).toFixed(0));
        barChartDataPJ[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
      }
    });

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
        this.stateDepartement(this.departementList);

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
    this.bottomSheet.open(DownloadSheetComponent, { data: { fileName, folder: 'recommandation' } });
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
      this.myForm.get('annee').value?.toString() === '0' &&
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
  // idDepartement = 0;
  startIndex = 0;
  pageSize = 10;
  sortBy = 'id';
  sortDir = 'desc';
  annee = 0;
}





