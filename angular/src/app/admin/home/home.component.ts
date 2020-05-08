import { SessionService } from 'src/app/shared';
import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit, ViewChild, EventEmitter, ChangeDetectorRef } from '@angular/core';
import { Moment } from 'moment';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  rapports = this.session.isPointFocal ?
    this.uow.traites.getCount(this.session.user.idOrganisme) : this.uow.traites.count();
  recommendations = this.session.isPointFocal ?
    this.uow.recommendations.getCount(this.session.user.idOrganisme) : this.uow.recommendations.count();
  //
  displayedColumns: string[] = ['item', 'cost'];

  constructor(private uow: UowService, private cd: ChangeDetectorRef, public session: SessionService) { }

  ngOnInit() {
  }

}
