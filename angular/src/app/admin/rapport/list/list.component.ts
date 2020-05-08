import { SessionService } from './../../../shared/session.service';
import { Rapport, Traite } from './../../../Models/models';

import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatBottomSheet } from '@angular/material';
import { merge } from 'rxjs';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { Visite, Recommendation } from 'src/app/Models/models';
import { DeleteService } from '../../components/delete/delete.service';
import { SheetbottomComponent } from '../sheetbottom/sheetbottom.component';
import { ActivatedRoute } from '@angular/router';
import { DetailComponent } from '../detail/detail.component';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { ArchiveComponent } from '../archive/archive.component';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;
  dataSource = [];
  columnDefs = [
    // { columnDef: 'pieceJointe', headName: 'PIECE' },
    { columnDef: 'nom', headName: 'Organes de Traités' },
    { columnDef: 'conventionPiece', headName: 'Rapport national' },
    { columnDef: 'observationPiece', headName: `Observations finales` },
    { columnDef: 'miseOeuvrePiece', headName: 'Rapport de suivi de la mise en œuvre' },
    { columnDef: 'analytiquePiece', headName: 'Rapport analytique' },
    { columnDef: 'option', headName: '...' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });



  // . Convention/Protocole
  // 2. Rapport national
  // 3.Observations finales
  // 4.Rapport de suivi de la mise en œuvre

  displayedColumns = this.columnDefs.map(e => e.columnDef);
  progress = 0;
  message: any;
  formData = new FormData();
  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , private snack: SnackbarService, private bottomSheet: MatBottomSheet, public session: SessionService
    , private route: ActivatedRoute, @Inject('BASE_URL') public url: string) {

      // if (this.session.isPointFocal === false) {
      //   this.columnDefs.push({ columnDef: 'miseOeuvrePiece', headName: 'Rapport de suivi de la mise en œuvre' })
      // }
    }

  ngOnInit() {
    // console.log(this.columnDefs)
    this.getPage(0, 10, 'id', 'desc', this.session.user.idOrganisme);
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
          this.session.user.idOrganisme
        );
      }
    );
    this.route.queryParams.subscribe(params => {
      const id = params['data'];
      if (id) {
        this.uow.rapports.getOne(id).subscribe(r => {
          this.openDialog(r);
        });
      }
    });
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idOrganisme) {
    this.uow.traites.getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }



  openDialog(o: any) {
    const dialogRef = this.dialog.open(DetailComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: 'Rapport' }
    });

    return dialogRef.afterClosed();
  }


  async delete(o: Traite) {
    const r = await this.mydialog.openDialog('rapport').toPromise();
    if (r === 'ok') {
      let list = [];
      o.conventionPiece !== '' ? list.push(...this.uow.decoupe(o.conventionPiece)) : list = list;
      o.miseOeuvrePiece !== '' ? list.push(...this.uow.decoupe(o.miseOeuvrePiece)) : list = list;
      o.observationPiece !== '' ? list.push(...this.uow.decoupe(o.observationPiece)) : list = list;


      this.uow.files.deleteFiles(list, 'traite').subscribe(res => {
        this.uow.traites.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  archive(o: Traite) {
    this.dialog.open(ArchiveComponent, {
      width: '80vw',
      disableClose: true,
      data: { model: o, title: o.nom }
    });
  }

  showPieceJoin2(o: Traite) {
    console.log(o);
    this.bottomSheet.open(SheetbottomComponent, { data: o, });
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'organe'}});
  }

  // activeDownload(o: Traite) {
  //   o.rapports.map(r => {
  //     if (r.pieceJointe !== '') {
  //       return false;
  //     }
  //   });

  //   return true;
  // }
}


