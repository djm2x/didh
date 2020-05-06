import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { HomeRoutingModule } from './home-routing.module';
import { NotificationComponent } from './notification/notification.component';
import { CalendarComponent } from './calendar/calendar.component';
import { BarOneComponent } from './bar-one/bar-one.component';
import { BarTwoComponent } from './bar-two/bar-two.component';
import { ChartsModule } from 'ng2-charts';
import { BarConventionComponent } from './bar-convention/bar-convention.component';
import { BarMecanismeComponent } from './bar-mecanisme/bar-mecanisme.component';

@NgModule({
  declarations: [HomeComponent, NotificationComponent, CalendarComponent, BarOneComponent, BarTwoComponent, BarConventionComponent, BarMecanismeComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    HttpClientModule,
    MatModule,
    ChartsModule,
    FormsModule,
    ReactiveFormsModule,
  ]
})
export class HomeModule { }
