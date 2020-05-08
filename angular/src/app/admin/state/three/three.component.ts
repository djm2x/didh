import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import { Label, Color } from 'ng2-charts';

@Component({
  selector: 'app-three',
  templateUrl: './three.component.html',
  styleUrls: ['./three.component.scss']
})
export class ThreeComponent implements OnInit {
  public barChartOptions: ChartOptions = {
    responsive: true,
    title: {
      text: 'Nombre recommendation par département',
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
    this.uow.recommendations.recommandationByOrganisme().subscribe((r: { name: string, count: number }[]) => {
      // console.log(r);
      r.map(e => this.barChartLabels.push(e.name));

      this.barChartData[0].data = r.map(e => e.count);
    });
  }

}

