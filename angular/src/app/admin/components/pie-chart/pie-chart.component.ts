import { Component, OnInit, Input } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';
import { Label, SingleDataSet, monkeyPatchChartJsTooltip, monkeyPatchChartJsLegend } from 'ng2-charts';
import { UowService } from 'src/app/services/uow.service';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-pie-chart',
  templateUrl: './pie-chart.component.html',
  styleUrls: ['./pie-chart.component.scss']
})
export class PieChartComponent implements OnInit {
  // @Input() table: 'axe' | 'organe' | 'visite' = 'axe';
  // @Input() type: 'count' | 'taux' = 'taux';
  // @Input() mytitle: '';
  @Input() obs = new Subject<IData>();
  title = '';
  // Pie
  public pieChartOptions: ChartOptions = {
    responsive: true,
    title: {
      text: '',
      display: false,
    },
    legend: {
      position: 'chartArea',
      display: false,
    }
  };



  pieChartLabels: Label[] = [/*['Download', 'Sales'], ['In', 'Store', 'Sales'], 'Mail Sales'*/];
  pieChartData: SingleDataSet = [/*300, 500, 100*/];
  @Input() public pieChartType: ChartType = 'pie';
  public pieChartLegend = true;
  public pieChartPlugins = [];
  public pieChartColors = [
    { backgroundColor: [], },
  ];

  constructor(private uow: UowService) {
    monkeyPatchChartJsTooltip();
    monkeyPatchChartJsLegend();
  }

  ngOnInit() {
    this.obs.subscribe(d => {
      if (d.type === 'stateRecommendationByMecanismeTaux' as any) {
        this.title = d.title;
        this.uow.recommendations.stateRecommendationByMecanismeTaux().subscribe(r => {
          this.pieChartLabels = r.map(e => e.table/*.split(' ')*/);
          this.pieChartData = r.map(e => e.value);

          this.pieChartColors[0].backgroundColor = this.getColors(this.pieChartLabels.length);
        });
      } else if (d.type === 'stateRecommendationByMecanismePercentage' as any) {
        this.title = d.title;
        this.uow.recommendations.stateRecommendationByMecanismePercentage().subscribe(r => {
          this.pieChartLabels = r.map(e => e.table/*.split(' ')*/);
          this.pieChartData = r.map(e => e.value);

          this.pieChartColors[0].backgroundColor = this.getColors(this.pieChartLabels.length);
        });
      } else {
        this.title = d.title;
        this.uow.recommendations.genericByRecommendation(d.table, d.type).subscribe(r => {
          this.pieChartLabels = r.map(e => e.table/*.split(' ')*/);
          this.pieChartData = r.map(e => e.value);

          this.pieChartColors[0].backgroundColor = this.getColors(this.pieChartLabels.length);
        });
      }

    })

    // this.pieChartOptions.title.text = this.mytitle;
    //   this.uow.recommendations.genericByRecommendation(this.table, this.type).subscribe(r => {
    //     console.log(r);
    //     this.pieChartLabels = r.map(e => e.table/*.split(' ')*/);
    //     this.pieChartData = r.map(e => e.value);

    //     this.pieChartColors[0].backgroundColor = this.getColors(this.pieChartLabels.length);
    //   });

  }

  getColors(length) {
    // tslint:disable-next-line:max-line-length
    const pallet = [
      '#d97f2a',
      '#2d71a1',
      '#c2c3c6',
      '#ba6446',
      '#7dc460',
      '#fdb93a',
      '#59b8ce',
      '#5c5c5f',
      '#ef4f42',
      '#a5a6aa',
      // '#85144b', a31414
      // '#F012BE',
      // '#3D9970',
      // '#111111',
      // '#AAAAAA',
    ];
    // const pallet = ['#d17c36', '#496488', '#84bc5b'];
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
