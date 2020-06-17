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
  pieChartSubject = new BehaviorSubject<IData>({table: 'axe', type: 'count', title: 'Etat d’avancement des recommandations par axe'});
  pieChartSubjectC = new BehaviorSubject<IData>({table: 'axe', type: 'taux', title: 'Taux de recommandations par axe'});

  constructor(private uow: UowService, public session: SessionService) { }

  ngOnInit() {
  }

  selectChange(e: string) {
    const isOrgane = e.toLocaleLowerCase().includes('organe');
    const isExamen = e.toLocaleLowerCase().includes('examen');
    // const isVisite = e.toLocaleLowerCase().includes('procédure');
    
    const table: 'axe' | 'organe' | 'visite' = isOrgane ? 'organe' : (isExamen ? 'axe' : 'visite');

    console.log(table)
    
    this.pieChartSubjectC.next({table: table, type: 'count', title: `Etat d’avancement des recommandations par ${e}`});
    this.pieChartSubject.next({table: table, type: 'taux', title: `Taux de recommandations par ${e}`});
  }

}
