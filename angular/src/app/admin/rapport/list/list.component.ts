import { SessionService } from './../../../shared/session.service';
import { Rapport, Traite } from './../../../Models/models';

import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { merge, BehaviorSubject, Subject, Observable } from 'rxjs';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { Visite, Recommendation } from 'src/app/Models/models';
import { DeleteService } from '../../components/delete/delete.service';
import { SheetbottomComponent } from '../sheetbottom/sheetbottom.component';
import { ActivatedRoute } from '@angular/router';
import { DetailComponent } from '../detail/detail.component';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { ArchiveComponent } from '../archive/archive.component';
import { IData } from '../../components/pie-chart/pie-chart.component';
import { MyTranslateService } from 'src/app/my.translate.service';

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
    { columnDef: 'discours', headName: 'Discours du président' },
    { columnDef: 'analytiquePiece', headName: 'Compte rendu analytique' },
    { columnDef: 'observationPiece', headName: `Observations finales` },
    { columnDef: 'rapportParallelePiece', headName: `Rapport  parallèle` },
    { columnDef: 'miseOeuvrePiece', headName: 'PLAN DE MISE EN OEUVRE' },
    { columnDef: 'rapportINDH', headName: 'rapportINDH' },
    { columnDef: 'avisPosition', headName: 'avisPosition' },
    { columnDef: 'option', headName: '...' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });

  text = ``;
  text2 = this.text.substring(0, 600);

  displayedColumns = this.columnDefs.filter(e => e.columnDef !== 'miseOeuvrePiece').map(e => e.columnDef);
  progress = 0;
  message: any;
  // formData = new FormData();
  countRec = new Subject();
  mecanismeState = new Subject();
  stateByMecanisme = new Subject();
  stateDetailByMecanisme = new Subject();


  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , public mytranslate: MyTranslateService, private bottomSheet: MatBottomSheet, public session: SessionService
    , private route: ActivatedRoute, @Inject('BASE_URL') public url: string) { }

  ngOnInit() {
    // // console.log(this.columnDefs)
    this.getPage(0, 10, 'id', 'desc', this.session.isPublic ? 0 : this.session.user.idOrganisme);
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
          this.session.isPublic ? 0 : this.session.user.idOrganisme
        );
      }
    );
    // this.route.queryParams.subscribe(params => {
    //   const id = params['data'];
    //   if (id) {
    //     this.uow.rapports.getOne(id).subscribe(r => {
    //       this.openDialog(r);
    //     });
    //   }
    // });

    this.getMecanismeState();
    this.getStateByMecanisme();
    this.getStateDetailByMecanisme();

    this.uow.recommendations.mecanismeCount('organe').subscribe(r => this.countRec.next(r));

  }

  disable(e: string) {
    return e && e !== '' ? false : true;
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idOrganisme) {
    this.uow.traites.getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme).subscribe(
      (r: any) => {
        // // console.log(r.list);
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

  moreInfo() {
    // const dialogRef = this.dialog.open(ModalComponent, {
    //   width: '80vw',
    //   disableClose: true,
    //   direction: this.mytranslate.langSync === 'fr' ? 'ltr' : 'rtl',
    // });

    // return dialogRef.afterClosed();
    const isSmall = this.text2.length === 600;

    this.text2 = isSmall ? this.text : this.text.substring(0, 600);
  }


  async delete(o: Traite) {
    const r = await this.mydialog.openDialog('rapport').toPromise();
    if (r === 'ok') {
      let list = [];
      o.conventionPiece !== '' ? list.push(...this.uow.decoupe(o.conventionPiece)) : list = list;
      o.miseOeuvrePiece !== '' ? list.push(...this.uow.decoupe(o.miseOeuvrePiece)) : list = list;
      o.observationPiece !== '' ? list.push(...this.uow.decoupe(o.observationPiece)) : list = list;
      o.discours !== '' ? list.push(...this.uow.decoupe(o.discours)) : list = list;
      o.analytiquePiece !== '' ? list.push(...this.uow.decoupe(o.analytiquePiece)) : list = list;
      o.miseOeuvrePiece !== '' ? list.push(...this.uow.decoupe(o.miseOeuvrePiece)) : list = list;


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
    // console.log(o);
    this.bottomSheet.open(SheetbottomComponent, { data: o, });
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: { fileName, folder: 'traite' } });
  }

  /**
   * graphs
   */
  getMecanismeState() {
    this.uow.organes.mecanismeState().subscribe(r => {
      const chartLabels = [];
      chartLabels.push(this.mytranslate.get('Réalisé'));
      chartLabels.push(this.mytranslate.get('NonRéalisé'));
      chartLabels.push(this.mytranslate.get('EnCours'));
      chartLabels.push(this.mytranslate.get('Recommendation_continue'));


      const chartData = [];
      const dataToShowInTable = [];

      chartData.push(r.four * 100 / r.total);
      chartData.push(r.one * 100 / r.total);
      chartData.push(r.two * 100 / r.total);
      chartData.push(r.three * 100 / r.total);

      dataToShowInTable.push(r.one, r.two, r.three, r.four);

      const chartColors = [
        '#2b960b',
        '#db0707',
        '#f7801e',
        '#2d71a1',
        '#ffffff'
      ];

      this.mecanismeState.next({
        chartLabels, chartData, chartColors, dataToShowInTable
        , title: this.mytranslate.get('admin.header.Etat de mise en œuvre')
      });

    });
  }

  getStateByMecanisme() {
    this.uow.organes.stateByMecanisme().subscribe(r => {

      const chartLabels = r.map(e => e.name/*.substring(0, 40) + ' ...'*/);
      const chartData = r.map(e => +e.one.toFixed(0));
      const chartColors = [ ];
      const dataToShowInTable = [];

      this.stateByMecanisme.next({
        chartLabels, chartData, chartColors, dataToShowInTable
        , title: this.mytranslate.get('admin.organe.list.Tauxderecommandationsparorgane')
      });

    });
  }

  getStateDetailByMecanisme() { // bar
    this.uow.organes.stateDetailByMecanisme().subscribe(r => {

      r = r.filter(e => e.name !== null);
      // // console.log(r);
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


