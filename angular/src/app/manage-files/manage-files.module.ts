import { HttpClientModule } from '@angular/common/http';
import { MatModule } from 'src/app/mat.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UploadComponent } from './upload/upload.component';
import { DownloadSheetComponent } from './download-sheet/download-sheet.component';



@NgModule({
  declarations: [
    UploadComponent,
    DownloadSheetComponent,
  ],
  imports: [
    CommonModule,
    MatModule,
    HttpClientModule,
  ],
  exports: [
    UploadComponent,
    DownloadSheetComponent
  ],
  entryComponents: [
    DownloadSheetComponent
  ]
})
export class ManageFilesModule { }
