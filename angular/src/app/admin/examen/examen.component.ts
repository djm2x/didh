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

  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService
    , private snack: SnackbarService, @Inject('BASE_URL') public url: string
    , public mytranslate: MyTranslateService, public session: SessionService, private bottomSheet: MatBottomSheet) { }

  ngOnInit() {
    this.stateMecanisme();
    this.stateAxe();
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
    const dialogRef = this.dialog.open(ModalComponent, {
      width: '80vw',
      disableClose: true,
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
    this.bottomSheet.open(DownloadSheetComponent, { data: {fileName, folder: 'examen'}});
  }


  stateMecanisme() {
    this.uow.recommendations.stateMecanisme().subscribe(r => {
      // console.log(r)
      r.epu.name = this.mytranslate.getObs('admin.home.ExamenPériodiqueuniversell');
      this.dataEpu.next(r.epu);

    });
  }

  stateAxe() {
    this.uow.axes.stateAxes().subscribe(r => {

      r = r.filter(e => e.name !== null);
      console.log(r);
      const barChartLabels = r.map(e => e.name);
      const barChartData = [
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement') },
        { data: [], label: this.mytranslate.get('admin.organe.list.Taux') },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé') },
      ];

      r.forEach(e => {
        barChartData[0].data.push(e.p);
        barChartData[1].data.push(e.t);
        barChartData[2].data.push(e.r);
      });
      // tslint:disable-next-line:max-line-length
      this.examenPageSubject.next({ barChartLabels, barChartData, title: this.mytranslate.get('admin.epu.list.Tauxderecommandationsparaxe') });
    });
  }

}

