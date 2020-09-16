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

  e = new Subject();

  constructor(private uow: UowService, public session: SessionService
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.stateRecommendationByOrganisme();
    this.stateRecommendationByAxe();
    this.stateMecanisme();
  }

  stateMecanisme() {
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
      console.log(r)
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

  handleDisplayBar(r: { name: string, p: number, t: number, r: number }[]) {
    r = r.filter(e => e.name !== null);
    console.log(r);
    // r = [r[this.selectedIndex]];
    const barChartLabels = r.map(e => e.name);
    const barChartData = [
      { data: [], label: this.mytranslate.get('admin.state.Etat_avancement') },
      { data: [], label: this.mytranslate.get('admin.state.Taux') },
      { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé') },
    ];

    r.forEach(e => {
      barChartData[0].data.push(e.p);
      barChartData[1].data.push(e.t.toFixed(0));
      barChartData[2].data.push(e.r);
    });
    // tslint:disable-next-line:max-line-length
    this.e.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.state.Mise_en_œuvre_des_recommandations_par_Organes_de_Traités') });
  }


}
