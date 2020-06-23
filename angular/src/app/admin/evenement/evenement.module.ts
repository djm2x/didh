import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EvenementRoutingModule } from './evenement-routing.module';
import { EvenementComponent } from './evenement.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UpdateComponent } from './update/update.component';
import { ManageFilesModule } from 'src/app/manage-files/manage-files.module';
import { TitleModule } from '../components/title/title.module';
import { DetailComponent } from './detail/detail.component';

@NgModule({
  declarations: [EvenementComponent, UpdateComponent, DetailComponent],
  imports: [
    CommonModule,
    EvenementRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TitleModule,
    ManageFilesModule,
  ],
  entryComponents: [
    UpdateComponent,
    DetailComponent,
  ]
})
export class EvenementModule { }
