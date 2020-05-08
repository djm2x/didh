import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import { Label, Color } from 'ng2-charts';

@Component({
  selector: 'app-bar-convention',
  templateUrl: './bar-convention.component.html',
  styleUrls: ['./bar-convention.component.scss']
})
export class BarConventionComponent implements OnInit {
  traites = this.uow.traites.get();
  public barChartOptions: ChartOptions = {
    responsive: true,
    title: {
      text: 'Nombre recommendation par axe', //  / cycle actuelle
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

  get(idTraite) {
    this.uow.recommendations.recommandationByConvention(idTraite).subscribe((r: { axe: string, recommandations: number }[]) => {

      this.barChartLabels = r.map(e => e.axe);

      this.barChartData[0].data = r.map(e => e.recommandations);

      // console.log(this.barChartData[0].data, this.barChartLabels)
    });
  }

  selectChange(idTraite) {
    this.get(Number(idTraite));
  }

}



