import { SessionService } from 'src/app/shared';
import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit, ViewChild, EventEmitter, ChangeDetectorRef } from '@angular/core';
import { Moment } from 'moment';
import { Subject, BehaviorSubject } from 'rxjs';
import { IData } from '../components/pie-chart/pie-chart.component';

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
  pieChartSubjectEPU = new BehaviorSubject<IData>({ type: 'stateEPU', title: 'Examen Périodique universell' } as any);
  // tslint:disable-next-line: max-line-length
  pieChartSubjectOT = new BehaviorSubject<IData>({ type: 'stateOT', title: 'Organes de Traités' } as any);
  // tslint:disable-next-line: max-line-length
  pieChartSubjectPS = new BehaviorSubject<IData>({ type: 'statePS', title: 'Procédures spéciales' } as any);
  // pieChartSubject = new BehaviorSubject<IData>({ table: 'axe', type: 'count', title: 'Etat d’avancement des recommandations par axe' });
  // pieChartSubjectC = new BehaviorSubject<IData>({ table: 'axe', type: 'taux', title: 'Taux de recommandations par axe' });
  list: { name: string, p: number, t: number }[] = [];
  axesValue: { id: number, table: string, value: number }[] = [];

  constructor(private uow: UowService, public session: SessionService) { }

  ngOnInit() {
    this.stateRecommendationByOrganisme();
    this.stateRecommendationByAxe();
  }

  stateRecommendationByOrganisme() {
    return this.uow.recommendations.stateRecommendationByOrganisme().subscribe(r => {
      this.list = r as any;
    });
  }

  stateRecommendationByAxe() {
    return this.uow.recommendations.stateRecommendationByAxe().subscribe(r => {
      // console.log(r)
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
