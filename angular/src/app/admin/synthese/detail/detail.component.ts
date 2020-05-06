import { Synthese } from './../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { UowService } from 'src/app/services/uow.service';
import { Visite } from 'src/app/Models/models';
@Component({
  selector: 'app-update',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.scss']
})
export class DetailComponent implements OnInit {
  o: Synthese;
  title = '';
  dataSource = [];
  columnDefs = [
    { columnDef: 'codeRecommendation', headName: 'CODE' },
    { columnDef: 'nom', headName: '' },
    { columnDef: 'etat', headName: '' },
    { columnDef: 'mecanisme', headName: '' },
    { columnDef: 'axe', headName: '' },
    { columnDef: 'sousAxe', headName: 'SOUS AXE' },
    { columnDef: 'cycle', headName: '' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName;
    return e;
  });

  displayedColumns = this.columnDefs.map(e => e.columnDef);

  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit() {
    this.o = this.data.model;
    this.dataSource = this.o.syntheseRecommandations.map(e => e.recommendation);
    // this.title = typeof(Synthese).name.toUpperCase;
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
