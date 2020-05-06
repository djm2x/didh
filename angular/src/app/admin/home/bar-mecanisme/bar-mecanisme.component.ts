
import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import { Label, Color } from 'ng2-charts';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-bar-mecanisme',
  templateUrl: './bar-mecanisme.component.html',
  styleUrls: ['./bar-mecanisme.component.scss']
})
export class BarMecanismeComponent implements OnInit {
  public barChartOptions: ChartOptions = {
    responsive: true,
    title: {
      text: 'Nombre recommendation par axe',
      display: true,
    },
    scales: {
      yAxes: [{
        ticks: {
          beginAtZero: true,
          stepSize: 1,
          major: {
            enabled: true
          }
        }
      }]
    }
  };
  public barChartLabels: Label[] = [];
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  public barChartPlugins = [];

  public barChartData: ChartDataSets[] = [
    { data: [0], label: ''},

  ];
  //
  mecanismes = this.uow.mecanismes;
  cycles = this.uow.cycles.get();
  visites = this.uow.visites.get();
  organes = this.uow.organes.get();
  //
  selectInput = new FormControl(0);
  idVisite = new FormControl(0);
  idCycle = new FormControl(0);
  idOrgane = new FormControl(0);
  constructor(private uow: UowService) { }

  public barChartColors: Color[] = [
    { backgroundColor: 'rgba(151, 151, 151, 0.514)' },
    { backgroundColor: 'green' },
  ];

  ngOnInit() {
    this.get(0, 0, 0);
  }

  get(idCycle, idOrgane, idVisite) {
    this.uow.recommendations.recommandationByMecanisme(idCycle, idOrgane, idVisite)
      .subscribe((r: { axe: string, recommandations: number }[]) => {

      this.barChartLabels = r.map(e => e.axe);

      this.barChartData[0].data = r.map(e => e.recommandations);
      // console.log(this.barChartData[0].data, this.barChartLabels)
    });
  }

  selectChange(e) {
    this.get(
      this.idCycle.value ? this.idCycle.value : 0,
      this.idOrgane.value ? this.idOrgane.value : 0,
      this.idVisite.value ? this.idVisite.value : 0);
  }

  search() {
    this.get(
      this.idCycle.value ? this.idCycle.value : 0,
      this.idOrgane.value ? this.idOrgane.value : 0,
      this.idVisite.value ? this.idVisite.value : 0);
  }

  get cycleActive() {
    return this.selectInput.value === 'Examen périodique universal';
  }

  get visiteActive() {
    return this.selectInput.value === 'Procédure spéciale';
  }

  get organeActive() {
    return this.selectInput.value === 'Organes de traités';
  }

  selectMecanismeChange(e) {
    // this.idOrganisme = idOrganisme;
    // this.selectedList = [];
    this.idVisite.setValue(null);
    this.idCycle.setValue(null);
    this.idOrgane.setValue(null);
    // this.getPage(0, 10, 'id', 'desc', mecanisme);
  }

}
