import { UpdateComponent } from './update/update.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrganeRoutingModule } from './organe-routing.module';
import { OrganeComponent } from './organe.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [OrganeComponent, UpdateComponent],
  imports: [
    CommonModule,
    OrganeRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  entryComponents: [
    UpdateComponent
  ]
})
export class OrganeModule { }
