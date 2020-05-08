import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import { Label, Color } from 'ng2-charts';

@Component({
  selector: 'app-bar-two',
  templateUrl: './bar-two.component.html',
  styleUrls: ['./bar-two.component.scss']
})
export class BarTwoComponent implements OnInit {
  cycles = this.uow.cycles.get();
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
  constructor(private uow: UowService) { }

  public barChartColors: Color[] = [
    { backgroundColor: 'rgba(151, 151, 151, 0.514)' },
    { backgroundColor: 'green' },
  ];

  ngOnInit() {
    this.get(0);
  }

  get(idCycle) {
    this.uow.recommendations.recommandationByAxe(idCycle).subscribe((r: { axe: string, recommandations: number }[]) => {

      this.barChartLabels = r.map(e => e.axe);

      this.barChartData[0].data = r.map(e => e.recommandations);

      // console.log(this.barChartData[0].data, this.barChartLabels)
    });
  }

  selectChange(idCycle) {
    this.get(Number(idCycle));
  }

}

