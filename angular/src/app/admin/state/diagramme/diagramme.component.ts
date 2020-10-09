
import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';
import { Label, SingleDataSet, monkeyPatchChartJsTooltip, monkeyPatchChartJsLegend } from 'ng2-charts';
import { UowService } from 'src/app/services/uow.service';
import { Subject, merge, BehaviorSubject, Observable } from 'rxjs';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { SessionService } from 'src/app/shared';
import { MyTranslateService } from 'src/app/my.translate.service';
import { MatTabGroup, MatAutocompleteSelectedEvent } from '@angular/material';
import { Model } from '../../recommendation/list/list.component';

@Component({
  selector: 'app-diagramme',
  templateUrl: './diagramme.component.html',
  styleUrls: ['./diagramme.component.scss']
})
export class DiagrammeComponent implements OnInit {
  @ViewChild('matgroup', { static: false }) myTab: MatTabGroup;
  @Input() obs = new Subject<IData>();
  title = '';
  panelOpenState = false;
  // Pie
  // public pieChartOptions: ChartOptions = {
  //   responsive: true,
  //   title: {
  //     text: '',
  //     display: false,
  //   },
  //   legend: {
  //     position: 'chartArea',
  //     display: false,
  //   }
  // };



  // pieChartLabels: Label[] = [/*['Download', 'Sales'], ['In', 'Store', 'Sales'], 'Mail Sales'*/];
  // pieChartData: SingleDataSet = [/*300, 500, 100*/];
  // public pieChartType: ChartType = 'pie';
  // public pieChartLegend = true;
  // public pieChartPlugins = [];
  // public pieChartColors = [
  //   { backgroundColor: [], },
  // ];

  //
  update = new Subject();
  o = new Model();
  myForm: FormGroup;
  organismes = this.uow.organismes.get();
  axes = this.uow.axes.get();
  sousAxes = [];
  mecanismes = this.uow.mecanismes;
  visites = this.uow.visites.get();
  organes = this.uow.organes.get();
  cycles = this.uow.cycles.get();
  etats = this.uow.etats;
  listAxes = new Subject<any>();
  listOrganisme = new Subject<any>();
  pays = this.uow.pays.get();
  myAuto = new FormControl('');
  filteredOptions: Observable<any>;

  mecanismeSubject = new Subject();
  axesList: { name: string, p: number, t: number }[] = [];
  departementList: { name: string, p: number, r: number, t: number, n: number, type: string }[] = [];
  payeList: { name: string, p: number, t: number }[] = [];
  rotateY = 0;

  toChild = new Subject<Model>();
  pieChartSubjectC = new BehaviorSubject<IPieData>({ table: 'axe', type: 'taux', title: this.mytranslate.getObs('admin.epu.list.Tauxderecommandationsparaxe') });
  pieChartSubject = new BehaviorSubject<IPieData>({ table: 'axe', type: 'etat', title: this.mytranslate.getObs('admin.epu.list.Miseenœuvredesrecommandationsparaxe') });
  pieChartSubjectR = new BehaviorSubject<IPieData>({ table: 'axe', type: 'realise', title: this.mytranslate.getObs('admin.epu.list.Realisé') });

  examenPageSubject = new Subject();
  organePageSubject = new Subject();
  visitePageSubject = new Subject();

  departementSubjectPE = new Subject();
  departementSubjectAutre = new Subject();
  departementSubjectIN = new Subject();
  departementSubjectPJ = new Subject();

  dataMec1 = new Subject();
  dataValues = new Subject();

  @Input() widthOne = 0;
  @Input() widthTwo = 0;
  @Input() widthThree = 0;
  @Input() title2 = '';
  visitePage: { name: string, p: number, t: number, r: number }[] = [];

  constructor(private uow: UowService, private fb: FormBuilder, public session: SessionService
    , public mytranslate: MyTranslateService) {
    monkeyPatchChartJsTooltip();
    monkeyPatchChartJsLegend();
  }
  selected(event: MatAutocompleteSelectedEvent): void {
    const o = event.option.value as any;
    console.log(o);
    this.myAuto.setValue(o.label);
    (this.myForm.get('idOrganisme') as FormControl).setValue(o.id);
  }
  ngOnInit() {

    this.createForm();
    this.mytranslate.lang.subscribe(r => {
      this.rotateY = r === 'fr' ? 0 : 180;
    });

    setTimeout(() => {
      this.reset();
      // this.idCycle.setValue(1);
    }, 300);
    // this.stateMecanisme1();
    // this.RecommandationValues();
  }

  searchAndGet(o: Model) {
    // console.log(o);
    // o.mecanisme = this.o.mecanisme;
    // console.log(o)

    this.toChild.next(Object.assign(new Model(), o));
    this.o.idOrganisme = this.session.isPointFocal || this.session.isProprietaire ? this.session.user.idOrganisme : this.o.idOrganisme;
    this.o = o;
    console.log(this.o)

    this.uow.recommendations.stateParamAxe(this.o).subscribe((r) => {
      // console.log(r);
      // this.mytranslate.get('admin.event.list.Ajouter_evènement')
      this.axesList = [];
      this.axesList = r.axe;
      this.departementList = [];
      this.departementList = r.department;
      this.payeList = [];
      this.payeList = r.pays;


      // const title = 'l’Etat d’avancement des recommandations par axe';
      // this.listAxes.next({list: r, title});
      // const barList: { name: string, p: number, t: number, r: number, n: number }[] = [];
      // const epu = {
      //   name: this.mytranslate.get('admin.state.Examen_Périodique_universelle'),
      //   p: r.mecanisme.epu.p * 100 / r.mecanisme.epu.t,
      //   n: r.mecanisme.epu.n * 100 / r.mecanisme.epu.t,
      //   r: r.mecanisme.epu.r * 100 / r.mecanisme.epu.t,
      // };

      // const ot = {
      //   name: this.mytranslate.get('admin.state.Organes_de_Traités'),
      //   p: r.mecanisme.ot.p * 100 / r.mecanisme.ot.t,
      //   n: r.mecanisme.ot.n * 100 / r.mecanisme.ot.t,
      //   r: r.mecanisme.ot.r * 100 / r.mecanisme.ot.t,
      // };

      // const ps = {
      //   name: this.mytranslate.get('admin.state.Procédures_spéciales'),
      //   p: r.mecanisme.ps.p * 100 / r.mecanisme.ps.t,
      //   n: r.mecanisme.ps.n * 100 / r.mecanisme.ps.t,
      //   r: r.mecanisme.ps.r * 100 / r.mecanisme.ps.t,
      // };

      // if (r.mecanisme.epu.t !== 0) {
      //   barList.push(epu as any);
      // }
      // if (r.mecanisme.ot.t !== 0) {
      //   barList.push(ot as any);
      // }
      // if (r.mecanisme.ps.t !== 0) {
      //   barList.push(ps as any);
      // }

      // console.log(this.axesList)

      // this.allMecanismeBar(barList);
      this.stateAxe(this.axesList);
      this.stateOrgane(r.organe);
      this.stateVisite(r.visite);

      this.stateDepartement(this.departementList);
      this.stateMecanisme1(r.mecanisme, r.count);
      this.RecommandationValues(r.recommandationValues, r.count);
    });

    // this.uow.recommendations.stateParamOrganisme(this.o).subscribe((r: any) => {
    //   // console.log(r);
    //   const title = 'l’Etat d’avancement des recommandations par département';
    //   this.listOrganisme.next({list: r, title});
    // });
  }

  // tslint:disable-next-line: member-ordering
  selectedIndex = 0;

  selectedTabChange(o: MatTabGroup) {
    this.selectedIndex = o.selectedIndex - 1;
    if (this.selectedIndex > -1) {
      this.o.mecanisme = this.selectedIndex === 0 ? 'Examen périodique universal'
        : (this.selectedIndex === 1 ? 'Organes de traités' : 'Procédure spéciale')

      // this.idCycle.setValue(this.selectedIndex === 0 ? 1 : 0);
      // this.idOrgane.setValue(this.selectedIndex === 1 ? 1 : 0);
      // this.idVisite.setValue(this.selectedIndex === 2 ? 1 : 0);
    } else {
      this.o.mecanisme = '';

      this.idCycle.setValue(0);
      this.idOrgane.setValue(0);
      this.idVisite.setValue(0);
    }


    this.myForm.get('mecanisme').setValue(this.o.mecanisme);

    this.searchAndGet(this.o)
  }

  selectChange(mecanisme: string) {
    // this.idVisite.setValue(0);
    // this.idCycle.setValue(this.cycles[0].id);
    // this.idOrgane.setValue(0);

    this.idCycle.setValue(mecanisme.includes('Examen périodique universal') ? 1 : 0);
    this.idOrgane.setValue(mecanisme.includes('Organes de traités') ? 1 : 0);
    this.idVisite.setValue(mecanisme.includes('Procédure spéciale') ? 1 : 0);
  }

  allMecanismeBar(r: { name: string, p: number, t: number, r: number }[]) {
    r = r.filter(e => e.name !== null);
    // console.log(r);
    // r = [r[this.selectedIndex]];
    const barChartLabels = r.map(e => e.name);
    const barChartData = [
      { data: [], label: this.mytranslate.get('admin.state.Etat_avancement')/*, stack: 'a'*/ },
      { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
      { data: [], label: 'Non réalisé'/*, stack: 'a'*/ },
    ];

    r.forEach(e => {
      barChartData[0].data.push((e.p * e.t / 100).toFixed(0));
      barChartData[1].data.push((e.r * e.t / 100).toFixed(0));
      barChartData[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
    });



    // tslint:disable-next-line:max-line-length
    // this.mecanismeSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.state.Mise_en_œuvre_des_recommandations_par_Organes_de_Traités') });


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
      // idDepartement: this.o.idDepartement,

      startIndex: this.o.startIndex,
      pageSize: this.o.pageSize,
      sortBy: this.o.sortBy,
      sortDir: this.o.sortDir,
    });
  }


  get mecanisme() { return this.myForm.get('mecanisme') as FormControl; }
  get idCycle() { return this.myForm.get('idCycle') as FormControl; }
  get idOrgane() { return this.myForm.get('idOrgane') as FormControl; }
  get idVisite() { return this.myForm.get('idVisite') as FormControl; }

  get cycleActive() {
    return this.mecanisme.value === 'Examen périodique universal';
  }

  get visiteActive() {
    return this.mecanisme.value === 'Procédure spéciale';
  }

  get organeActive() {
    return this.mecanisme.value === 'Organes de traités';
  }


  reset() {
    this.o = new Model();
    // this.o.mecanisme = 'Examen périodique universal';
    // this.o.idCycle = 1;
    this.createForm();
    this.searchAndGet(this.o);
    this.myTab.selectedIndex = 0;
    // this.toChild.next(this.o);
  }

  search(o: Model) {
    // console.log(o.idPays, this.myForm.get('idPays').value, o)

    this.searchAndGet(o);
  }



  axeChange(idAxe: number) {
    this.uow.sousAxes.getByIdAxe(idAxe).subscribe(r => {
      this.sousAxes = r as any[];
    });
  }

  get isAllEmpty(): boolean {
    if (
      this.myForm.get('mecanisme').value.toString() === '' &&
      // this.myForm.get('idCycle').value.toString() === '0' &&
      // this.myForm.get('idOrgane').value.toString() === '0' &&
      // this.myForm.get('idVisite').value.toString() === '0' &&
      this.myForm.get('etat').value.toString() === '' &&
      this.myForm.get('idAxe').value.toString() === '0' &&
      this.myForm.get('idSousAxe').value.toString() === '0' &&
      this.myForm.get('idOrganisme').value.toString() === '0'
    ) {
      return false;
    }
    return false;
  }

  getColors(length) {
    // tslint:disable-next-line:max-line-length
    const pallet = ['#0074D9', '#FF4136', '#2ECC40', '#FF851B', '#7FDBFF', '#B10DC9', '#FFDC00', '#001f3f', '#39CCCC', '#01FF70', '#85144b', '#F012BE', '#3D9970', '#111111', '#AAAAAA'];
    const colors = [];

    for (let i = 0; i < length; i++) {
      colors.push(pallet[i % pallet.length]);
    }

    return colors;
  }


  stateOrgane(r) {
    // this.uow.recommendations.stateOrgane().subscribe(r => {

    r = r.filter(e => e.name !== null);
    // console.log(r);
    const barChartLabels = r.map(e => e.name);
    const barChartData = [
      { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement') },
      { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé') },
      { data: [], label: 'Non réalisé' },
    ];

    r.forEach(e => {
      barChartData[0].data.push((e.p * 100 / e.t).toFixed(0));
      barChartData[1].data.push((e.r * 100 / e.t).toFixed(0));
      barChartData[2].data.push((e.n * 100 / e.t).toFixed(0));
    });




    // tslint:disable-next-line:max-line-length
    this.organePageSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.organe.list.MiseenœuvredesrecommandationsparOrganesdeTraités') });
    // });
  }

  stateAxe(r) {
    // this.uow.axes.stateAxes().subscribe(r => {

    r = r.filter(e => e.name !== null);
    // console.log(r);
    const barChartLabels = r.map(e => e.name);
    const barChartData = [
      { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
      { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
      { data: [], label: 'Non réalisé'/*, stack: 'a'*/ },
    ];

    r.forEach(e => {
      barChartData[0].data.push((e.p * 100 / e.t).toFixed(0));
      barChartData[1].data.push((e.r * 100 / e.t).toFixed(0));
      barChartData[2].data.push((e.n * 100 / e.t).toFixed(0));
    });
    // tslint:disable-next-line:max-line-length
    this.examenPageSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.epu.list.EtatAvancementderecommandationsparaxe') });
    // });
  }

  stateVisite(r) {
    // this.uow.visites.stateVisites().subscribe(r => {

    r = r.filter(e => e.name !== null);
    // console.log(r);
    const barChartLabels = r.map(e => e.name);
    const barChartData = [
      { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement') },
      { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé') },
      { data: [], label: 'Non réalisé' },
    ];

    r.forEach(e => {
      barChartData[0].data.push((e.p * 100 / e.t).toFixed(0));
      barChartData[1].data.push((e.r * 100 / e.t).toFixed(0));
      barChartData[2].data.push((e.n * 100 / e.t).toFixed(0));
    });


    // tslint:disable-next-line:max-line-length {{ 'admin.ps.Mise_en_œuvre_des_recommandations_par_Procédures_spéciales' | translate }}
    this.visitePageSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.ps.Mise_en_œuvre_des_recommandations_par_Procédures_spéciales') });
    // });
  }

  stateDepartement(r: { name: string, p: number, r: number, t: number, n: number, type: string }[]) {


    r = r.filter(e => e.name !== null);
    const barChartLabelsPE = r.map(e => e.name);

    const barChartDataPE = [
      { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
      { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
      { data: [], label: this.mytranslate.get('admin.organe.list.NonRéalisé')/*, stack: 'a'*/ },
    ];

    if (this.o.etat === 'En cours') {
      r.forEach(e => {
        barChartDataPE[0].data.push((e.p * 100 / e.t).toFixed(0));
        barChartDataPE[1].data.push(0);
        barChartDataPE[2].data.push(0);
      });
    } else if (this.o.etat === 'Réalisé') {
      r.forEach(e => {
        barChartDataPE[0].data.push(0);
        barChartDataPE[1].data.push((e.r * 100 / e.t).toFixed(0));
        barChartDataPE[2].data.push(0);
      });
    } else if (this.o.etat === 'Non réalisé') {
      r.forEach(e => {
        barChartDataPE[0].data.push(0);
        barChartDataPE[1].data.push(0);
        barChartDataPE[2].data.push((e.n * 100 / e.t).toFixed(0));
      });
    } else {
      r.forEach(e => {
        barChartDataPE[0].data.push((e.p * 100 / e.t).toFixed(0));
        barChartDataPE[1].data.push((e.r * 100 / e.t).toFixed(0));
        barChartDataPE[2].data.push((e.n * 100 / e.t).toFixed(0));
      });
    }



    this.departementSubjectPE.next({
      barChartLabels: barChartLabelsPE, barChartData: barChartDataPE
      // , title: this.mytranslate.get('admin.home.Miseenœuvredesrecommandationspardépartements') + ' / PE'
    });
  }

  RecommandationValues(r, count: number) {
    // this.uow.recommendations.recommandationValues().subscribe((r: any) => {
    const chartLabels = [];
    chartLabels.push('Recommandations réalisées');
    chartLabels.push('Recommandations en cours de réalisation');
    chartLabels.push('Recommandations non réalisées');
    // r = r.filter(e => e.name !== null);
    // const barChartLabels = r.map(e => e.name);
    const chartData = [];
    const dataToShowInTable = [];
    // realise, nonRealise, enCours, count
    chartData.push(r.realise * 100 / count);

    chartData.push(r.enCours * 100 / count);

    chartData.push(r.nonRealise * 100 / count);

    const chartColors = [];
    // for (let i = 0; i < 3; i++) {
    chartColors.push('#14933f'); // jeunne
    chartColors.push('#fcb534'); // gris
    chartColors.push('#c12a1b'); // rouge

    // }


    this.dataValues.next({
      chartLabels, chartData, chartColors, dataToShowInTable, count: r.count
      // , title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe')
      , title: 'Mise en œuvre des recommandations par mécanismes'
    });
    // })
  }

  stateMecanisme1(r, count: number) {
    // this.uow.recommendations.stateMecanisme().subscribe(r => {

    // console.log('>>>>>>>>>>>>>>>>>');
    // console.log(r);
    // console.log('>>>>>>>>>>>>>>>>>');

    const chartLabels = [];
    chartLabels.push(this.mytranslate.get('admin.header.ExamenPériodiqueuniverselle'))
    chartLabels.push(this.mytranslate.get('admin.header.OrganesdeTraités'))
    chartLabels.push(this.mytranslate.get('admin.header.Procéduresspéciales'))
    // r = r.filter(e => e.name !== null);
    // const barChartLabels = r.map(e => e.name);
    const chartData = [];
    const dataToShowInTable = [];

    chartData.push(+r.epu.t * 100 / count);

    chartData.push(+r.ot.t * 100 / count);

    chartData.push(+r.ps.t * 100 / count);

    const chartColors = [];
    // for (let i = 0; i < 3; i++) {
    chartColors.push('#f47942'); // jeunne
    chartColors.push('#95979a'); // gris
    chartColors.push('#0070a3'); // rouge

    // }


    this.dataMec1.next({
      chartLabels, chartData, chartColors, dataToShowInTable, count: r.count
      // , title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe')
      , title: 'Mise en œuvre des recommandations par mécanismes'
    });

    // });
  }

}

export interface IData {
  table: 'axe' | 'organe' | 'visite';
  type: 'count' | 'taux';
  title: string;
}

export interface IPieData {
  table: 'axe' | 'organe' | 'visite';
  type: 'taux' | 'etat' | 'realise';
  title: string | Observable<string>;
}


// class Model {
//   mecanisme = '';
//   idCycle = 0;
//   idOrgane = 0;
//   idVisite = 0;
//   idAxe = 0;
//   etat = '';
//   idSousAxe = 0;
//   idOrganisme = 0;
// }
