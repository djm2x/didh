import { SituationReserve } from './../../../Models/models';
import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit } from '@angular/core';
import { Subject, merge } from 'rxjs';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { startWith } from 'rxjs/operators';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { SessionService } from 'src/app/shared';

@Component({
  selector: 'app-situation-reserve',
  templateUrl: './situation-reserve.component.html',
  styleUrls: ['./situation-reserve.component.scss']
})
export class SituationReserveComponent implements OnInit {
  o = new SituationReserve();

  folderToSaveInServer = 'situation-reserve';

  propertyUrlTo = new Subject();
  propertyUrlFrom = new Subject();
  //
  eventSubmitFromParent = new Subject();
  //
  update = new Subject();

  constructor(private uow: UowService, private bottomSheet: MatBottomSheet, public session: SessionService) { }

  ngOnInit() {
    merge(...[this.update]).pipe(startWith(null as any)).subscribe(
      r => {
        this.uow.situationReserves.getFirst().subscribe(r => {

          this.o = r;

          setTimeout(() => {
            this.propertyUrlTo.next(this.o.url);
          }, 100);

        });
      }
    );


    this.propertyUrlFrom.subscribe((r: string) => this.o.url = r);

  }

  submit() {
    if (this.o.id === 0) {
      this.uow.situationReserves.post(this.o).subscribe(r => {

        this.eventSubmitFromParent.next(true);
        setTimeout(() => this.update.next(true), 1000);

      });
    } else {

      this.uow.situationReserves.put(this.o.id, this.o).subscribe(r => {

        this.eventSubmitFromParent.next(true);
        setTimeout(() => this.update.next(true), 1000);
      });
    }


  }

  showPieceJoin(fileName = '') {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName: this.o.url, folder: this.folderToSaveInServer}});
  }
}
