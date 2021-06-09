import { SessionService } from './../../shared/session.service';
import { Visite } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { merge,  Subject } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { UowService } from 'src/app/services/uow.service';
import { ActivatedRoute } from '@angular/router';
import { DetailComponent } from './detail/detail.component';
import { ArchiveComponent } from './archive/archive.component';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { MyTranslateService } from 'src/app/my.translate.service';
import { startWith } from 'rxjs/operators';

@Component({
  selector: 'app-visite',
  templateUrl: './visite.component.html',
  styleUrls: ['./visite.component.scss']
})
export class VisiteComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;

  dataSource = [];
  columnDefs = [
    { columnDef: 'mandat', headName: 'MANDAT' },
    { columnDef: 'date', headName: 'Date de la visite' },
    { columnDef: 'lienUpload', headName: 'RAPPORT NATIONAL DE LA VISITE' },
    { columnDef: 'discours', headName: 'RAPPORT DE LA PROCEDURE/REACTION NATIONALE' },
    { columnDef: 'miseOeuvrePiece', headName: 'PLAN DE MISE EN OEUVRE' },
    { columnDef: 'commentaire', headName: 'commentaire' },
    { columnDef: 'option', headName: 'OPTION' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });

  displayedColumns = this.columnDefs.filter(e => e.columnDef !== 'discours' && e.columnDef !== 'miseOeuvrePiece').map(e => e.columnDef);
  progress = 0;
  message: any;
  formData = new FormData();

  text = ``;

  text2 = this.text.substring(0, 600);

  countRec = new Subject();
  mecanismeState = new Subject();
  stateByMecanisme = new Subject();
  stateDetailByMecanisme = new Subject();

  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , private bottomSheet: MatBottomSheet, @Inject('BASE_URL') public url: string
    , private route: ActivatedRoute, public session: SessionService
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {

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
      }
    );

    this.route.queryParams.subscribe(params => {
      const id = params['data'];
      if (id) {
        this.uow.visites.getOne(id).subscribe(r => {
          this.openDialogDetail(r);
        });
      }
    });

    this.getMecanismeState();
    this.getStateByMecanisme();
    this.getStateDetailByMecanisme();

    this.uow.recommendations.mecanismeCount('visite').subscribe(r => this.countRec.next(r));
  }

  disable(e: string) {
    return e && e !== '' ? false : true;
  }

  openDialogDetail(o: any) {
    const dialogRef = this.dialog.open(DetailComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: 'Visite' }
    });

    return dialogRef.afterClosed();
  }
  moreInfo() {
    const isSmall = this.text2.length === 600;

    this.text2 = isSmall ? this.text : this.text.substring(0, 600);
  }
  getPage(startIndex, pageSize, sortBy, sortDir) {
    this.uow.visites.getList(startIndex, pageSize, sortBy, sortDir).subscribe(
      (r: any) => {
        // console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }

  openDialog(o: Visite, text) {
    const dialogRef = this.dialog.open(UpdateComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: text },
    });

    return dialogRef.afterClosed();
  }

  add() {
    this.openDialog(new Visite(), this.mytranslate.get('admin.ps.list.Ajouter_Procédure_spéciale')).subscribe(result => {
      if (result) {
        // const notif: Notification = {
        //   id: 0,
        //   date: new Date(),
        //   destinataire: '',
        //   idConcerner: result.id,
        //   idOrganisme: this.session.user.idOrganisme,
        //   message: 'Nouvelle Procédure spéciale a été ajouter',
        //   priorite: 1,
        //   tableConcerner: 'visite',
        //   vu: false
        // };
        // this.uow.notifications.post(notif).subscribe(n => {
        // });

        this.update.next(true);
      }
    });
  }

  archive(o: Visite) {
    this.dialog.open(ArchiveComponent, {
      width: '80vw',
      disableClose: true,
      data: { model: o, title: o.mandat }
    });
  }

  edit(o: Visite) {
    this.openDialog(o, this.mytranslate.get('admin.ps.list.Modifier_Procédure_spéciale')).subscribe((result: any) => {
      if (result) {
        // const notif: Notification = {
        //   id: 0,
        //   date: new Date(),
        //   destinataire: '',
        //   idConcerner: o.id,
        //   idOrganisme: this.session.user.idOrganisme,
        //   message: 'La Procédure spéciale a été modifiée',
        //   priorite: 1,
        //   tableConcerner: 'visite',
        //   vu: false
        // };

        // this.uow.notifications.post(notif).subscribe(n => { });
        this.update.next(true);
      }
    });
  }

  async delete(o: Visite) {
    const r = await this.mydialog.openDialog('Procédure spéciale').toPromise();
    if (r === 'ok') {
      // // console.log(o);
      let list = [];
      o.lienUpload !== '' ? list.push(...this.uow.decoupe(o.lienUpload)) : list = list;
      o.discours !== '' ? list.push(...this.uow.decoupe(o.discours)) : list = list;

      this.uow.files.deleteFiles(list, 'visite').subscribe(res => {
        this.uow.examens.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'visite'}});
  }

  /**
   * graphs
   */
  getMecanismeState() {
    this.uow.visites.mecanismeState().subscribe(r => {
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
    this.uow.visites.stateByMecanisme().subscribe(r => {

      const chartLabels = r.map(e => e.name/*.substring(0, 40) + ' ...'*/);
      const chartData = r.map(e => +e.one.toFixed(0));
      const chartColors = [ ];
      const dataToShowInTable = [];

      this.stateByMecanisme.next({
        chartLabels, chartData, chartColors, dataToShowInTable
        , title: this.mytranslate.get('admin.ps.list.Tauxderecommandationsparvisite')
      });

    });
  }

  getStateDetailByMecanisme() { // bar
    this.uow.visites.stateDetailByMecanisme().subscribe(r => {

      r = r.filter(e => e.name !== null);
      // // console.log(r);
      const barChartLabels = r.map(e => e.name);
      const dataToShowInTable = []
      const barChartData = [
        { data: r.map(e => +(e.four * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Réalisé')/*, stack: 'a'*/ },
        { data: r.map(e => +(e.three * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Recommendation_continue')/*, stack: 'a'*/ },
        { data: r.map(e => +(e.two * 100 / e.total).toFixed(0)), label: this.mytranslate.get('EnCours')/*, stack: 'a'*/ },
        { data: r.map(e => +(e.one * 100 / e.total).toFixed(0)), label: this.mytranslate.get('NonRéalisé')/*, stack: 'a'*/ },
      ];

      this.stateDetailByMecanisme.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.organe.list.MiseenœuvredesrecommandationsparOrganesdeTraités') });
    });
  }

}
