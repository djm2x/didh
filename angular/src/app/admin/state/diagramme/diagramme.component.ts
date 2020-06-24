
import { Component, OnInit, Input } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';
import { Label, SingleDataSet, monkeyPatchChartJsTooltip, monkeyPatchChartJsLegend } from 'ng2-charts';
import { UowService } from 'src/app/services/uow.service';
import { Subject, merge, BehaviorSubject } from 'rxjs';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { SessionService } from 'src/app/shared';

@Component({
  selector: 'app-diagramme',
  templateUrl: './diagramme.component.html',
  styleUrls: ['./diagramme.component.scss']
})
export class DiagrammeComponent implements OnInit {
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
  cycles = [];
  listAxes = new Subject<any>();
  listOrganisme = new Subject<any>();


  constructor(private uow: UowService, private fb: FormBuilder, public session: SessionService) {
    monkeyPatchChartJsTooltip();
    monkeyPatchChartJsLegend();
  }

  ngOnInit() {

    // console.log(0 % 3);
    // console.log(1 % 3);
    // console.log(2 % 3);

    // merge(...[this.update]).subscribe(r => {
    //   this.searchAndGet(this.o);
    // });

    // this.uow.cycles.get().subscribe(r => {
    //   this.cycles = r as any[];
    //   if (this.cycles.length !== 0) {
    //     this.myForm.get('idCycle').patchValue(this.cycles[0].id);
    //   }
    // });

    // this.obs.subscribe(d => {
    //   this.title = d.title;
    //   this.uow.recommendations.genericByRecommendation(d.table, d.type).subscribe(r => {
    //     this.pieChartLabels = r.map(e => e.table/*.split(' ')*/);
    //     this.pieChartData = r.map(e => e.value);

    //     this.pieChartColors[0].backgroundColor = this.getColors(this.pieChartLabels.length);
    //   });
    // });

    this.createForm();

    // this.pieChartOptions.title.text = this.mytitle;
    //   this.uow.recommendations.genericByRecommendation(this.table, this.type).subscribe(r => {
    //     console.log(r);
    //     this.pieChartLabels = r.map(e => e.table/*.split(' ')*/);
    //     this.pieChartData = r.map(e => e.value);

    //     this.pieChartColors[0].backgroundColor = this.getColors(this.pieChartLabels.length);
    //   });

  }

  createForm() {
    this.myForm = this.fb.group({
      mecanisme: this.o.mecanisme,
      idCycle: this.o.idCycle,
      idOrgane: this.o.idOrgane,
      idVisite: this.o.idVisite,
      idAxe: this.o.idAxe,
      idSousAxe: this.o.idSousAxe,
      idOrganisme: this.o.idOrganisme,
    });
  }

  get mecanisme() { return this.myForm.get('mecanisme') as FormControl; }
  get idCycle() { return this.myForm.get('idCycle') as FormControl; }
  get idOrgane() { return this.myForm.get('idOrgane') as FormControl; }
  get idVisite() { return this.myForm.get('idVisite') as FormControl; }

  // get cycleActive() {
  //   return this.mecanisme.value === 'Examen périodique universal';
  // }

  // get visiteActive() {
  //   return this.mecanisme.value === 'Procédure spéciale';
  // }

  // get organeActive() {
  //   return this.mecanisme.value === 'Organes de traités';
  // }

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

  searchAndGet(o: Model) {
    console.log(o);
    this.o = o;
    this.o.idOrganisme = this.session.isPointFocal || this.session.isProprietaire ? this.session.user.idOrganisme : this.o.idOrganisme;
    this.uow.recommendations.stateParamAxe(this.o).subscribe((r) => {
      // console.log(r);
      const title = 'l’Etat d’avancement des recommandations par axe';
      this.listAxes.next({list: r, title});
    });

    this.uow.recommendations.stateParamOrganisme(this.o).subscribe((r: any) => {
      // console.log(r);
      const title = 'l’Etat d’avancement des recommandations par département';
      this.listOrganisme.next({list: r, title});
    });
  }

  axeChange(idAxe: number) {
    this.uow.sousAxes.getByIdAxe(idAxe).subscribe(r => {
      this.sousAxes = r as any[];
    });
  }

  get isAllEmpty(): boolean {
    if (
      this.myForm.get('mecanisme').value.toString() === '' &&
      this.myForm.get('idCycle').value.toString() === '0' &&
      this.myForm.get('idOrgane').value.toString() === '0' &&
      this.myForm.get('idVisite').value.toString() === '0' &&
      this.myForm.get('idAxe').value.toString() === '0' &&
      this.myForm.get('idSousAxe').value.toString() === '0' &&
      this.myForm.get('idOrganisme').value.toString() === '0'
    ) {
      return true;
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

class Model {
  mecanisme = '';
  idCycle = 0;
  idOrgane = 0;
  idVisite = 0;
  idAxe = 0;
  idSousAxe = 0;
  idOrganisme = 0;
}
