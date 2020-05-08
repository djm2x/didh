import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import { Label, Color } from 'ng2-charts';

@Component({
  selector: 'app-bar-one',
  templateUrl: './bar-one.component.html',
  styleUrls: ['./bar-one.component.scss']
})
export class BarOneComponent implements OnInit {
  public barChartOptions: ChartOptions = {
    responsive: true,
    title: {
      text: 'Nombre recommendation par cycle',
      display: true,
    },
    scales: {
      yAxes: [{
        ticks: {
          beginAtZero: true
        }
      }]
    }
  };
  public barChartLabels: Label[] = [];
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  public barChartPlugins = [];

  public barChartData: ChartDataSets[] = [
    { data: [0], label: '' },

  ];
  constructor(private uow: UowService) { }

  public barChartColors: Color[] = [
    { backgroundColor: 'rgba(151, 151, 151, 0.514)' },
    { backgroundColor: 'green' },
  ];

  ngOnInit() {
    this.uow.recommendations.recommandationByCycle().subscribe((r: { cycle: string, recommandations: number }[]) => {
      // console.log(r);
      r.map(e => this.barChartLabels.push(e.cycle));

      this.barChartData[0].data = r.map(e => e.recommandations);
    });
  }

}
