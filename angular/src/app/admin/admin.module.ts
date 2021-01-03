import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminComponent } from './admin.component';

import { MatModule } from '../mat.module';
import { TranslateModule } from '@ngx-translate/core';



import { MyTranslateService } from '../my.translate.service';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { MatSnackBarModule } from '@angular/material/snack-bar';

@NgModule({
  declarations: [
    AdminComponent,
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    TranslateModule,
    // HttpClientModule,
    MatModule,
    // FormsModule,
    // ReactiveFormsModule,
    MatSnackBarModule,
    MatProgressSpinnerModule,
  ],
  providers: [
    { provide: MAT_DATE_LOCALE, useValue: 'fr' },
    // {
    //   provide: MAT_DIALOG_DEFAULT_OPTIONS,
    //   useValue: { hasBackdrop: true, direction: mytranslate.langSync === 'fr' ? 'ltr' : 'rtl', height: '500px' }
    // }
    // {provide: DateAdapter, useClass: MomentDateAdapter, deps: [MAT_DATE_LOCALE]},
    // {provide: MAT_DATE_FORMATS, useValue: MAT_MOMENT_DATE_FORMATS},
  ]
})
export class AdminModule {
  constructor(public mytranslate: MyTranslateService) {}
}
