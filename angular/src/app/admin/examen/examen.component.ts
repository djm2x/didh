import { SessionService } from './../../shared/session.service';
import {  Examen } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatBottomSheet } from '@angular/material';
import { merge, Subject, BehaviorSubject, Observable } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { HttpEventType } from '@angular/common/http';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { ActivatedRoute } from '@angular/router';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { ArchiveComponent } from './archive/archive.component';
import { IData } from '../components/pie-chart/pie-chart.component';
import { MyTranslateService } from 'src/app/my.translate.service';
import { ModalComponent } from './modal/modal.component';

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

  text = `Etabli par la résolution 60/251 de l’Assemblée générale des Nations Unies, adoptée le 15 mars 2006, l’Examen
  Périodique Universel (EPU) est un processus mené par les Etats, dans le cadre des travaux du Groupe de
  travail sur l’Examen périodique universel constitué des 47 États membres du Conseil des droits de l’Homme,
  qui a pour fonction d’examiner et de promouvoir le suivi des obligations et des engagements de tous les
  États membres des Nations Unies dans le domaine du respect, de la promotion et de la réalisation effective
  de tous les droits de l’Homme sur le terrain, et ce tous les quatre ans et demi.

  Ce mécanisme consiste à examiner le degré de mise en œuvre des obligations des Etats à la lumière notamment
  de la Charte des Nations Unies, la Déclaration universelle des droits de l’Homme (DUDH) et des instruments
  relatifs aux droits de l’Homme auxquelles l’État examiné est partie. Il se base sur trois sources
  d’information :
  <li> un rapport présenté par l’État examiné (vingt pages) ; </li>
  <li> une compilation établie par le Haut-Commissariat des Nations Unies aux droits de l’homme (HCDH) sur la
    base des informations fournies par les organes de traités, les procédures spéciales et les agences des
    Nations Unies (dix pages) ; </li>
  <li> et un résumé établi par le HCDH des communications présentées par d’autres parties prenantes notamment
    les organisations de la société civile et les institutions nationales des droits de l’Homme (dix pages).
  </li>
  L’examen au sein du Groupe de travail sur l’EPU se déroule à Genève en trois étapes :
  <li> le dialogue interactif d’une durée de trois heures et demi qui a lieu lors des sessions du Groupe de
    travail sur l’EPU qui se tiennent trois fois par an en janvier, avril et octobre, à raison de 14 États
    examinés par session. </li>
  <li> L’adoption « technique » du rapport final de l’EPU, élaboré par la troïka, listant les recommandations
    faites à l’État examiné lors de la session du Groupe de travail de l’EPU. Ce rapport comprend les
    questions, les observations et les recommandations formulées par les États au pays examiné, ainsi que les
    réponses de ce dernier. L’État examiné a la possibilité de formuler des commentaires préliminaires sur les
    recommandations en choisissant de les accepter ou d’en prendre note. Les recommandations acceptées et
    celles notées sont incluses dans le rapport.</li>
  <li> l’adoption du document final lors d’une séance plénière du Conseil des droits de l’Homme. Au cours de
    cette séance, l’État examiné peut répondre aux questions et aux points qui n’ont pas été suffisamment
    traités par le Groupe de travail et donner suite aux recommandations qui ont été formulées par les États
    au cours de l’examen. A cette étape, les États Membres, les institutions nationales des droits de l’homme,
    et les ONG peuvent exprimer leur opinion sur le document final. Le résultat de chaque examen est un
    "document final".</li>
  Les recommandations acceptées doivent être mises en œuvre et faire ainsi l’objet d’un suivi de la part de
  l’Etat examiné durant la période considérée et qui sépare les deux examens.
  Le Maroc a été examiné par le mécanisme de l’EPU en 2008 au titre son premier cycle, en 2012 au titre de
  son second cycle et en 2017 au titre de son troisième cycle. le Maroc a fait l’objet de 148
  recommandations dont 140 ont été acceptées à l’issue du 2ème cycle de l’EPU, et de 244 recommandations
  dont 191 ont été accepté, et 44 notées et 9 refusées au titre du 3ème cycle de l’EPU.
  Aussi, dans le cadre de son engagement volontaire devant le Conseil des droits, consacré pour la deuxième
  fois après avoir présenté un premier rapport à mi-parcours en 2014, le Maroc a présenté son rapport à mi
  parcours relatif au suivi de la mise en œuvre des recommandations issues du 3ème cycle de l’EPU en 2019.`
  text2 = this.text.substring(0, 300);
  dataSource = [];
  columnDefs = [
    { columnDef: 'libelle', headName: 'libelle' },
    { columnDef: 'rapportNational', headName: 'Rapport national' },
    { columnDef: 'compilationHCDH', headName: 'Compilation HCDH/SOCIETE CIVILE' },
    { columnDef: 'discours', headName: 'Discours du président' },
    { columnDef: 'observationFinale', headName: 'Observations finales/ADDITIFS' },
    { columnDef: 'miseOeuvrePiece', headName: 'PLAN DE MISE EN OEUVRE' },
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

  pieChartSubjectC = new BehaviorSubject<IData>({table: 'axe', type: 'taux', title: this.mytranslate.getObs('admin.epu.list.Tauxderecommandationsparaxe')});
  pieChartSubject = new BehaviorSubject<IData>({table: 'axe', type: 'etat', title: this.mytranslate.getObs('admin.epu.list.Miseenœuvredesrecommandationsparaxe')});
  pieChartSubjectR = new BehaviorSubject<IData>({table: 'axe', type: 'realise', title: this.mytranslate.getObs('admin.epu.list.Realisé')});

  dataEpu = new Subject<{ name: string | Observable<string>, p: number, t: number, r: number, nbt: number, nbp: number, nbr: number }>();

  examenPageSubject = new Subject();
  dataEpuPie = new Subject();
  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , private snack: SnackbarService, @Inject('BASE_URL') public url: string
    , public mytranslate: MyTranslateService, public session: SessionService, private bottomSheet: MatBottomSheet) { }

  ngOnInit() {
    // this.stateMecanisme();
    this.stateAxe();
    this.stateOneOFMecanisme();
    setTimeout(() => this.getPage(0, 10, 'id', 'desc'), 300);
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

  stateOneOFMecanisme() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {
      const chartLabels = [];
      chartLabels.push(this.mytranslate.get('admin.organe.list.EnCours'));
      chartLabels.push(this.mytranslate.get('admin.organe.list.Réalisé'));
      chartLabels.push(this.mytranslate.get('admin.organe.list.NonRéalisé'));

      // chartLabels.push('')

      const chartData = [];
      const dataToShowInTable = [];

      // chartData.push(r.epu.p * r.epu.t / 100);
      // chartData.push(r.epu.r * r.epu.t / 100);
      // chartData.push(r.epu.t - (r.epu.p * r.epu.t / 100) - (r.epu.r * r.epu.t / 100));

      chartData.push(r.epu.p);
      chartData.push(r.epu.r);
      chartData.push(r.epu.t - (r.epu.p) - (r.epu.r));


      // chartData.push(100 - r.epu.t);


      const chartColors = ['#f7801e', '#2b960b', '#db0707', '#ffffff'];

      this.dataEpuPie.next({
        chartLabels, chartData, chartColors, dataToShowInTable, count: r.count
        , title: this.mytranslate.get('admin.header.ExamenPériodiqueuniverselle')
      });

    });
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

  // moreInfo() {
  //   const conf = {
  //     width: '7100px',
  //     disableClose: false,
  //     data: { model: 'ddddddd', type: 'cercle' , title: 'Examen'}
  //   };

  //   this.dialog.open(Examen, conf).afterClosed().subscribe(r => {
  //     console.log(r);
  //   });
  // }


  // moreInfol() {
  //   const conf = {
  //     width: '7100px',
  //     disableClose: false,
  //     data: { model: 'gggg', type: 'pie', title: '222' }
  //   };

  //   this.dialog.open('fffffffffffffffffffffff', conf).afterClosed().subscribe(r => {
  //     console.log(r);
  //   });
  // }

  moreInfo() {
    // const dialogRef = this.dialog.open(ModalComponent, {
    //   width: '80vw',
    //   disableClose: true,
    //   direction: this.mytranslate.langSync === 'fr' ? 'ltr' : 'rtl',
    // });

    // return dialogRef.afterClosed();
    const isSmall = this.text2.length === 300;

    this.text2 = isSmall ? this.text : this.text.substring(0, 300);
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
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'examen'}});
  }


  stateMecanisme() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {
      // console.log(r)
      r.epu.name = this.mytranslate.getObs('admin.home.ExamenPériodiqueuniversell');
      (r.epu as any).count = r.count;
      this.dataEpu.next(r.epu);
      // r.epu.p = +(r.epu.p * r.epu.t / 100).toFixed(0);
      // r.epu.r = +(r.epu.r * r.epu.t / 100).toFixed(0);
      console.log({r: r.epu,});
    });
  }

  stateAxe() {
    this.uow.axes.stateAxes().subscribe(r => {

      r = r.filter(e => e.name !== null);
      console.log(r);
      const barChartLabels = r.map(e => e.name);
      const barChartData = [
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.NonRéalisé')/*, stack: 'a'*/ },
      ];

      r.forEach(e => {
        barChartData[0].data.push((e.p * e.t / 100).toFixed(0));
        barChartData[1].data.push((e.r * e.t / 100).toFixed(0));
        barChartData[2].data.push((e.t - (e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
        // r.epu.t - (r.epu.p * r.epu.t / 100) - (r.epu.r * r.epu.t / 100)
        // barChartData[2].data.push(((e.p * e.t / 100) - (e.r * e.t / 100)).toFixed(0));
        // (r.epu.t - (r.epu.p * r.epu.t / 100) - (r.epu.r * r.epu.t / 100))
      });
      // tslint:disable-next-line:max-line-length
      this.examenPageSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.epu.list.EtatAvancementderecommandationsparaxe') });
    });
  }

}

