import { Component, OnInit, Input } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import { Label } from 'ng2-charts';
import { Subject } from 'rxjs';
import { MyTranslateService } from 'src/app/my.translate.service';
import { DetailComponent } from '../detail/detail.component';
import { MatDialog } from '@angular/material/dialog';
// import * as pluginLabels from 'chartjs-plugin-labels';
// import * as Chart from 'chart.js';

@Component({
  selector: 'app-bar',
  templateUrl: './bar.component.html',
  styleUrls: ['./bar.component.scss']
})
export class BarComponent implements OnInit {
  title = '';
  public barChartOptions: ChartOptions = {
    responsive: true,
    maintainAspectRatio: false,
    title: {
      text: '',
      display: true,
    },
    // We use these empty structures as placeholders for dynamic theming.
    scales: {
      xAxes: [{
        ticks: {
          fontSize: 16,
        }
      }],
      yAxes: [{
        ticks: {
          beginAtZero: true,
        },
        scaleLabel: {
          display: false,
          labelString: '%',
          // fontSize: 20,
        },
        position: 'top',
      }]
    },
    legend: {
      position: 'top',
      // display: false,
      rtl: this.mytranslate.langSync === 'ar',
      align: 'center',
      // textDirection: this.mytranslate.langSync === 'fr'
      labels: {
        fontSize: 16,
        padding: 10,
      }
    },
    // plugins: {

    //   labels: {
    //     // fontColor: ['#00000000',],
    //     precision: 0,
    //     render: 'value',
    //   },
    //   pieceLabel: {
    //     render: (args) => {
    //       const label = args.label;
    //       const value = args.value;
    //       return label + ': ' + value;
    //     }
    //   },
    // }
  };


  public barChartLabels: Label[] = [/*'2006', '2007', '2008', '2009', '2010', '2011', '2012'*/];
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  pieChartPlugins = [
    // pluginLabels,
    {
      beforeInit: (chart, options) => {
        chart.legend.afterFit = function () {
          // this.padding += 20;
          this.height += 15; // must use `function` and not => because of `this`
        };
      },
    }
  ];
  public barChartData: ChartDataSets[] = [
    { data: [/*65, 59, 80, 81, 56, 55, 40*/], label: '' },
    // { data: [28, 48, 40, 19, 86, 27, 90], label: 'Series B' }
  ];


  public pieChartColors = [
    // { backgroundColor: ['#d17c36', '#2d71a1'], },
    { backgroundColor: '#2b960b' }, // realise
    { backgroundColor: '#db0707' }, // nonRealise
    { backgroundColor: '#f7801e' }, // enCours
    { backgroundColor: '#2d71a1' }, // recommendationContinue
  ];

  @Input() dataSubject = new Subject();
  @Input() height = '40vh';
  @Input() col = 12;
  retate = 0;

  list: { name: string, t: number, p: number, r: number, n: number }[] = [];

  constructor(public mytranslate: MyTranslateService, public dialog: MatDialog) { }

  ngOnInit() {
    this.mytranslate.lang.subscribe(lang => {
      this.retate = lang === 'fr' ? 0 : 180;
      // this.barChartOptions.legend.position = lang === 'fr' ? 'right' : 'left';
    });

    // Chart.Legend.prototype.afterFit = function() {
    //   this.height = this.height + 50;
    // };

    this.dataSubject.subscribe((r: { barChartLabels: Label[], barChartData: ChartDataSets[], title: string }) => {
      this.title = r.title;

      console.log(r)

      // const nonRealise = r.barChartLabels[0];
      // const enCours = r.barChartLabels[1];
      // const recommendationContinue = r.barChartLabels[2];
      // const realise = r.barChartLabels[3];

      // r.barChartLabels[0] = realise;
      // r.barChartLabels[1] = nonRealise;
      // r.barChartLabels[2] = enCours;
      // r.barChartLabels[3] = recommendationContinue;


      this.barChartLabels =  this.swap(r.barChartLabels); // .map(e => e.toString().substring(0, 35) + ' ...');

      // const nonRealise2 = r.barChartData[0] as any;
      // const enCours2 = r.barChartData[1] as any;
      // const recommendationContinue2 = r.barChartData[2] as any;
      // const realise2 = r.barChartData[3] as any;

      // r.barChartData[0] = realise2 as any;
      // r.barChartData[1] = nonRealise2 as any;
      // r.barChartData[2] = enCours2 as any;
      // r.barChartData[3] = recommendationContinue2 as any;

      this.barChartData = this.swap(r.barChartData);

      // console.log(r)
      // // console.log(this.barChartData[0].data[0])
      // // console.log(this.barChartData[1].data[0])
      // // console.log(this.barChartData[2].data[0])

      // this.pieChartColors[0].backgroundColor = this.getColors(2);
      // // console.log(this.barChartLabels)

      // r.barChartLabels.forEach((e, i) => {
      //   this.list.push({
      //     name: e.toString(),
      //     // p: +this.barChartData.find(f => f.label === 'En cours').data[i] as number,
      //     // r: +this.barChartData.find(f => f.label === 'Réalisé').data[i] as number,
      //     // n: +this.barChartData.find(f => f.label.toLowerCase() === 'Non réalisé'.toLowerCase()).data[i] as number,
      //     // t: this.barChartData.find(f => f.label === 'Taux').data[i] as number,
      //     p: +this.barChartData.find((f, j) => j === 0).data[i] as number,
      //     r: +this.barChartData.find((f, j) => j === 1).data[i] as number,
      //     n: +this.barChartData.find((f, j) => j === 2).data[i] as number,
      //   } as any);
      // });


      // // console.log(this.list)

    });
  }

  swap(arra: any[]): any[] {
    [arra[0], arra[arra.length - 1]] = [arra[arra.length - 1], arra[0]];
    return arra;
}

  openDialog() {
    const conf = {
      width: '7100px',
      disableClose: false,
      data: { model: this.list, type: 'bar', title: this.title }
    };

    this.dialog.open(DetailComponent, conf).afterClosed().subscribe(r => {
      // console.log(r);
    });
  }

  // events
  public chartClicked({ event, active }: { event: MouseEvent, active: {}[] }): void {
    // // console.log(event, active);
  }

  public chartHovered({ event, active }: { event: MouseEvent, active: {}[] }): void {
    // // console.log(event, active);
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
