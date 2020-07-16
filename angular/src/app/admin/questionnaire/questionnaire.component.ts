import { SessionService } from './../../shared/session.service';
import {  Questionnaire } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatBottomSheet } from '@angular/material';
import { merge } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { ActivatedRoute } from '@angular/router';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { HttpClient } from '@angular/common/http';
import { FormControl } from '@angular/forms';
import { startWith } from 'rxjs/operators';


@Component({
  selector: 'app-questionnaire',
  templateUrl: './questionnaire.component.html',
  styleUrls: ['./questionnaire.component.scss']
})
export class QuestionnaireComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;
  panelOpenState = true;
  themes: { name: string, sousThemes: string[] }[] = [];
  sousThemes = [];

  theme = new FormControl('');
  sousTheme = new FormControl('');

  dataSource = [];
  columnDefs = [
    { columnDef: 'annee', headName: 'année' },
    { columnDef: 'theme', headName: 'Theme' },
    { columnDef: 'sousTheme', headName: 'Sous theme' },
    { columnDef: 'pieceJointe', headName: 'Documents' },
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
    , private http: HttpClient, @Inject('BASE_URL') public url: string
    , private route: ActivatedRoute, public session: SessionService, private bottomSheet: MatBottomSheet) { }

  async ngOnInit() {
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
          this.theme.value !== '' ? this.theme.value : '*',
          this.sousTheme.value !== '' ? this.sousTheme.value : '*',
        );
      }
    );

    this.themes = await this.http.get<any[]>('assets/json/themes.json').toPromise();
  }

  getPage(startIndex, pageSize, sortBy, sortDir, theme, sousTheme) {
    this.uow.questionnaires.getAll(startIndex, pageSize, sortBy, sortDir, theme, sousTheme).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }

  openDialog(o: Questionnaire, text) {
    const dialogRef = this.dialog.open(UpdateComponent, {
      width: '80vw',
      disableClose: true,
      data: { model: o, title: text },
    });

    return dialogRef.afterClosed();
  }

  selectChange(name: string) {
    this.sousThemes = this.themes.find(e => e.name.includes(name)).sousThemes;
  }

  add() {
    this.openDialog(new Questionnaire(), 'Ajouter Questionnaire').subscribe(result => {
      if (result) {
        this.update.next(false);
      }
    });
  }

  edit(o: Questionnaire) {
    this.openDialog(o, 'Modifier Questionnaire').subscribe((result: any) => {
      if (result) {
        this.update.next(false);
      }
    });
  }

  search() {
    this.update.next(true);
  }

  reset() {
    this.theme.setValue('');
    this.sousTheme.setValue('');
    this.update.next(true);
  }


  async delete(o: Questionnaire) {
    const r = await this.mydialog.openDialog('Questionnaire').toPromise();
    if (r === 'ok') {

      let list = [];
      o.pieceJointe !== '' ? list.push(...this.uow.decoupe(o.pieceJointe)) : list = list;
      this.uow.files.deleteFiles(list, 'questionnaire').subscribe(res => {
        this.uow.questionnaires.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/questionnaire/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'questionnaire'}});
  }

}

