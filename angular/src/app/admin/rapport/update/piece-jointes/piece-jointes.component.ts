import { DetailRapportComponent } from './detail-rapport/detail-rapport.component';
import { Rapport } from './../../../../Models/models';
import { PopupComponent } from '../popup/popup.component';
import { Component, OnInit, EventEmitter, Input, ViewChild, Inject } from '@angular/core';
import { MatDialog, MatBottomSheet, MatTableDataSource, MatPaginator, MatSort } from '@angular/material';
import { DeleteService } from 'src/app/admin/components/delete/delete.service';
import { UowService } from 'src/app/services/uow.service';
import { Visite } from 'src/app/Models/models';
import { SheetbottomComponent } from 'src/app/admin/components/sheetbottom/sheetbottom.component';
import { CollectionViewer, DataSource } from '@angular/cdk/collections';
import { merge } from 'rxjs';

@Component({
  selector: 'app-piece-jointes',
  templateUrl: './piece-jointes.component.html',
  styleUrls: ['./piece-jointes.component.scss']
})
export class PieceJointesComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;
  columnDefs = [
    { columnDef: 'pieceJointe', headName: 'PIECE' },
    { columnDef: 'titre', headName: 'TITRE' },
    { columnDef: 'dateDernierRapport', headName: 'DATE DERNIER RAPPORT' },
    { columnDef: 'dateObservation', headName: 'DATE OBSERVATION' },
    { columnDef: 'dateProchaineRapport', headName: 'DATE PROCHAINE RAPPORT' },
    { columnDef: 'reference', headName: 'REFERENCE' },
    { columnDef: 'option', headName: 'OPTION' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName;
    return e;
  });
  index = 0;
  displayedColumns = this.columnDefs.map(e => e.columnDef);

  // @Input() listToParent = new EventEmitter();
  // @Input() listFromParent = new EventEmitter();
  // dataSource: Rapport[] = [];
  // dataSource2: Rapport[] = [];
  dataSource = [];
  listRapportToDelete: Rapport[] = [];
  @Input() idTraite;

  constructor(public dialog: MatDialog, private mydialog: DeleteService
    , private uow: UowService, @Inject('BASE_URL') public url: string) { }

  ngOnInit() {
    this.getPage(0, 10, 'id', 'desc', this.idTraite);
    merge(...[this.sort.sortChange, this.paginator.page, this.update]).subscribe(
      r => {
        r === true ? this.paginator.pageIndex = 0 : r = r;
        !this.paginator.pageSize ? this.paginator.pageSize = 10 : r = r;
        const startIndex = this.paginator.pageIndex * this.paginator.pageSize;
        this.isLoadingResults = true;
        this.getPage(
          startIndex,
          this.paginator.pageSize,
          this.sort.active ? this.sort.active : 'id',
          this.sort.direction ? this.sort.direction : 'desc',
          this.idTraite,
        );
      }
    );
  }

  test() {
    console.log()
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idTraite) {
    this.uow.rapports.getAllByTraite(startIndex, pageSize, sortBy, sortDir, idTraite).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }


  openDialog(o: Rapport, text) {
    const dialogRef = this.dialog.open(PopupComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: text }
    });

    return dialogRef.afterClosed();
  }

  openDetailDialog(o: any) {
    const dialogRef = this.dialog.open(DetailRapportComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: 'Rapport' }
    });

    return dialogRef.afterClosed();
  }

  add() {
    const o = new Rapport();
    o.idTraite = this.idTraite;
    this.openDialog(o, 'add').subscribe((result) => {
      if (result) {
        // { model: o, file: this.file, pieceDeleted: this.pieceJointeToDelete[0] }
        this.getPage(0, 10, 'id', 'desc', this.idTraite);
      }
    });
  }

  edit(o: Rapport) {
    this.openDialog(o, 'edit').subscribe((result: any) => {
      if (result) {
        this.getPage(0, 10, 'id', 'desc', this.idTraite);
      }
    });
  }

  async delete(o: Rapport) {
    // const pieces = o.rapports.map(e => e.pieceJointe);
    // pieces.pop();
    this.uow.rapports.delete(o.id).subscribe(rss => {
      this.uow.rapports.deleteFiles([o.pieceJointe], 'rapport').subscribe(rss => {
        this.update.next(true);
      });
    });
  }

  // toParentComponent(datasource, file, rapportToDelete/*, pieceDeleted*/) {
  //   console.log({
  //     datasource, // list rapprot
  //     file, // all files
  //     rapportToDelete, // case edit: if there is something to delete
  //     // pieceDeleted,
  //   })
  //   this.listToParent.next({
  //     datasource, // list rapprot
  //     file, // all files
  //     rapportToDelete, // case edit: if there is something to delete
  //     // pieceDeleted,
  //   });
  // }


  showPieceJoin(o: Rapport) {
    const url = `${this.url}/rapport/${o.pieceJointe}`;
    window.open(url);
  }

}


// export class LessonsDataSource implements DataSource<Rapport> {



//   constructor(private update: EventEmitter<Rapport>) {}

//   connect(collectionViewer: CollectionViewer): Observable<Lesson[]> {
//       return this.update;
//   }

//   disconnect(collectionViewer: CollectionViewer): void {
//       this.lessonsSubject.complete();
//       this.loadingSubject.complete();
//   }

// }
