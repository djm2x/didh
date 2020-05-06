import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { UowService } from 'src/app/services/uow.service';
import { Visite } from 'src/app/Models/models';
@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {
  myForm: FormGroup;
  o: Visite;
  title = '';
  // formData = new FormData();
  file: File;
  // progress: number;
  // message: any;
  filename = '';
  iconFile = '';
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, private uow: UowService) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
    this.filename = this.o.lienUpload === '' ? this.filename : this.o.lienUpload;
    this.createForm();
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: Visite): void {
    o.date = this.valideDate(o.date);
    this.dialogRef.close({ model: o, file: this.file });
  }

  valideDate(date: Date): Date {
    date = new Date(date);

    const hoursDiff = date.getHours() - date.getTimezoneOffset() / 60;
    const minutesDiff = (date.getHours() - date.getTimezoneOffset()) % 60;
    date.setHours(hoursDiff);
    date.setMinutes(minutesDiff);

    return date;
  }

  openInput(o/*: HTMLInputElement*/) {
    o.click();
  }

  upload(files: FileList) {
    if (files.length === 0) {
      return;
    }

    this.file = files[0];
    this.filename = this.file.name;

    this.myForm.get('lienUpload').setValue(this.filename);


    const i = this.filename.lastIndexOf('.');
    const s = this.filename.substring(i + 1);
    // console.log(s);
    s === 'pdf' ? this.iconFile = '-' : this.iconFile = '-';

  }

  remove() {
    this.file = null;
    this.filename = '';
    this.myForm.get('lienUpload').setValue('');
    this.iconFile = '';
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      // objet: [this.o.objet, Validators.required],
      mandat: [this.o.mandat, Validators.required],
      date: [this.o.date, Validators.required],
      lienRapport: [this.o.lienRapport],
      lienUpload: [this.o.lienUpload],
    });
  }

  resetForm() {
    this.o = new Visite();
    this.createForm();
  }

  setIcon(filaName) {
    const i = filaName.lastIndexOf('.');
    const s = filaName.substring(i + 1);
    // console.log(s);
    return (s === 'pdf' || s === 'pdf;') ? 'assets/svg/pdf.svg' : 'assets/svg/word.svg';
  }

}
