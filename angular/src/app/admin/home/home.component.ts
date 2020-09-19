import { SessionService } from 'src/app/shared';
import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit, ViewChild, EventEmitter, ChangeDetectorRef } from '@angular/core';
import { Moment } from 'moment';
import { Subject, BehaviorSubject, Observable } from 'rxjs';
import { IData } from '../components/pie-chart/pie-chart.component';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  // rapports = this.session.isPointFocal ?
  //   this.uow.traites.getCount(this.session.user.idOrganisme) : this.uow.traites.count();
  // recommendations = this.session.isPointFocal ?
  //   this.uow.recommendations.getCount(this.session.user.idOrganisme) : this.uow.recommendations.count();
  //
  // displayedColumns: string[] = ['item', 'cost'];
  mecanismes = this.uow.mecanismes;
  // tslint:disable-next-line: max-line-length
  pieChartSubjectEPU = new BehaviorSubject<IData>({ type: 'stateEPU', title: 'Examen Périodique universel' } as any);
  // tslint:disable-next-line: max-line-length
  pieChartSubjectOT = new BehaviorSubject<IData>({ type: 'stateOT', title: 'Organes de Traités' } as any);
  // tslint:disable-next-line: max-line-length
  pieChartSubjectPS = new BehaviorSubject<IData>({ type: 'statePS', title: 'Procédures spéciales' } as any);
  // pieChartSubject = new BehaviorSubject<IData>({ table: 'axe', type: 'count', title: 'Etat d’avancement des recommandations par axe' });
  // pieChartSubjectC = new BehaviorSubject<IData>({ table: 'axe', type: 'taux', title: 'Taux de recommandations par axe' });
  list: { name: string, p: number, t: number, r: number }[] = [];
  axesValue: { id: number, table: string, value: number }[] = [];

  listSubject: { name: string, p: number, t: number, r: number }[] = [];

  dataEpu = new Subject<{ name: string | Observable<string>, p: number, t: number, r: number }>();
  dataOt = new Subject<{ name: string | Observable<string>, p: number, t: number, r: number }>();
  dataPs = new Subject<{ name: string | Observable<string>, p: number, t: number, r: number }>();
  dataMec = new Subject();
  dataMec1 = new Subject();

  e = new Subject();

  constructor(private uow: UowService, public session: SessionService
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.stateRecommendationByOrganisme();
    this.stateRecommendationByAxe();
    this.stateMecanisme();
    this.stateMecanisme1();
  }

  stateMecanisme1() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {

      // console.log('>>>>>>>>>>>>>>>>>');
      // console.log(r);
      // console.log('>>>>>>>>>>>>>>>>>');

      const chartLabels = [];
      chartLabels.push(this.mytranslate.get('admin.header.ExamenPériodiqueuniverselle'))
      chartLabels.push(this.mytranslate.get('admin.header.OrganesdeTraités'))
      chartLabels.push(this.mytranslate.get('admin.header.Procéduresspéciales'))
      // r = r.filter(e => e.name !== null);
      // const barChartLabels = r.map(e => e.name);
      const chartData = [];
      const dataToShowInTable = [];

      chartData.push(r.epu.t);

      chartData.push(r.ot.t);

      chartData.push(r.ps.t);

      const chartColors = [];
      // for (let i = 0; i < 3; i++) {
      chartColors.push('#ca7834')
      chartColors.push('#7dc460')
      chartColors.push('#2d71a1');

      // }


      this.dataMec1.next({ chartLabels, chartData, chartColors, dataToShowInTable, title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe') });

    });
  }

  stateMecanisme() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {

      // console.log('>>>>>>>>>>>>>>>>>');
      // console.log(r);
      // console.log('>>>>>>>>>>>>>>>>>');

      const chartLabels = [];
      chartLabels.push(this.mytranslate.get('admin.header.ExamenPériodiqueuniverselleEnCours'))
      chartLabels.push(this.mytranslate.get('admin.header.ExamenPériodiqueuniverselleRealise'))
      chartLabels.push(this.mytranslate.get('admin.header.ExamenPériodiqueuniverselleNonRealise'))

      chartLabels.push(this.mytranslate.get('admin.header.OrganesdeTraitésEnCours'))
      chartLabels.push(this.mytranslate.get('admin.header.OrganesdeTraitésRealise'))
      chartLabels.push(this.mytranslate.get('admin.header.OrganesdeTraitésNonRealise'))

      chartLabels.push(this.mytranslate.get('admin.header.ProcéduresspécialesEnCours'))
      chartLabels.push(this.mytranslate.get('admin.header.ProcéduresspécialesRealise'))
      chartLabels.push(this.mytranslate.get('admin.header.ProcéduresspécialesNonRealise'))
      // r = r.filter(e => e.name !== null);
      // const barChartLabels = r.map(e => e.name);
      const chartData = [];
      const dataToShowInTable = [];

      chartData.push(r.epu.p !== 0 ? r.epu.p : 1);
      chartData.push(r.epu.r !== 0 ? r.epu.p : 2);
      chartData.push(r.epu.t - r.epu.r);
      dataToShowInTable.push((r.epu.t - r.epu.r) * 100 / r.epu.t);

      chartData.push(r.ot.p !== 0 ? r.epu.p : 1);
      chartData.push(r.ot.r !== 0 ? r.epu.p : 2);
      chartData.push(r.ot.t - r.ot.r);
      dataToShowInTable.push((r.ot.t - r.ot.r) * 100 / r.ot.t);

      chartData.push(r.ps.p !== 0 ? r.epu.p : 1);
      chartData.push(r.ps.r !== 0 ? r.epu.p : 2);
      chartData.push(r.ps.t - r.ps.r);
      dataToShowInTable.push((r.ps.t - r.ps.r) * 100 / r.ps.t);

      const chartColors = [];
      for (let i = 0; i < 3; i++) {
        chartColors.push('#ca7834')
        chartColors.push('#7dc460')
        chartColors.push('#c2c3c6');

      }


      this.dataMec.next({ chartLabels, chartData, chartColors, dataToShowInTable, title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe') });

    });
  }

  stateMecanisme0() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {
      // console.log(r)
      r.epu.name = this.mytranslate.getObs('admin.home.ExamenPériodiqueuniversell');
      this.dataEpu.next(r.epu);

      r.ot.name = this.mytranslate.getObs('admin.home.OrganesdeTraités');
      this.dataOt.next(r.ot);

      r.ps.name = this.mytranslate.getObs('admin.home.Procéduresspéciales');
      this.dataPs.next(r.ps);
    });
  }

  stateRecommendationByOrganisme() {
    return this.uow.recommendations.stateRecommendationByOrganisme().subscribe(r => {
      this.list = r as any;
    });
  }

  stateRecommendationByAxe() {
    return this.uow.recommendations.stateRecommendationByAxe().subscribe(r => {
      // console.log(r)
      r.pop()
      this.axesValue = r as any;
    });
  }

  selectChange(e: string) {
    const isOrgane = e.toLocaleLowerCase().includes('organe');
    const isExamen = e.toLocaleLowerCase().includes('examen');
    // const isVisite = e.toLocaleLowerCase().includes('procédure');

    const tableS: 'axe' | 'organe' | 'visite' = isOrgane ? 'organe' : (isExamen ? 'axe' : 'visite');

    // this.pieChartSubjectC.next({ table: tableS, type: 'count', title: `Etat d’avancement des recommandations par ${e}` });
    // this.pieChartSubject.next({ table: tableS, type: 'taux', title: `Taux de recommandations par ${e}` });
  }



}
