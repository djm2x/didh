import { Rapport } from './../../../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-rapport-update',
  templateUrl: './detail-rapport.component.html',
  styleUrls: ['./detail-rapport.component.scss']
})
export class DetailRapportComponent implements OnInit {
  dataSource = [];
  columnDefs = [
    { columnDef: 'code', headName: 'CODE' },
    { columnDef: 'detail', headName: 'DETAIL' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName;
    return e;
  });

  displayedColumns = this.columnDefs.map(e => e.columnDef);
  //
  o: Rapport;
  title = '';
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit() {
    this.o = this.data.model;
    this.dataSource = this.o.syntheses;
    this.title = this.data.title;
    console.log(this.o);
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: any): void {
    // o.date = this.valideDate(o.date);
    // this.dialogRef.close({ model: o, file: this.file });
  }



}
