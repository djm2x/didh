import { Synthese, FicheSynthese } from './../../../../Models/models';
import { Component, OnInit, EventEmitter, Input, ViewChild, Inject } from '@angular/core';
import { MatDialog, MatPaginator, MatSort } from '@angular/material';
import { DeleteService } from 'src/app/admin/components/delete/delete.service';
import { UowService } from 'src/app/services/uow.service';
import { merge } from 'rxjs';
import { PopupComponent } from './popup/popup.component';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-fiche-synthese',
  templateUrl: './fiche-synthese.component.html',
  styleUrls: ['./fiche-synthese.component.scss']
})
export class FicheSyntheseComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;
  columnDefs = [
    { columnDef: 'pieceJointe', headName: '' },
    { columnDef: 'organisme', headName: '' },
    { columnDef: 'synthese', headName: '' },
    { columnDef: 'option', headName: 'OPTION' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName;
    return e;
  });
  index = 0;
  displayedColumns = this.columnDefs.map(e => e.columnDef);

  @Input() synthese = new Synthese();
  dataSource = [];

  constructor(public dialog: MatDialog, private mydialog: DeleteService
    , private uow: UowService, @Inject('BASE_URL') public url: string, public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.getPage(0, 10, 'id', 'desc', this.synthese.id);
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
          this.synthese.id,
        );
      }
    );
  }

  test() {
    console.log()
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idSynthese) {
    this.uow.ficheSyntheses.getAll(startIndex, pageSize, sortBy, sortDir, idSynthese).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }


  openDialog(o: FicheSynthese, text = '') {
    const dialogRef = this.dialog.open(PopupComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: text },
      direction: this.mytranslate.langSync === 'fr' ? 'ltr' : 'rtl'
    });

    return dialogRef.afterClosed();
  }

  // openDetailDialog(o: any) {
  //   const dialogRef = this.dialog.open(DetailRapportComponent, {
  //     width: '7100px',
  //     disableClose: true,
  //     data: { model: o, title: 'Rapport' }
  //   });

  //   return dialogRef.afterClosed();
  // }

  add() {
    const o = new FicheSynthese();
    o.idSynthese = this.synthese.id;
    this.openDialog(o, 'add').subscribe((result) => {
      if (result) {
        // { model: o, file: this.file, pieceDeleted: this.pieceJointeToDelete[0] }
        this.getPage(0, 10, 'id', 'desc', this.synthese.id);
      }
    });
  }

  edit(o: FicheSynthese) {
    this.openDialog(o, 'edit').subscribe((result: any) => {
      if (result) {
        this.getPage(0, 10, 'id', 'desc', this.synthese.id);
      }
    });
  }

  async delete(o: FicheSynthese) {
    // const pieces = o.rapports.map(e => e.pieceJointe);
    // pieces.pop();
    this.uow.ficheSyntheses.delete(o.id).subscribe(rss => {
      this.uow.files.deleteFiles([o.ficheUrl], 'FicheSynthese').subscribe(rss => {
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


  showPieceJoin(o: FicheSynthese) {
    const url = `${this.url}/FicheSynthese/${o.ficheUrl}`;
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

