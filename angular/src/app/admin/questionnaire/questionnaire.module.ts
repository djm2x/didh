import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { QuestionnaireRoutingModule } from './questionnaire-routing.module';
import { QuestionnaireComponent } from './questionnaire.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TitleModule } from '../components/title/title.module';
import { UpdateComponent } from './update/update.component';
import { ManageFilesModule } from 'src/app/manage-files/manage-files.module';
import { TranslateModule } from '@ngx-translate/core';


@NgModule({
  declarations: [QuestionnaireComponent, UpdateComponent],
  imports: [
    CommonModule,
    QuestionnaireRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TitleModule,
    ManageFilesModule,
    TranslateModule,
  ],
  entryComponents: [
    UpdateComponent,
  ]
})
export class QuestionnaireModule { }
