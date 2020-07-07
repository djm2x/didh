import { Component, OnInit, Input } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';
import { Label, SingleDataSet, monkeyPatchChartJsTooltip, monkeyPatchChartJsLegend } from 'ng2-charts';
import { UowService } from 'src/app/services/uow.service';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-doughnut',
  templateUrl: './doughnut.component.html',
  styleUrls: ['./doughnut.component.scss']
})
export class DoughnutComponent implements OnInit {
  // @Input() table: 'axe' | 'organe' | 'visite' = 'axe';
  // @Input() type: 'count' | 'taux' = 'taux';
  // @Input() mytitle: '';
  @Input() obs = new Subject<IData>();
  title = '';
  // Pie
  public pieChartOptions: ChartOptions = {
    responsive: true,
    // aspectRatio: 1,
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
    const lbs = ['Taux', 'Etat d’avancement', ''];
    this.obs.subscribe(d => {
      if (d.type === 'stateEPU' as any) {
        this.title = d.title;
        this.uow.recommendations.stateEPU().subscribe(r => {
          this.pieChartLabels = lbs;
          this.pieChartData = [r.t, r.p /*- r.t*/, 100 - r.p];

          this.pieChartColors[0].backgroundColor = this.getColors(this.pieChartLabels.length);
        });
      } else if (d.type === 'stateOT' as any) {
        this.title = d.title;
        this.uow.recommendations.stateOT().subscribe(r => {
          this.pieChartLabels = lbs;
          this.pieChartData = [r.t, r.p /*- r.t*/, 100 - r.p];

          this.pieChartColors[0].backgroundColor = this.getColors(this.pieChartLabels.length);
        });
      } else {
        this.title = d.title;
        this.uow.recommendations.statePS().subscribe(r => {
          this.pieChartLabels = lbs;
          this.pieChartData = [r.t, r.p /*- r.t*/, 100 - r.p];

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
    // const pallet = ['#0074D9', '#FF4136', '#2ECC40', '#FF851B', '#7FDBFF', '#B10DC9', '#FFDC00', '#001f3f', '#39CCCC', '#01FF70', '#85144b', '#F012BE', '#3D9970', '#111111', '#AAAAAA'];
    const pallet = ['#d17c36', '#496488', '#c5c5c500'];
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