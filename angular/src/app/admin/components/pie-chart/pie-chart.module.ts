import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatModule } from 'src/app/mat.module';
import { ChartsModule } from 'ng2-charts';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PieChartComponent } from './pie-chart.component';
import { StatePieComponent } from './state/state.component';
import { DoughnutComponent } from './doughnut/doughnut.component';
import { BarComponent } from './bar/bar.component';
import { ProgressBarComponent } from './progress-bar/progress-bar.component';



@NgModule({
  declarations: [PieChartComponent, StatePieComponent, DoughnutComponent, BarComponent, ProgressBarComponent],
  imports: [
    CommonModule,
    MatModule,
    ChartsModule,
    // FormsModule,
    // ReactiveFormsModule,
  ],
  exports: [
    PieChartComponent,
    StatePieComponent,
    DoughnutComponent,
    BarComponent,
    ProgressBarComponent,
  ]
})
export class PieChartModule { }
