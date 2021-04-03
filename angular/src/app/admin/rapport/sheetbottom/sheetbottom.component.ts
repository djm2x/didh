import { UowService } from './../../../services/uow.service';
import { Visite, Rapport, Traite } from './../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatBottomSheetRef, MAT_BOTTOM_SHEET_DATA } from '@angular/material/bottom-sheet';

@Component({
  selector: 'app-sheetbottom',
  templateUrl: './sheetbottom.component.html',
  styleUrls: ['./sheetbottom.component.scss']
})
export class SheetbottomComponent implements OnInit {
  o = new Traite();
  rapports: Rapport[] = [];
  constructor(private bottomSheetRef: MatBottomSheetRef<SheetbottomComponent>, @Inject(MAT_BOTTOM_SHEET_DATA) public data: any
    , private uow: UowService, @Inject('BASE_URL') public url: string) { }

  ngOnInit() {
    // // console.log(this.data);
    // this.o = this.data as Rapport;
    // this.pieces = this.o.pieceJointe.split(';');
    // this.pieces.pop();
    // // console.log(this.pieces);

    this.o = this.data as Traite;
    this.rapports = this.o.rapports;
    // this.pieces.pop();
  }

  async openLink(p/*event: MouseEvent*/) {
    // this.bottomSheetRef.dismiss();
    // console.log(p);
    const url = `${this.url}/rapport/${p}`;
    window.open(url);
    // try {
    //   await this.uow.rapports.download(p).toPromise();
    // } catch (e) {
    //   console.warn(e);
    // }

    // event.preventDefault();
  }

}
