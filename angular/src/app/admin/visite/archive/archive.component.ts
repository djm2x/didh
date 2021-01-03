import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Visite } from 'src/app/Models/models';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {
  o: Visite;
  title = '';
  folder = 'organe';
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
  , @Inject('BASE_URL') public url: string) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
  }

  propertyToList(r) {
    if (r) {
      const l = r.split(';');

      l.pop();

      return l;
    } else {
      return [];
    }
  }

  download(fileName/*event: MouseEvent*/) {
    const url = `${this.url}/${this.folder}/${fileName}`;
    window.open(url);
  }

}
