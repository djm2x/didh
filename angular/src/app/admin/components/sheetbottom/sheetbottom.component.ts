import { Component, OnInit, Inject } from '@angular/core';
import { MatBottomSheetRef, MAT_BOTTOM_SHEET_DATA } from '@angular/material';
import { Visite } from 'src/app/Models/models';

@Component({
  selector: 'app-sheetbottom',
  templateUrl: './sheetbottom.component.html',
  styleUrls: ['./sheetbottom.component.scss']
})
export class SheetbottomComponent implements OnInit {
  o = new Visite();
  constructor(private bottomSheetRef: MatBottomSheetRef<SheetbottomComponent>, @Inject(MAT_BOTTOM_SHEET_DATA) public data: any) {}

  ngOnInit() {
    console.log(this.data);
    this.o = this.data;
  }

  openLink(event: MouseEvent): void {
    this.bottomSheetRef.dismiss();
    event.preventDefault();
  }

}
