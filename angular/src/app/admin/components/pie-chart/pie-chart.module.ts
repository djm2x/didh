import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatModule } from 'src/app/mat.module';
import { ChartsModule } from 'ng2-charts';
import { PieChartComponent } from './pie-chart.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [PieChartComponent],
  imports: [
    CommonModule,
    MatModule,
    ChartsModule,
    // FormsModule,
    // ReactiveFormsModule,
  ],
  exports: [
    PieChartComponent
  ]
})
export class PieChartModule { }
