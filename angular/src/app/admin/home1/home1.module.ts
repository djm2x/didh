import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Home1Component } from './home1.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { Home1RoutingModule } from './home1-routing.module';
import { PieChartModule } from '../components/pie-chart/pie-chart.module';
import { TitleModule } from '../components/title/title.module';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
  declarations: [
    Home1Component,
  ],
  imports: [
    TranslateModule,
    CommonModule,
    Home1RoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    PieChartModule,
    TitleModule,
  ]
})
export class Home1Module { }
