import { Visite } from './../../../Models/models';
import { UowService } from './../../../services/uow.service';
import { Component, Output, EventEmitter, ViewChild, Renderer2, AfterViewInit, OnInit, ChangeDetectionStrategy, Input } from '@angular/core';
import { Moment } from 'moment';
import * as moment from 'moment';
import { MatCalendar, MatCalendarCellCssClasses, MatBottomSheet } from '@angular/material';
import { SheetbottomComponent } from '../../components/sheetbottom/sheetbottom.component';

@Component({
  selector: 'app-calendar',
  templateUrl: './calendar.component.html',
  styleUrls: ['./calendar.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class CalendarComponent implements OnInit, AfterViewInit {
  showComponent = true;
  @ViewChild('calendar', { static: true }) calendar: MatCalendar<Moment>;
  @Output() dateSelected = new EventEmitter<Moment>();
  @Output() selectedDate = moment();
  @Input() testAction = new EventEmitter();

  listDate: Date[] = [];
  listVisite: Visite[] = [];
  monthToChecke = new Date().getMonth() + 1;
  yearToChecke = new Date().getFullYear();

  constructor(private renderer: Renderer2, private uow: UowService
    , private bottomSheet: MatBottomSheet) { }

  ngOnInit(): void {
    this.uow.visites.getDate(this.monthToChecke, this.yearToChecke).subscribe((r: Visite[]) => {
      this.listVisite = r;
      this.listDate = r.map(e => new Date(e.date));
      this.showComponent = true;
      // this.calendar.dateClass = this.dateClass();
    });
    this.calendar.dateClass = this.dateClass();
    // this.calendar.stateChanges.subscribe(r => {
    //   // console.log(r);
    // })

    console.log('recalle');
  }

  ngAfterViewInit() {
    const buttons = document.querySelectorAll('.mat-calendar-previous-button, .mat-calendar-next-button');
    console.log(buttons)
    if (buttons) {
      Array.from(buttons).forEach(button => {
        this.renderer.listen(button, 'click', (e) => {

          this.testAction.next(true);
        //   this.uow.visites.getDate(this.monthToChecke + 1, this.yearToChecke).subscribe((r: Visite[]) => {
        //     this.listVisite = r;
        //     this.listDate = r.map(e => new Date(e.date));
        //     this.showComponent = true;
        //     this.calendar.dateClass = this.dateClass();
        //   });
        //   // console.log(e);

        //   setTimeout(() => {
        //     console.log('done')
        //     // this.calendar.dateClass = this.dateClass();
        //   }
        //   , 3000);
        //   e = e || window.event;
        //   e = e.target || e.srcElement;
        //   if (e.nodeName === 'BUTTON') {
        //     console.log(e.getAttribute('aria-label'));
        //   }
        });
      });
    }
  }

  monthSelected(date: Moment) {
    // call server
    console.log('month changed');
    console.log(date);
    console.log(this.selectedDate);
    // this.dateChanged();
  }

  dateChanged() {
    // open the sheetbotom
    this.listVisite.forEach(v => {
      if (new Date(v.date).toDateString() === this.selectedDate.toDate().toDateString()) {
        this.bottomSheet.open(SheetbottomComponent, { data: v, });
      }
    });
    // this.calendar.activeDate = this.selectedDate;
    // this.dateSelected.emit(this.selectedDate);
    // prevent call server if is it the same month
    const monthSelected = this.selectedDate.toDate().getMonth() + 1;
    const year = this.selectedDate.toDate().getFullYear();
    if (this.monthToChecke === monthSelected && this.yearToChecke === year) {
      return;
    }

    this.monthToChecke = monthSelected;
    this.yearToChecke = year;
    //
    console.log(monthSelected, year);
    this.showComponent = false;
    this.uow.visites.getDate(monthSelected, year).subscribe((r: Visite[]) => {
      this.listVisite = r;
      this.listDate = r.map(e => new Date(e.date));
      this.showComponent = true;
    });

  }

  prevDay() {
    const prevMoment = moment(this.selectedDate).add(-1, 'days');
    this.selectedDate = prevMoment;
    this.dateChanged();
  }

  today() {
    this.selectedDate = moment();
    this.dateChanged();
  }

  nextDay() {
    // call server
    const nextMoment = moment(this.selectedDate).add(1, 'days');
    this.selectedDate = nextMoment;
    this.dateChanged();
  }

  dateClass() {
    // const l = ((await this.uow.visites.getDate(11, 2019).toPromise()) as Date[]).map(e => new Date(e));
    // this.uow.visites.getDate(11, 2019).subscribe((dates: Date[]) => {
    //   this.listDate = dates.map(e => new Date(e));
    // });


    return (date: Moment): MatCalendarCellCssClasses => {
      let classCss = '';
      this.listDate.forEach(d => {
        console.log('>>>>>>>>>>>>>>>>>>')
        if (date.toDate().getDate() === d.getDate()) {
          console.log(date.toDate().getDate(), d.getDate());
          classCss = 'special-date';
          return;
        }
      });

      return classCss;
    };
  }

  dateClass2 = (date: Moment) => {
    let classCss = '';
    this.listDate.forEach(d => {
      if (date.toDate().getDate() === d.getDate()) {
        classCss = 'special-date';
        return;
      }
    });

    return classCss;
  }
}
