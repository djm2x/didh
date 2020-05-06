import { MatModule } from './../../mat.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PaysRoutingModule } from './pays-routing.module';
import { PaysComponent } from './pays.component';
import { UpdateComponent } from './update/update.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [PaysComponent, UpdateComponent],
  imports: [
    CommonModule,
    PaysRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  entryComponents: [
    UpdateComponent
  ]
})
export class PaysModule { }
