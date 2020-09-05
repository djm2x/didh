import { TitleModule } from './../components/title/title.module';
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
import { DiagrammeComponent } from './diagramme/diagramme.component';
import { PieChartModule } from '../components/pie-chart/pie-chart.module';
import { TranslateModule } from '@ngx-translate/core';
import { ListComponent } from './recommandation/list.component';

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
    DiagrammeComponent,
    ListComponent,
  ],
  imports: [
    CommonModule,
    StateRoutingModule,
    HttpClientModule,
    MatModule,
    ChartsModule,
    FormsModule,
    ReactiveFormsModule,
    PieChartModule,
    TitleModule,
    TranslateModule,
  ]
})
export class StateModule { }
