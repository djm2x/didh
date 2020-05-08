import { SessionService } from './../../shared/session.service';
import {  Examen } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatBottomSheet } from '@angular/material';
import { merge } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { HttpEventType } from '@angular/common/http';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { ActivatedRoute } from '@angular/router';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { ArchiveComponent } from './archive/archive.component';

@Component({
  selector: 'app-examen',
  templateUrl: './examen.component.html',
  styleUrls: ['./examen.component.scss']
})
export class ExamenComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;

  dataSource = [];
  columnDefs = [
    { columnDef: 'libelle', headName: '' },
    { columnDef: 'rapportNational', headName: 'Rapport national' },
    { columnDef: 'compilationHCDH', headName: 'Compilation HCDH' },
    { columnDef: 'observationFinale', headName: 'Observations finales' },
    { columnDef: 'rapportMiParcours', headName: 'Rapport mi-parcours' },
    { columnDef: 'option', headName: 'OPTION' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });

  displayedColumns = this.columnDefs.map(e => e.columnDef);
  progress = 0;
  message: any;
  formData = new FormData();
  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , private snack: SnackbarService, @Inject('BASE_URL') public url: string
    , private route: ActivatedRoute, public session: SessionService, private bottomSheet: MatBottomSheet) { }

  ngOnInit() {
    setTimeout(() => this.getPage(0, 10, 'id', 'desc'), 300)
      ;
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
        );
      }
    );
  }

  getPage(startIndex, pageSize, sortBy, sortDir) {
    this.uow.examens.getList(startIndex, pageSize, sortBy, sortDir).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }

  openDialog(o: Examen, text) {
    const dialogRef = this.dialog.open(UpdateComponent, {
      width: '80vw',
      disableClose: true,
      data: { model: o, title: text }
    });

    return dialogRef.afterClosed();
  }

  add() {
    this.openDialog(new Examen(), 'Ajouter Examen').subscribe(result => {
      if (result) {
        this.update.next(false);
      }
    });
  }

  edit(o: Examen) {
    this.openDialog(o, 'Modifier Examen').subscribe((result: any) => {
      if (result) {
        this.update.next(false);
      }
    });
  }

  archive(o: Examen) {
    this.dialog.open(ArchiveComponent, {
      width: '80vw',
      disableClose: true,
      data: { model: o, title: o.libelle }
    });
  }

  async delete(o: Examen) {
    const r = await this.mydialog.openDialog('Examen').toPromise();
    if (r === 'ok') {
      // console.log(o);
      let list = [];

      o.rapportNational !== '' ? list.push(...this.uow.decoupe(o.rapportNational)) : list = list;
      o.compilationHCDH !== '' ? list.push(...this.uow.decoupe(o.compilationHCDH)) : list = list;
      o.observationFinale !== '' ? list.push(...this.uow.decoupe(o.observationFinale)) : list = list;
      o.rapportMiParcours !== '' ? list.push(...this.uow.decoupe(o.rapportMiParcours)) : list = list;

      this.uow.files.deleteFiles(list, 'examen').subscribe(res => {
        this.uow.examens.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'examen'}});
  }

}

