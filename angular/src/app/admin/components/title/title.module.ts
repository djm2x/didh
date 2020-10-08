import { MatModule } from './../../../mat.module';
import { TitleComponent } from './title.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IntrosComponent } from './intros/intros.component';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    TitleComponent,
    IntrosComponent,
  ],
  imports: [
    CommonModule,
    MatModule,
    HttpClientModule,
  ],
  exports: [TitleComponent, IntrosComponent]
})
export class TitleModule { }
