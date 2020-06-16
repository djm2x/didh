import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StateComponent } from './state.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { StateRoutingModule } from './state-routing.module';
import { NotificationComponent } from './notification/notification.component';
import { CalendarComponent } from './calendar/calendar.component';
import { BarOneComponent } from './bar-one/bar-one.component';
import { BarTwoComponent } from './bar-two/bar-two.component';
import { ChartsModule } from 'ng2-charts';
import { BarConventionComponent } from './bar-convention/bar-convention.component';
import { BarMecanismeComponent } from './bar-mecanisme/bar-mecanisme.component';
import { ThreeComponent } from './three/three.component';

@NgModule({
  declarations: [
    StateComponent,
    NotificationComponent,
    CalendarComponent,
    BarOneComponent,
    BarTwoComponent,
    BarConventionComponent,
    BarMecanismeComponent,
    ThreeComponent,
  ],
  imports: [
    CommonModule,
    StateRoutingModule,
    HttpClientModule,
    MatModule,
    ChartsModule,
    FormsModule,
    ReactiveFormsModule,
  ]
})
export class StateModule { }
