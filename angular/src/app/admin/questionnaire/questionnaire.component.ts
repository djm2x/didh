import { SessionService } from './../../shared/session.service';
import { Questionnaire } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
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
import { MyTranslateService } from 'src/app/my.translate.service';


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
  themes: {
    id: number
    name: string,
    nameAr: string,
    sousThemes: {
      id: number
      name: string,
      nameAr: string,
    }[]
  }[] = [];
  sousThemes: {
    id: number
    name: string,
    nameAr: string,
  }[] = [];

  idAxe = new FormControl(0);
  idSousAxe = new FormControl(0);
  annee = new FormControl(/*new Date().getFullYear()*/0);
  reporter = new FormControl('');
  reporterAr = new FormControl('');

  dataSource = [];
  columnDefs = [
    { columnDef: 'annee', headName: 'année' },
    { columnDef: 'axe', headName: 'axe' },
    { columnDef: 'sousAxe', headName: 'sousAxe' },
    // { columnDef: 'reporter', headName: 'reporter' },
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

  axes = this.uow.axes.get();
  sousAxes = [];

  constructor(public uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , private http: HttpClient, @Inject('BASE_URL') public url: string
    , public mytranslate: MyTranslateService, public session: SessionService, private bottomSheet: MatBottomSheet) { }

  async ngOnInit() {
    this.themes = await this.uow.themes.toPromise();
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
          this.idAxe.value !== 0 ? this.idAxe.value : 0,
          this.idSousAxe.value !== 0 ? this.idSousAxe.value : 0,
          this.annee.value !== 0 ? this.annee.value : 0,
          // this.reporter.value !== '' ? this.reporter.value : '*',
          // this.reporterAr.value !== '' ? this.reporterAr.value : '*',
        );
      }
    );


  }


  axeChange(idAxe: number) {
    this.uow.sousAxes.getByIdAxe(idAxe).subscribe(r => {
      this.sousAxes = r as any[];
    });
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idAxe, idSousAxe, annee) {
    this.uow.questionnaires.getAll(startIndex, pageSize, sortBy, sortDir, idAxe, idSousAxe, annee).subscribe(
      (r: any) => {
        // console.log(r.list);
        // this.dataSource = (r.list as Questionnaire[]).map(e => {
        //   try {
        //     const theme$ = this.themes.find(f => f.id === e.theme);
        //     const sousTheme$ = theme$.sousThemes.find(f => f.id === e.sousTheme);
        //     e.themeDis = this.mytranslate.langSync === 'fr' ? theme$.name : theme$.nameAr;
        //     e.sousThemeDis = this.mytranslate.langSync === 'fr' ? sousTheme$.name : sousTheme$.nameAr;
        //     return e;
        //   } catch (error) {
        //     console.warn(error)
        //     return e;
        //   }
        // });

        this.dataSource = r.list;

        // // console.log(this.dataSource.map(e => e.sousThemeDis))
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
      direction: this.mytranslate.langSync === 'fr' ? 'ltr' : 'rtl',
    });

    return dialogRef.afterClosed();
  }

  selectChange(id: number) {
    this.sousThemes = this.themes.find(e => e.id === id).sousThemes;
  }

  add() {
    this.openDialog(new Questionnaire(), this.mytranslate.get('admin.questionnaire.list.Ajouter_Questionnaire')).subscribe(result => {
      if (result) {
        this.update.next(false);
      }
    });
  }

  edit(o: Questionnaire) {
    this.openDialog(o, this.mytranslate.get('admin.questionnaire.list.Modifier_Questionnaire')).subscribe((result: any) => {
      if (result) {
        this.update.next(false);
      }
    });
  }

  search() {
    this.update.next(true);
  }

  reset() {
    this.idAxe.setValue(0);
    this.idSousAxe.setValue(0);
    this.annee.setValue(0);
    this.reporter.setValue('');
    this.reporterAr.setValue('');
    this.update.next(true);
  }


  async delete(o: Questionnaire) {
    const r = await this.mydialog.openDialog(this.mytranslate.get('admin.questionnaire.list.Questionnaire')).toPromise();
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
    this.bottomSheet.open(DownloadSheetComponent, { data: { fileName, folder: 'questionnaire' } });
  }

}

