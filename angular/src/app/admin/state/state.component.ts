import { SessionService } from 'src/app/shared';
import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit, ViewChild, EventEmitter, ChangeDetectorRef } from '@angular/core';
import { Moment } from 'moment';
import { CalendarComponent } from './calendar/calendar.component';

@Component({
  selector: 'app-state',
  templateUrl: './state.component.html',
  styleUrls: ['./state.component.scss']
})
export class StateComponent implements OnInit {
  @ViewChild('myCalendar', { static: true })
  myCalendar: CalendarComponent;
  //
  // users = this.uow.users.count();
  // visites = this.uow.visites.count();
  rapports = this.session.isPointFocal ?
    this.uow.traites.getCount(this.session.user.idOrganisme) : this.uow.traites.count();
  recommendations = this.session.isPointFocal ?
    this.uow.recommendations.getCount(this.session.user.idOrganisme) : this.uow.recommendations.count();
  //
  displayedColumns: string[] = ['item', 'cost'];
  transactions = [
    { item: 'Beach ball', cost: 4 },
    { item: 'Towel', cost: 5 },
    { item: 'Frisbee', cost: 2 },
    { item: 'Sunscreen', cost: 4 },
    { item: 'Cooler', cost: 25 },
    { item: 'Swim suit', cost: 15 },
  ];

  reactionTest = new EventEmitter();

  /** Gets the total cost of all transactions. */
  // getTotalCost() {
  //   return this.transactions.map(t => t.cost).reduce((acc, value) => acc + value, 0);
  // }
  constructor(private uow: UowService, private cd: ChangeDetectorRef, public session: SessionService) { }

  ngOnInit() {
    // this.uow.users.count().subscribe(r => {
    //   console.log(r);
    // });
    this.reactionTest.subscribe(r => {
      // TRY THIS
      this.cd.detectChanges();
      // OR THIS
      // this.cd.markForCheck();
      console.log('reger that');
    });
  }

  dateSelected(value: Moment) {
    console.log(value);
  }

}
