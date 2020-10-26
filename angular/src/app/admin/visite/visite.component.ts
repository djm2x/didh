import { SessionService } from './../../shared/session.service';
import { Notification, Visite } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatBottomSheet } from '@angular/material';
import { merge, BehaviorSubject, Subject, Observable } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { HttpEventType } from '@angular/common/http';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { ActivatedRoute } from '@angular/router';
import { DetailComponent } from './detail/detail.component';
import { ArchiveComponent } from './archive/archive.component';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { IData } from '../components/pie-chart/pie-chart.component';
import { MyTranslateService } from 'src/app/my.translate.service';
import { ModalComponent } from './modal/modal.component';

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
    { columnDef: 'option', headName: 'OPTION' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });

  displayedColumns = this.columnDefs.map(e => e.columnDef);
  progress = 0;
  message: any;
  formData = new FormData();

  text = ``;

  text2 = this.text.substring(0, 600);

  dataPs = new Subject<{ name: string | Observable<string>, p: number, t: number, r: number }>();

  pieChartSubject = new BehaviorSubject<IData>({table: 'visite', type: 'etat', title: 'Etat d’avancement des recommandations par visite'});
  pieChartSubjectC = new BehaviorSubject<IData>({table: 'visite', type: 'taux', title: this.mytranslate.get('admin.ps.list.Tauxderecommandationsparvisite')});
  visitePageSubject = new Subject();
  visitePage: {name: string, p: number, t: number, r: number}[] = [];
  retate = 0;
  dataPie = new Subject();
  countRec = new Subject();
  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , private bottomSheet: MatBottomSheet, @Inject('BASE_URL') public url: string
    , private route: ActivatedRoute, public session: SessionService
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.mytranslate.lang.subscribe(lang => {
      this.retate = lang === 'fr' ? 0 : 180;
    });

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

    this.route.queryParams.subscribe(params => {
      const id = params['data'];
      if (id) {
        this.uow.visites.getOne(id).subscribe(r => {
          this.openDialogDetail(r);
        });
      }
    });

    //this.stateVisite();
    this.stateGraphe();
    this.stateMecanisme();
    this.stateOneOFMecanisme();
  }

  disable(e: string) {
    return e && e !== '' ? false : true;
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

      // chartData.push(r.ps.p * r.ps.t / 100);
      // chartData.push(r.ps.r * r.ps.t / 100);
      // chartData.push(r.ps.t - (r.ps.p * r.ps.t / 100) - (r.ps.r * r.ps.t / 100));

      chartData.push(r.ps.p * 100 / r.ps.t);
      chartData.push(r.ps.r * 100 / r.ps.t);
      chartData.push(r.ps.n * 100 / r.ps.t);


      // chartData.push(100 - r.ps.t);
      dataToShowInTable.push(r.ps.p, r.ps.r, r.ps.n);
      this.countRec.next(r.ps.p + r.ps.r + r.ps.n);
      const chartColors = ['#f7801e', '#2b960b', '#db0707', '#ffffff'];

      this.dataPie.next({
        chartLabels, chartData, chartColors, dataToShowInTable, count: r.count
        , title: this.mytranslate.get('admin.home.Procéduresspéciales')
      });

    });
  }


  stateMecanisme() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {
      r.ps.name = this.mytranslate.getObs('admin.home.Procéduresspéciales');
      (r.ps as any).count = r.count;
      this.dataPs.next(r.ps);
    });
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
    // const dialogRef = this.dialog.open(ModalComponent, {
    //   width: '80vw',
    //   disableClose: true,
    //   direction: this.mytranslate.langSync === 'fr' ? 'ltr' : 'rtl',
    // });

    // return dialogRef.afterClosed();
    const isSmall = this.text2.length === 600;

    this.text2 = isSmall ? this.text : this.text.substring(0, 600);
  }
  getPage(startIndex, pageSize, sortBy, sortDir) {
    this.uow.visites.getList(startIndex, pageSize, sortBy, sortDir).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }

  stateVisite() {
    this.uow.recommendations.stateVisite().subscribe(r => {
      r = r.filter(e => e.name !== null);
      this.visitePage = r;
    });
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
        const notif: Notification = {
          id: 0,
          date: new Date(),
          destinataire: '',
          idConcerner: result.id,
          idOrganisme: this.session.user.idOrganisme,
          message: 'Nouvelle Procédure spéciale a été ajouter',
          priorite: 1,
          tableConcerner: 'visite',
          vu: false
        };
        this.uow.notifications.post(notif).subscribe(n => {
        });

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
        const notif: Notification = {
          id: 0,
          date: new Date(),
          destinataire: '',
          idConcerner: o.id,
          idOrganisme: this.session.user.idOrganisme,
          message: 'La Procédure spéciale a été modifiée',
          priorite: 1,
          tableConcerner: 'visite',
          vu: false
        };

        this.uow.notifications.post(notif).subscribe(n => { });
        this.update.next(true);
      }
    });
  }

  async delete(o: Visite) {
    const r = await this.mydialog.openDialog('Procédure spéciale').toPromise();
    if (r === 'ok') {
      // console.log(o);
      let list = [];
      o.lienUpload !== '' ? list.push(...this.uow.decoupe(o.lienUpload)) : list = list;
      o.discours !== '' ? list.push(...this.uow.decoupe(o.discours)) : list = list;

      this.uow.files.deleteFiles(list, 'visite').subscribe(res => {
        this.uow.examens.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  // postFile(visite, file: File) {
  //   this.formData = new FormData();

  //   this.formData.append(`${file.lastModified}_${file.name}`, file);
  //   this.uow.files.postFile(this.formData).subscribe((event: any) => {
  //     if (event.type === HttpEventType.UploadProgress) {
  //       this.progress = Math.round(100 * event.loaded / event.total);
  //       console.log(this.progress);
  //     } else if (event.type === HttpEventType.Response) {
  //       this.message = event.body.toString();
  //       console.log(this.message);
  //       console.log(event);
  //     } else {
  //       visite.lienUpload = event.fileName; // `${visite.id}_${file.name}`;
  //       this.uow.visites.put(visite.id, visite).subscribe(rs => this.update.next(true));
  //     }
  //   });
  // }

  showPieceJoin(fileName) {
    // const url = `${this.url}/examen/${fileName}`;
    // window.open(url);
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'visite'}});
  }

  stateGraphe() {
    this.uow.visites.stateVisites().subscribe(r => {

      r = r.filter(e => e.name !== null);
      console.log(r);
      // const barChartLabels = r.map(e => e.name.substring(0, 50) + '...');
      const barChartLabels = r.map(e => e.name);
      const barChartData = [
        // { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement') },
        // { data: [], label: this.mytranslate.get('admin.organe.list.Taux') },
        // { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé') },
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.NonRéalisé')/*, stack: 'a'*/ },
      ];


      r.forEach(e => {
        // barChartData[0].data.push(+e.p.toFixed(0));
        // barChartData[1].data.push(+e.t.toFixed(0));
        // barChartData[2].data.push(+e.r.toFixed(0));
        barChartData[0].data.push((e.p * 100 / e.t).toFixed(0));
        barChartData[1].data.push((e.r * 100 / e.t).toFixed(0));
        barChartData[2].data.push((e.n * 100 / e.t).toFixed(0));
      });


      // tslint:disable-next-line:max-line-length {{ 'admin.ps.Mise_en_œuvre_des_recommandations_par_Procédures_spéciales' | translate }}
      this.visitePageSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.ps.Mise_en_œuvre_des_recommandations_par_Procédures_spéciales') });
    });
  }

}
