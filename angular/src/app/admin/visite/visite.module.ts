import { TitleModule } from './../components/title/title.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { VisiteRoutingModule } from './visite-routing.module';
import { VisiteComponent } from './visite.component';
import { UpdateComponent } from './update/update.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MAT_DATE_LOCALE, DateAdapter, MAT_DATE_FORMATS } from '@angular/material';
import {MAT_MOMENT_DATE_FORMATS, MomentDateAdapter} from '@angular/material-moment-adapter';
import { MatModule } from 'src/app/mat.module';
import { DetailComponent } from './detail/detail.component';
import { ArchiveComponent } from './archive/archive.component';
import { ManageFilesModule } from 'src/app/manage-files/manage-files.module';
import { PieChartModule } from '../components/pie-chart/pie-chart.module';
import { TranslateModule } from '@ngx-translate/core';
import { ModalComponent } from './modal/modal.component';
import { CountModule } from '../components/count/count.module';

@NgModule({
  declarations: [
    VisiteComponent,
    UpdateComponent,
    DetailComponent,
    ArchiveComponent,
    ModalComponent,
  ],
  imports: [
    CommonModule,
    VisiteRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TitleModule,
    ManageFilesModule,
    PieChartModule,
    TranslateModule,
    CountModule,
  ],
  providers: [
    {provide: MAT_DATE_LOCALE, useValue: 'fr'},
  ],
  entryComponents: [
    UpdateComponent,
    DetailComponent,
    ArchiveComponent,
    ModalComponent
  ]
})
export class VisiteModule { }
