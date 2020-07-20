import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AxeRoutingModule } from './axe-routing.module';
import { AxeComponent } from './axe.component';
import { UpdateComponent } from './update/update.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatModule } from 'src/app/mat.module';
import { TranslateModule } from '@ngx-translate/core';


@NgModule({
  declarations: [AxeComponent, UpdateComponent],
  imports: [
    CommonModule,
    AxeRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TranslateModule,
  ],
  entryComponents: [
    UpdateComponent
  ]
})
export class AxeModule { }
