import { Visite } from './../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-update',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.scss']
})
export class DetailComponent implements OnInit {
  o: Visite;
  title = '';
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
    // console.log(this.o);
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: any): void {
    // o.date = this.valideDate(o.date);
    // this.dialogRef.close({ model: o, file: this.file });
  }



}
