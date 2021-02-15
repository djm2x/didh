import { SessionService } from './../../shared/session.service';
import { Examen } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { merge, Subject, BehaviorSubject, Observable } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { HttpClient, HttpEventType } from '@angular/common/http';
import { UowService } from 'src/app/services/uow.service';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { ArchiveComponent } from './archive/archive.component';
import { IData } from '../components/pie-chart/pie-chart.component';
import { MyTranslateService } from 'src/app/my.translate.service';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { startWith } from 'rxjs/operators';

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

  text = '';
  text2 = this.text.substring(0, 600);
  dataSource = [];
  columnDefs = [
    { columnDef: 'libelle', headName: 'libelle' },
    { columnDef: 'rapportNational', headName: 'Rapport national' },
    { columnDef: 'compilationHCDH', headName: 'Compilation HCDH/SOCIETE CIVILE' },
    { columnDef: 'discours', headName: 'Discours du président' },
    { columnDef: 'observationFinale', headName: 'Observations finales/ADDITIFS' },
    { columnDef: 'miseOeuvrePiece', headName: 'PLAN DE MISE EN OEUVRE' },
    { columnDef: 'rapportMiParcours', headName: 'Rapport mi-parcours' },
    { columnDef: 'rapportINDH', headName: 'rapportINDH' },
    { columnDef: 'option', headName: 'OPTION' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });

  displayedColumns = this.columnDefs.map(e => e.columnDef);

  countRec = new Subject();
  mecanismeState = new Subject();
  stateByMecanisme = new Subject();
  stateDetailByMecanisme = new Subject();


  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , @Inject('BASE_URL') public url: string, public mytranslate: MyTranslateService
    , public session: SessionService, private bottomSheet: MatBottomSheet) { }

  ngOnInit() {
    this.getMecanismeState();
    this.getStateByMecanisme();
    this.getStateDetailByMecanisme();
    // this.dataEpuPieGet()

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
        );
      });
  }

  disable(e: string) {
    return e && e !== '' ? false : true;
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
      data: { model: o, title: text },
      direction: this.mytranslate.langSync === 'fr' ? 'ltr' : 'rtl',
    });

    return dialogRef.afterClosed();
  }

  add() {
    this.openDialog(new Examen(), this.mytranslate.get('admin.epu.list.AjouterExamen')).subscribe(result => {
      if (result) {
        this.update.next(false);
      }
    });
  }

  edit(o: Examen) {
    this.openDialog(o, this.mytranslate.get('admin.epu.list.ModifierExamen')).subscribe((result: any) => {
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
      o.discours !== '' ? list.push(...this.uow.decoupe(o.discours)) : list = list;

      this.uow.files.deleteFiles(list, 'examen').subscribe(res => {
        this.uow.examens.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: { fileName, folder: 'examen' } });
  }

  /**
   * graphs
   */
  getMecanismeState() {
    this.uow.axes.mecanismeState().subscribe(r => {
      const chartLabels = [];
      chartLabels.push(this.mytranslate.get('NonRéalisé'));
      chartLabels.push(this.mytranslate.get('EnCours'));
      chartLabels.push(this.mytranslate.get('Recommendation_continue'));
      chartLabels.push(this.mytranslate.get('Réalisé'));


      const chartData = [];
      const dataToShowInTable = [];

      chartData.push(r.one * 100 / r.total);
      chartData.push(r.two * 100 / r.total);
      chartData.push(r.three * 100 / r.total);
      chartData.push(r.four * 100 / r.total);

      dataToShowInTable.push(r.one, r.two, r.three, r.four);

      this.countRec.next(r.one + r.two + r.three + r.four);

      const chartColors = [
        '#db0707',
        '#f7801e',
        '#2d71a1',
        '#2b960b',
        '#ffffff'
      ];

      this.mecanismeState.next({
        chartLabels, chartData, chartColors, dataToShowInTable
        , title: this.mytranslate.get('admin.header.ExamenPériodiqueuniverselle')
      });

    });
  }

  getStateByMecanisme() {
    this.uow.axes.stateByMecanisme().subscribe(r => {

      const chartLabels = r.map(e => e.name/*.substring(0, 40) + ' ...'*/);
      const chartData = r.map(e => +e.one.toFixed(0));
      const chartColors = [ ];
      const dataToShowInTable = [];

      this.stateByMecanisme.next({
        chartLabels, chartData, chartColors, dataToShowInTable
        , title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe')
      });

    });
  }

  getStateDetailByMecanisme() { // bar
    this.uow.axes.stateDetailByMecanisme().subscribe(r => {

      r = r.filter(e => e.name !== null);
      // console.log(r);
      const barChartLabels = r.map(e => e.name);
      const dataToShowInTable = []
      const barChartData = [
        { data: [], label: this.mytranslate.get('NonRéalisé')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('EnCours')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('Recommendation_continue')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('Réalisé')/*, stack: 'a'*/ },
      ];

      r.forEach(e => {
        barChartData[0].data.push(+(e.one * 100 / e.total).toFixed(0));
        barChartData[1].data.push(+(e.two * 100 / e.total).toFixed(0));
        barChartData[2].data.push(+(e.three * 100 / e.total).toFixed(0));
        barChartData[3].data.push(+(e.four * 100 / e.total).toFixed(0));
      });

      this.stateDetailByMecanisme.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.epu.list.EtatAvancementderecommandationsparaxe') });
    });
  }

}

