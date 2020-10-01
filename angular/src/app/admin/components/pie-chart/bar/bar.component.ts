import { Component, OnInit, Input } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import { Label, SingleDataSet, monkeyPatchChartJsTooltip, monkeyPatchChartJsLegend } from 'ng2-charts';
import { UowService } from 'src/app/services/uow.service';
import { Subject } from 'rxjs';
import { MyTranslateService } from 'src/app/my.translate.service';
import { DetailComponent } from '../detail/detail.component';
import { MatDialog } from '@angular/material';
import * as pluginLabels from 'chartjs-plugin-labels';
@Component({
  selector: 'app-bar',
  templateUrl: './bar.component.html',
  styleUrls: ['./bar.component.scss']
})
export class BarComponent implements OnInit {
  title = '';
  public barChartOptions: ChartOptions = {
    responsive: true,
    title: {
      text: '',
      display: true,
    },
    // We use these empty structures as placeholders for dynamic theming.
    scales: {
      xAxes: [{}], yAxes: [{
        ticks: {
          beginAtZero: true
        }
      }]
    },
    plugins: {
      labels: {
        // fontColor: ['#00000000',],
        precision: 0,
        render: 'value',
      },
      pieceLabel: {
        render: (args) => {
          const label = args.label;
          const value = args.value;
          return  label + ': ' + value;
        }
      }
    }
  };
  public barChartLabels: Label[] = [/*'2006', '2007', '2008', '2009', '2010', '2011', '2012'*/];
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  pieChartPlugins = [pluginLabels];
  public barChartData: ChartDataSets[] = [
    { data: [/*65, 59, 80, 81, 56, 55, 40*/], label: '' },
    // { data: [28, 48, 40, 19, 86, 27, 90], label: 'Series B' }
  ];


  public pieChartColors = [
    // { backgroundColor: ['#d17c36', '#2d71a1'], },
    { backgroundColor: '#d17c36' },
    { backgroundColor: '#7dc460' },
    { backgroundColor: '#db0707' },
  ];

  @Input() dataSubject = new Subject();
  @Input() col = 8;
  retate = 0;

  list: { name: string, t: number, p: number, r: number }[] = [];

  constructor(public mytranslate: MyTranslateService, public dialog: MatDialog) { }

  ngOnInit() {
    this.mytranslate.lang.subscribe(lang => {
      this.retate = lang === 'fr' ? 0 : 180;
    });

    this.dataSubject.subscribe((r: { barChartLabels: Label[], barChartData: ChartDataSets[], title: string }) => {
      this.title = r.title;
      this.barChartLabels = r.barChartLabels;
      this.barChartData = r.barChartData;


      // this.pieChartColors[0].backgroundColor = this.getColors(2);
      // console.log(this.barChartLabels)
      // console.log(this.barChartData)

      this.barChartLabels.forEach((e, i) => {
          this.list.push({
            name: e.toString(),
            p: this.barChartData.find(f => f.label === 'En cours').data[i] as number,
            r: this.barChartData.find(f => f.label === 'Réalisé').data[i] as number,
            t: this.barChartData.find(f => f.label === 'Non réalisé').data[i] as number,
            // t: this.barChartData.find(f => f.label === 'Taux').data[i] as number,
          });
      });
    });
  }

  openDialog() {
    const conf = {
      width: '7100px',
      disableClose: false,
      data: { model: this.list, type: 'bar', title: this.title }
    };

    this.dialog.open(DetailComponent, conf).afterClosed().subscribe(r => {
      console.log(r);
    });
  }

  // events
  public chartClicked({ event, active }: { event: MouseEvent, active: {}[] }): void {
    // console.log(event, active);
  }

  public chartHovered({ event, active }: { event: MouseEvent, active: {}[] }): void {
    // console.log(event, active);
  }

  public randomize(): void {
    this.barChartType = this.barChartType === 'bar' ? 'line' : 'bar';
  }

  getColors(length) {
    // tslint:disable-next-line:max-line-length
    const pallet = ['#0074D9', '#2ECC40', '#FF4136', '#FF851B', '#7FDBFF', '#B10DC9', '#FFDC00', '#001f3f', '#39CCCC', '#01FF70', '#85144b', '#F012BE', '#3D9970', '#111111', '#AAAAAA'];
    // const pallet = ['#d17c36', '#2d71a1'];
    const colors = [];

    for (let i = 0; i < length; i++) {
      colors.push(pallet[i % pallet.length]);
    }

    return colors;
  }
}
