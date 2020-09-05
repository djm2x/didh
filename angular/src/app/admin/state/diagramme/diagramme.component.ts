
import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';
import { Label, SingleDataSet, monkeyPatchChartJsTooltip, monkeyPatchChartJsLegend } from 'ng2-charts';
import { UowService } from 'src/app/services/uow.service';
import { Subject, merge, BehaviorSubject } from 'rxjs';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { SessionService } from 'src/app/shared';
import { MyTranslateService } from 'src/app/my.translate.service';
import { MatTabGroup } from '@angular/material';
import { Model } from '../../recommendation/list/list.component';

@Component({
  selector: 'app-diagramme',
  templateUrl: './diagramme.component.html',
  styleUrls: ['./diagramme.component.scss']
})
export class DiagrammeComponent implements OnInit {
  // @ViewChild('matgroup', { static: true }) matTab: MatTabGroup;
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


  mecanismeSubject = new Subject();
  axesList: { name: string, p: number, t: number }[] = [];
  departementList: { name: string, p: number, t: number }[] = [];
  rotateY = 0;

  toChild = new Subject<Model>();

  constructor(private uow: UowService, private fb: FormBuilder, public session: SessionService
    , public mytranslate: MyTranslateService) {
    monkeyPatchChartJsTooltip();
    monkeyPatchChartJsLegend();
  }

  ngOnInit() {

    this.createForm();
    this.idCycle.setValue(1)
    this.mytranslate.lang.subscribe(r => {
      this.rotateY = r === 'fr' ? 0 : 180;
    });

  }

  searchAndGet(o: Model) {
    // console.log(o);
    o.mecanisme = this.o.mecanisme;
    this.toChild.next(o);
    this.o = o;
    this.o.idOrganisme = this.session.isPointFocal || this.session.isProprietaire ? this.session.user.idOrganisme : this.o.idOrganisme;
    this.uow.recommendations.stateParamAxe(this.o).subscribe((r) => {
      console.log(r);
      // this.mytranslate.get('admin.event.list.Ajouter_evènement')
      this.axesList = [];
      this.axesList = r.axe;
      this.departementList = [];
      this.departementList = r.department;
      // const title = 'l’Etat d’avancement des recommandations par axe';
      // this.listAxes.next({list: r, title});
      const organeList: { name: string, p: number, t: number, r: number }[] = [];
      const epu = {
        name: this.mytranslate.get('admin.state.Examen_Périodique_universelle'),
        p: r.macanisme.epu.p, // .filter(e => e.name !== null).map(e => e.p).reduce((p, c) => p + c),
        t: r.macanisme.epu.t, // .filter(e => e.name !== null).map(e => e.t).reduce((p, c) => p + c),
        r: r.macanisme.epu.r, // .filter(e => e.name !== null).map(e => e.t).reduce((p, c) => p + c),
      };

      const ot = {
        name: this.mytranslate.get('admin.state.Organes_de_Traités'),
        p: r.macanisme.ot.p, // .filter(e => e.name !== null).map(e => e.p).reduce((p, c) => p + c),
        t: r.macanisme.ot.t, // .filter(e => e.name !== null).map(e => e.t).reduce((p, c) => p + c),
        r: r.macanisme.ot.r, // .filter(e => e.name !== null).map(e => e.t).reduce((p, c) => p + c),
      };

      const ps = {
        name: this.mytranslate.get('admin.state.Procédures_spéciales'),
        p: r.macanisme.ps.p, // .filter(e => e.name !== null).map(e => e.p).reduce((p, c) => p + c),
        t: r.macanisme.ps.t, // .filter(e => e.name !== null).map(e => e.t).reduce((p, c) => p + c),
        r: r.macanisme.ps.r, // .filter(e => e.name !== null).map(e => e.t).reduce((p, c) => p + c),
      };

      if (r.macanisme.epu.p !== 0) {
        organeList.push(epu);
      }
      if (r.macanisme.ot.p !== 0) {
        organeList.push(ot);
      }
      if (r.macanisme.ps.p !== 0) {
        organeList.push(ps);
      }

      this.organeDisplay(organeList);
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
    console.log(o.selectedIndex)

    this.selectedIndex = o.selectedIndex;
    this.o.mecanisme = o.selectedIndex === 0 ? 'Examen périodique universal' : (o.selectedIndex === 1 ? 'Organes de traités' : 'Procédure spéciale')



    this.idCycle.setValue(o.selectedIndex === 0 ? 1 : 0);
    this.idOrgane.setValue(o.selectedIndex === 1 ? 1 : 0);
    this.idVisite.setValue(o.selectedIndex === 2 ? 1 : 0);

  }

  organeDisplay(r: { name: string, p: number, t: number, r: number }[]) {
    r = r.filter(e => e.name !== null);
    console.log(r);
    const barChartLabels = r.map(e => e.name);
    const barChartData = [
      { data: [], label: this.mytranslate.get('admin.state.Etat_avancement') },
      { data: [], label: this.mytranslate.get('admin.state.Taux') },
      { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé') },
    ];

    r.forEach(e => {
      barChartData[0].data.push(e.p);
      barChartData[1].data.push(e.t.toFixed(0));
      barChartData[2].data.push(e.r);
    });
    this.mecanismeSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.state.Mise_en_œuvre_des_recommandations_par_Organes_de_Traités') });
  }

  createForm() {
    this.myForm = this.fb.group({
      mecanisme: this.o.mecanisme,
      idCycle: this.o.idCycle,
      idOrgane: this.o.idOrgane,
      idVisite: this.o.idVisite,
      idAxe: this.o.idAxe,
      etat: this.o.etat,
      idSousAxe: this.o.idSousAxe,
      idOrganisme: this.o.idOrganisme,
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

  selectChange(mecanisme: string) {
    // this.idVisite.setValue(0);
    // this.idCycle.setValue(this.cycles[0].id);
    // this.idOrgane.setValue(0);

    this.idCycle.setValue(mecanisme.includes('Examen périodique universal') ? 1 : 0);
    this.idOrgane.setValue(mecanisme.includes('Organes de traités') ? 1 : 0);
    this.idVisite.setValue(mecanisme.includes('Procédure spéciale') ? 1 : 0);

  }

  reset() {
    this.o = new Model();
    this.createForm();
    this.searchAndGet(this.o);
  }

  search(o: Model) {
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

}

export interface IData {
  table: 'axe' | 'organe' | 'visite';
  type: 'count' | 'taux';
  title: string;
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
