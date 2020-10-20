import { SessionService } from './../../../shared/session.service';
import { Rapport, Traite } from './../../../Models/models';

import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatBottomSheet } from '@angular/material';
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
import { ModalComponent } from '../modal/modal.component';

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
    { columnDef: 'option', headName: '...' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });

  text = ``;
  text2 = this.text.substring(0, 600);

  // tslint:disable-next-line:max-line-length


  // . Convention/Protocole
  // 2. Rapport national
  // 3.Observations finales
  // 4.Rapport de suivi de la mise en œuvre

  displayedColumns = this.columnDefs.map(e => e.columnDef);
  progress = 0;
  message: any;
  formData = new FormData();

  pieChartSubject = new BehaviorSubject<IData>({ table: 'organe', type: 'etat', title: 'Etat d’avancement des recommandations par organe' });
  pieChartSubjectC = new BehaviorSubject<IData>({ table: 'organe', type: 'taux', title: this.mytranslate.getObs('admin.organe.list.Tauxderecommandationsparorgane') });

  organePageSubject = new Subject();
  countRec = new Subject();
  dataOt = new Subject<{ name: string | Observable<string>, p: number, t: number, r: number }>();
  dataPie = new Subject();
  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , public mytranslate: MyTranslateService, private bottomSheet: MatBottomSheet, public session: SessionService
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

    this.stateOrgane();
    this.stateMecanisme();
    this.stateOneOFMecanisme();

  }

  stateOneOFMecanisme() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {
      const chartLabels = [];
      chartLabels.push(this.mytranslate.get('admin.organe.list.Etatavancement'));
      chartLabels.push(this.mytranslate.get('admin.organe.list.Réalisé'));
      chartLabels.push(this.mytranslate.get('admin.organe.list.NonRéalisé'));

      // chartLabels.push('')

      const chartData = [];
      const dataToShowInTable = [];

      // chartData.push(r.ot.p * r.ot.t / 100);
      // chartData.push(r.ot.r * r.ot.t / 100);
      // chartData.push(r.ot.t - (r.ot.p * r.ot.t / 100) - (r.ot.r * r.ot.t / 100));

      chartData.push(r.ot.p * 100 / r.ot.t);
      chartData.push(r.ot.r * 100 / r.ot.t);
      chartData.push(r.ot.n * 100 / r.ot.t);

      // chartData.push(100 - r.ot.t);
      dataToShowInTable.push(r.ot.p, r.ot.r, r.ot.n);
      this.countRec.next(r.ot.p + r.ot.r + r.ot.n);
      const chartColors = ['#f7801e', '#2b960b', '#db0707',  '#ffffff'];

      this.dataPie.next({
        chartLabels, chartData, chartColors, dataToShowInTable, count: r.count
        , title: this.mytranslate.get('admin.home.OrganesdeTraités')
      });

    });
  }


  stateMecanisme() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {
      r.ot.name = this.mytranslate.getObs('admin.home.OrganesdeTraités');
      (r.ot as any).count = r.count;
      this.dataOt.next(r.ot);
    });
  }


  stateOrgane() {
    this.uow.recommendations.stateOrgane().subscribe(r => {

      r = r.filter(e => e.name !== null);
      console.log(r);
      const barChartLabels = r.map(e => e.name);
      const barChartData = [
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.NonRéalisé')/*, stack: 'a'*/ },
      ];

      r.forEach(e => {
        // barChartData[0].data.push((e.p * e.t / 100).toFixed(0));
        // barChartData[1].data.push((e.r * e.t / 100).toFixed(0));
        // barChartData[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));

        barChartData[0].data.push((e.p * 100 / e.t).toFixed(2));
        barChartData[1].data.push((e.r * 100 / e.t).toFixed(2));
        barChartData[2].data.push((e.n * 100 / e.t).toFixed(2));

        // barChartData[2].data.push(e.t.toFixed(0));
      });
      // tslint:disable-next-line:max-line-length
      this.organePageSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.organe.list.MiseenœuvredesrecommandationsparOrganesdeTraités') });
    });
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idOrganisme) {
    this.uow.traites.getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme).subscribe(
      (r: any) => {
        // console.log(r.list);
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
    console.log(o);
    this.bottomSheet.open(SheetbottomComponent, { data: o, });
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: { fileName, folder: 'traite' } });
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


