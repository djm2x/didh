import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { Examen } from 'src/app/Models/models';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {
  o: Examen;
  title = '';
  folder = 'examen';
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
  , @Inject('BASE_URL') public url: string) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
  }

  propertyToList(r) {
    const l = r.split(';');

    l.pop();

    return l;
  }

  download(fileName/*event: MouseEvent*/) {
    const url = `${this.url}/${this.folder}/${fileName}`;
    window.open(url);
  }

}
