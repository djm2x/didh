import { SessionService } from './../../shared/session.service';
import { ParticipationSession } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatBottomSheet } from '@angular/material';
import { merge } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { ActivatedRoute } from '@angular/router';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { startWith } from 'rxjs/operators';
import { FormControl } from '@angular/forms';
import { MyTranslateService } from 'src/app/my.translate.service';


@Component({
  selector: 'app-participation-session',
  templateUrl: './participation-session.component.html',
  styleUrls: ['./participation-session.component.scss']
})
export class ParticipationSessionComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;

  dataSource = [];
  columnDefs = [
    { columnDef: 'session', headName: 'session' },
    { columnDef: 'annee', headName: 'Année' },
    { columnDef: 'discours', headName: 'Discours de Mr le Ministre' },
    { columnDef: 'documents', headName: 'Documents de session' },
    { columnDef: 'option', headName: 'OPTION' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });

  displayedColumns = this.columnDefs.map(e => e.columnDef);
  progress = 0;
  message: any;
  formData = new FormData();
  panelOpenState = false;
  sessionF = new FormControl('');
  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , @Inject('BASE_URL') public url: string, public mytranslate: MyTranslateService
    , public session: SessionService, private bottomSheet: MatBottomSheet) { }

  ngOnInit() {
    // setTimeout(() => this.getPage(0, 10, 'id', 'desc'), 300)
    //   ;
    merge(...[this.sort.sortChange, this.paginator.page, this.update]).pipe(startWith(null as any)).subscribe(
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
          this.sessionF.value === '' ? '*' : this.sessionF.value,
        );
      }
    );
  }

  search() {
    this.update.next(true);
  }

  reset() {
    this.sessionF.setValue('');
    this.update.next(true);
  }

  getPage(startIndex, pageSize, sortBy, sortDir, session) {
    this.uow.participations.getAll(startIndex, pageSize, sortBy, sortDir, session).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }

  openDialog(o: ParticipationSession, text) {
    const dialogRef = this.dialog.open(UpdateComponent, {
      width: '80vw',
      disableClose: true,
      data: { model: o, title: text },
      direction: this.mytranslate.langSync === 'fr' ? 'ltr' : 'rtl',
    });

    return dialogRef.afterClosed();
  }

  add() {
    this.openDialog(new ParticipationSession(), this.mytranslate.get('admin.session.list.Ajouter_ParticipationSession')).subscribe(result => {
      if (result) {
        this.update.next(false);
      }
    });
  }

  edit(o: ParticipationSession) {
    this.openDialog(o, this.mytranslate.get('admin.session.list.Modifier_Participation_Session')).subscribe((result: any) => {
      if (result) {
        this.update.next(false);
      }
    });
  }


  async delete(o: ParticipationSession) {
    const r = await this.mydialog.openDialog(this.mytranslate.get('admin.session.list.Participation_Session')).toPromise();
    if (r === 'ok') {
      // console.log(o);
      let list = [];
      o.discours !== '' ? list.push(...this.uow.decoupe(o.discours)) : list = list;
      o.documents !== '' ? list.push(...this.uow.decoupe(o.documents)) : list = list;
      // cons
      this.uow.files.deleteFiles(list, 'participation').subscribe(res => {
        this.uow.participations.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/participation/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: { fileName, folder: 'participation' } });
  }

}

