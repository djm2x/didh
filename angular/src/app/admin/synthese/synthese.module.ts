import { TitleModule } from './../components/title/title.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SyntheseRoutingModule } from './synthese-routing.module';
import { SyntheseComponent } from './synthese.component';
import { UpdateComponent } from './update/update.component';
import { ListComponent } from './list/list.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RecommendationsComponent } from './update/recommendations/recommendations.component';
import { DetailComponent } from './detail/detail.component';
import { FicheSyntheseComponent } from './update/fiche-synthese/fiche-synthese.component';
import { PopupComponent } from './update/fiche-synthese/popup/popup.component';
import { TranslateModule } from '@ngx-translate/core';
import { ManageFilesModule } from 'src/app/manage-files/manage-files.module';


@NgModule({
  declarations: [
    SyntheseComponent,
    UpdateComponent,
    ListComponent,
    RecommendationsComponent,
    DetailComponent,
    FicheSyntheseComponent,
    PopupComponent,
  ],
  imports: [
    CommonModule,
    SyntheseRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TitleModule,
    TranslateModule,
    ManageFilesModule,
  ],
  entryComponents: [
    DetailComponent,
    PopupComponent,
  ]
})
export class SyntheseModule { }
