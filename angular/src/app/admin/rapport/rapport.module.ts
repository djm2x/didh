import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RapportRoutingModule } from './rapport-routing.module';
import { RapportComponent } from './rapport.component';
import { UpdateComponent } from './update/update.component';
import { ListComponent } from './list/list.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TitleModule } from '../components/title/title.module';
import { SheetbottomComponent } from './sheetbottom/sheetbottom.component';
import { DetailComponent } from './detail/detail.component';
import { PieceJointesComponent } from './update/piece-jointes/piece-jointes.component';
import { SyntheseComponent } from './update/popup/synthese/synthese.component';
import { PopupComponent } from './update/popup/popup.component';
import { DetailRapportComponent } from './update/piece-jointes/detail-rapport/detail-rapport.component';
import { ManageFilesModule } from 'src/app/manage-files/manage-files.module';
import { SituationReserveComponent } from './situation-reserve/situation-reserve.component';
import { ArchiveComponent } from './archive/archive.component';
import { PieChartModule } from '../components/pie-chart/pie-chart.module';
import { TranslateModule } from '@ngx-translate/core';
import { ModalComponent } from './modal/modal.component';
import { CountModule } from '../components/count/count.module';

@NgModule({
  declarations: [
    RapportComponent,
    UpdateComponent,
    ListComponent,
    SheetbottomComponent,
    DetailComponent,
    PieceJointesComponent,
    PopupComponent,
    SyntheseComponent,
    DetailRapportComponent,
    SituationReserveComponent,
    ArchiveComponent,
    ModalComponent,
  ],
  imports: [
    CommonModule,
    RapportRoutingModule,
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
  entryComponents: [
    SheetbottomComponent,
    DetailComponent,
    PopupComponent,
    DetailRapportComponent,
    ArchiveComponent,
    ModalComponent
  ]
})
export class RapportModule { }
