import { TitleModule } from './../components/title/title.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PermissionRoutingModule } from './permission-routing.module';
import { PermissionComponent } from './permission.component';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [PermissionComponent],
  imports: [
    CommonModule,
    PermissionRoutingModule,
    HttpClientModule,
    MatModule,
    FormsModule,
    ReactiveFormsModule,
    TitleModule,
  ]
})
export class PermissionModule { }
