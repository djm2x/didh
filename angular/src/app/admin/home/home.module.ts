import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { HomeRoutingModule } from './home-routing.module';
import { PieChartModule } from '../components/pie-chart/pie-chart.module';
import { TitleModule } from '../components/title/title.module';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
  declarations: [
    HomeComponent,
  ],
  imports: [
    TranslateModule,
    CommonModule,
    HomeRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    PieChartModule,
    TitleModule,
  ]
})
export class HomeModule { }
