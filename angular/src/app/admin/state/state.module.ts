import { TitleModule } from './../components/title/title.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StateComponent } from './state.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { StateRoutingModule } from './state-routing.module';
import { ChartsModule } from 'ng2-charts';
import { DiagrammeComponent } from './diagramme/diagramme.component';
import { PieChartModule } from '../components/pie-chart/pie-chart.module';
import { TranslateModule } from '@ngx-translate/core';
import { ListComponent } from './recommandation/list.component';

@NgModule({
  declarations: [
    StateComponent,
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
