import { LoaderModule } from './loader/loader.module';
import { MatModule } from './mat.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Injector } from '@angular/core';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppComponent } from './app.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { InjectService } from './inject.service';
import { AppRoutingModule } from './app-routing.module';
import { MessageComponent } from './shared/snakebar.service';
import { LoaderInterceptor } from './loader/loader-interceptor';
import { DeleteComponent } from './admin/components/delete/delete.component';
import { SheetbottomComponent } from './admin/components/sheetbottom/sheetbottom.component';
import { MatToolbarModule, MatProgressSpinnerModule, MatDividerModule, MatButtonModule, MatSnackBarModule, MatDialogModule, MatListModule } from '@angular/material';

@NgModule({
  declarations: [
    AppComponent,
    MessageComponent,
    DeleteComponent,
    SheetbottomComponent,
  ],
  entryComponents: [
    DeleteComponent,
    SheetbottomComponent,
  ],
  imports: [
    ReactiveFormsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    // MatModule,
    MatToolbarModule,
    MatProgressSpinnerModule,
    MatDividerModule,
    MatButtonModule,
    MatSnackBarModule,
    MatListModule,
    MatDialogModule,
    FormsModule,
    BrowserAnimationsModule,
    LoaderModule,
    // MatSnackBarModule,
    // MatProgressSpinnerModule,
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: LoaderInterceptor,
      multi: true
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor(private injector: Injector) {    // Create global Service Injector.
    InjectService.injector = this.injector;
  }
}
