import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { UowService } from 'src/app/services/uow.service';
import { Visite } from 'src/app/Models/models';
import { Subject } from 'rxjs';
@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {
  myForm: FormGroup;
  o: Visite;
  title = '';

  folderToSaveInServer = 'visite';
  lienUploadTo = new Subject();
  lienUploadFrom = new Subject();
  //
  eventSubmitFromParent = new Subject();

  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, private uow: UowService) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
    this.createForm();

    this.lienUploadFrom.subscribe(r => this.myForm.get('lienUpload').setValue(r));

    setTimeout(() => {
      this.lienUploadTo.next(this.o.lienUpload);
    }, 100);
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      mandat: [this.o.mandat, Validators.required],
      discours: [this.o.discours],
      date: [this.o.date, Validators.required],
      lienRapport: [this.o.lienRapport],
      lienUpload: [this.o.lienUpload],
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: Visite): void {

    this.submit(o);
  }

  submit(o: Visite) {
    o.date = this.uow.valideDate(o.date);

    if (this.o.id === 0) {
      this.uow.visites.post(o).subscribe(async (r: Visite) => {
        this.eventSubmitFromParent.next(true);
        // }
        this.dialogRef.close(true);

      });
    } else {
      this.uow.visites.put(o.id, o).subscribe(async r => {
        this.eventSubmitFromParent.next(true);

        this.dialogRef.close(true);
      });
    }


  }



  resetForm() {
    this.o = new Visite();
    this.createForm();
  }

}
