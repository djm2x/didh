import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RecommendationRoutingModule } from './recommendation-routing.module';
import { RecommendationComponent } from './recommendation.component';
import { UpdateComponent } from './update/update.component';
import { ListComponent } from './list/list.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatModule } from 'src/app/mat.module';
import { OrganismesComponent } from './update/organismes/organismes.component';
import { TitleModule } from '../components/title/title.module';
import { DetailComponent } from './detail/detail.component';
import { ManageFilesModule } from 'src/app/manage-files/manage-files.module';
import { TranslateModule } from '@ngx-translate/core';


@NgModule({
  declarations: [
    RecommendationComponent,
    UpdateComponent,
    ListComponent,
    OrganismesComponent,
    DetailComponent,
  ],
  imports: [
    TranslateModule,
    CommonModule,
    RecommendationRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TitleModule,
    ManageFilesModule,
  ],
  entryComponents: [
    DetailComponent,
  ]
})
export class RecommendationModule { }
