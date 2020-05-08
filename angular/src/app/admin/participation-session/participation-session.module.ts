import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ParticipationSessionRoutingModule } from './participation-session-routing.module';
import { ParticipationSessionComponent } from './participation-session.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TitleModule } from '../components/title/title.module';
import { UpdateComponent } from './update/update.component';
import { ManageFilesModule } from 'src/app/manage-files/manage-files.module';


@NgModule({
  declarations: [ParticipationSessionComponent, UpdateComponent],
  imports: [
    CommonModule,
    ParticipationSessionRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TitleModule,
    ManageFilesModule,
  ],
  entryComponents: [
    UpdateComponent,
  ]
})
export class ParticipationSessionModule { }
