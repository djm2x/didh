import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ExamenRoutingModule } from './examen-routing.module';
import { ExamenComponent } from './examen.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TitleModule } from '../components/title/title.module';
import { UpdateComponent } from './update/update.component';
import { ManageFilesModule } from 'src/app/manage-files/manage-files.module';
import { ArchiveComponent } from './archive/archive.component';
import { PieChartModule } from '../components/pie-chart/pie-chart.module';


@NgModule({
  declarations: [ExamenComponent, UpdateComponent, ArchiveComponent],
  imports: [
    CommonModule,
    ExamenRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TitleModule,
    ManageFilesModule,
    PieChartModule,
  ],
  entryComponents: [
    UpdateComponent,
    ArchiveComponent,
  ]
})
export class ExamenModule { }
