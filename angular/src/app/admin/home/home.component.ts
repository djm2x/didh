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
  dataValues = new Subject();

  departementSubjectPE = new Subject();
  departementSubjectAutre = new Subject();
  departementSubjectIN = new Subject();
  departementSubjectPJ = new Subject();

  e = new Subject();

  constructor(private uow: UowService, public session: SessionService
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.stateRecommendationByOrganisme();
    this.stateRecommendationByAxe();
    // this.stateMecanisme();
    this.stateMecanisme1();
    this.stateDepartement();
    this.RecommandationValues();
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
      chartColors.push('#f47942'); // jeunne
      chartColors.push('#95979a'); // gris
      chartColors.push('#0070a3'); // rouge

      // }


      this.dataMec1.next({
        chartLabels, chartData, chartColors, dataToShowInTable, count: r.count
        // , title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe')
        , title: 'Mise en œuvre des recommandations par mécanismes'
      });

    });
  }

  stateMecanisme() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {

      // console.log('>>>>>>>>>>>>>>>>>');
      // console.log(r.count);
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

      chartData.push(r.epu.p * r.epu.t / 100);
      chartData.push(r.epu.r * r.epu.t / 100);
      chartData.push(r.epu.t - (r.epu.p * r.epu.t / 100) - (r.epu.r * r.epu.t / 100));
      dataToShowInTable.push(chartData[2]);

      chartData.push(r.ot.p * r.ot.t / 100);
      chartData.push(r.ot.r * r.ot.t / 100);
      chartData.push(r.ot.t - (r.ot.p * r.ot.t / 100) - (r.ot.r * r.ot.t / 100));
      dataToShowInTable.push(chartData[5]);

      chartData.push(r.ps.p * r.ps.t / 100);
      chartData.push(r.ps.r * r.ps.t / 100);
      chartData.push(r.ps.t - (r.ps.p * r.ps.t / 100) - (r.ps.r * r.ps.t / 100));
      dataToShowInTable.push(chartData[8]);

      const chartColors = [];
      const arrParent = ['#f4cf3b', '#838383', '#ec6e62'];
      for (let i = 0; i < 3; i++) {
        chartColors.push('#d17c36')
        chartColors.push('#7dc460')
        chartColors.push(arrParent[i]);

      }


      this.dataMec.next({
        chartLabels, chartData, chartColors, dataToShowInTable, count: r.count
        // , title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe')
        , title: 'Mise en œuvre des recommandations par mécanismes Detailée'
      });

    });
  }

  RecommandationValues() {
    this.uow.recommendations.recommandationValues().subscribe((r: any) => {
      const chartLabels = [];
      chartLabels.push('Recommandations réalisées');
      chartLabels.push('Recommandations en cours de réalisation');
      chartLabels.push('Recommandations non réalisées');
      // r = r.filter(e => e.name !== null);
      // const barChartLabels = r.map(e => e.name);
      const chartData = [];
      const dataToShowInTable = [];
      // realise, nonRealise, enCours, count
      chartData.push(r.realise * r.count / 100);

      chartData.push(r.enCours * r.count / 100);

      chartData.push(r.nonRealise * r.count / 100);

      const chartColors = [];
      // for (let i = 0; i < 3; i++) {
      chartColors.push('#14933f'); // jeunne
      chartColors.push('#fcb534'); // gris
      chartColors.push('#c12a1b'); // rouge

      // }


      this.dataValues.next({
        chartLabels, chartData, chartColors, dataToShowInTable, count: r.count
        // , title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe')
        , title: 'Mise en œuvre des recommandations par mécanismes'
      });
    })
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
      // console.log(r)
    });
  }

  stateDepartement() {
    const listToDeletePE = [
      'DGSN',
      'Fonction Public',
      'pêche',
      'Eau',
      'Environnement',
      'Culture',
      'gendarmerie',
      'chef de gouvernement',
    ]

    const listToShowPE = [
      'Intérieur et DGSN',
      'Finance et Fonction Public',
      'Agriculture et pêche',
      'Equipement, Eau et Environnement',
      'Communication et Culture',
      'Défense et gendarmerie',
      'Droits de l’Homme et Relations avec le parlement',
      'Développement social et solidarité',
      'Supprimer le chef de gouvernement',
      'Supprimer l’Observatoire des droits de l’homme',
    ]

    const listToDeleteAutre = [
      'Observatoire des droits de l’homme',
    ]

    this.uow.recommendations.stateRecommendationByOrganisme().subscribe((r: { name: string, p: number, r: number, t: number, type: string }[]) => {

      r = r.filter(e => e.name !== null);
      console.log(r);

      // r = r.filter(e => ).map(e => {

      //   return e;
      // })
      const barChartLabelsPE = r.filter(e => e.type === 'PE').map(e => e.name);

      const barChartLabelsIN = r.filter(e => e.type === 'IN').map(e => e.name);
      const barChartLabelsPG = r.filter(e => e.type === 'PG').map(e => e.name);
      const barChartLabelsAutre = r.filter(e => e.type === 'Autre').map(e => e.name);

      // console.log(barChartLabels)
      // console.log(barChartLabels1)

      const barChartDataPE = [
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
        { data: [], label: 'Non réalisé'/*, stack: 'a'*/ },
      ];

      const barChartDataIN = barChartDataPE;
      const barChartDataPJ = barChartDataPE;
      const barChartDataAutre = barChartDataPE;

      // const barChartData1 = [
      //   { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
      //   { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
      //   { data: [], label: 'Non réalisé'/*, stack: 'a'*/ },
      // ];

      r.forEach(e => {
        if (e.type === 'PE') {
          barChartDataPE[0].data.push((e.p * e.t / 100).toFixed(2));
          barChartDataPE[1].data.push((e.r * e.t / 100).toFixed(2));
          barChartDataPE[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
        } else if (e.type === 'Autre') {
          barChartDataAutre[0].data.push((e.p * e.t / 100).toFixed(2));
          barChartDataAutre[1].data.push((e.r * e.t / 100).toFixed(2));
          barChartDataAutre[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
        } else if (e.type === 'IN') {
          barChartDataIN[0].data.push((e.p * e.t / 100).toFixed(2));
          barChartDataIN[1].data.push((e.r * e.t / 100).toFixed(2));
          barChartDataIN[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
        } else if (e.type === 'PJ') {
          barChartDataPJ[0].data.push((e.p * e.t / 100).toFixed(2));
          barChartDataPJ[1].data.push((e.r * e.t / 100).toFixed(2));
          barChartDataPJ[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
        }
      });
      // tslint:disable-next-line:max-line-length
      this.departementSubjectAutre.next({
        barChartLabels: barChartLabelsAutre, barChartData: barChartDataAutre
        // , title: this.mytranslate.get('admin.home.Miseenœuvredesrecommandationspardépartements') + ' / Autre'
      });

      this.departementSubjectPE.next({
        barChartLabels: barChartLabelsPE, barChartData: barChartDataPE
        // , title: this.mytranslate.get('admin.home.Miseenœuvredesrecommandationspardépartements') + ' / PE'
      });

      this.departementSubjectPJ.next({
        barChartLabels: barChartLabelsPG, barChartData: barChartDataPJ
        // , title: this.mytranslate.get('admin.home.Miseenœuvredesrecommandationspardépartements') + ' / PJ'
      });

      this.departementSubjectIN.next({
        barChartLabels: barChartLabelsIN, barChartData: barChartDataIN
        // , title: this.mytranslate.get('admin.home.Miseenœuvredesrecommandationspardépartements') + ' / IN'
      });
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
