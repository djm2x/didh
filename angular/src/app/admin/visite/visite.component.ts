import { SessionService } from './../../shared/session.service';
import { Notification, Visite } from 'src/app/Models/models';
import { Component, OnInit, ViewChild, EventEmitter, Inject } from '@angular/core';
import { MatPaginator, MatSort, MatDialog } from '@angular/material';
import { merge } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { HttpEventType } from '@angular/common/http';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { ActivatedRoute } from '@angular/router';
import { DetailComponent } from './detail/detail.component';

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
    { columnDef: 'lienUpload', headName: 'Rapport de la visite' },
    // { columnDef: 'lienRapport', headName: 'LIEN EXTERNE' },
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
    , private snack: SnackbarService, @Inject('BASE_URL') public url: string
    , private route: ActivatedRoute, public session: SessionService) { }

  ngOnInit() {
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
  }

  openDialogDetail(o: any) {
    const dialogRef = this.dialog.open(DetailComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: 'Visite' }
    });

    return dialogRef.afterClosed();
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

  openDialog(o: Visite, text) {
    const dialogRef = this.dialog.open(UpdateComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: text }
    });

    return dialogRef.afterClosed();
  }

  add() {
    this.openDialog(new Visite(), 'Ajouter Procédure spéciale').subscribe(result => {
      if (result) {
        // then upload the visite object
        this.uow.visites.post(result.model).subscribe((r: Visite) => {
          // console.log(r);
          // upload file first
          console.log(result.file);
          if (!result.file) {
            this.update.next(true);
          } else {
            this.postFile(r, result.file);
          }

          const notif: Notification = {
            id: 0,
            date: new Date(),
            destinataire: '',
            idConcerner: r.id,
            idOrganisme: this.session.user.idOrganisme,
            message: 'Nouvelle Procédure spéciale a été ajouter',
            priorite: 1,
            tableConcerner: 'visite',
            vu: false
          };
          this.uow.notifications.post(notif).subscribe(n => {
            // this.router.navigateByUrl('/admin/recommendation/list');
          });
        });
      }
    });
  }

  edit(o: Visite) {
    this.openDialog(o, 'Modifier Procédure spéciale').subscribe((result: any) => {
      if (result) {
        console.log(result);
        //
        const visite = result.model as Visite;
        const file = result.file as File;
        if (file) {
          this.formData = new FormData();
          this.formData.append(`${file.lastModified}_${file.name}`, file);
          visite.lienUpload = `${file.lastModified}_${file.name}`;
          // delete old file if existe
          this.uow.files.deleteFile(visite.id, 'visite').subscribe();
          this.uow.visites.put(visite.id, visite).subscribe((r: Visite) => {
            // insert new file
            this.uow.files.postFile(this.formData).subscribe(() => this.update.next(true));
          });
        } else {
          // there no file to upload
          // just for checking if file is deleted and there is no upload
          if (visite.lienUpload === '') {
            this.uow.files.deleteFile(visite.id, 'visite').subscribe();
          }

          this.uow.visites.put(visite.id, visite).subscribe((r: Visite) => {
            this.update.next(true);
          });
        }

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
        this.uow.notifications.post(notif).subscribe(n => {
          // this.router.navigateByUrl('/admin/recommendation/list');
        });
      }
    });
  }

  async delete(o: Visite) {
    const r = await this.mydialog.openDialog('Procédure spéciale').toPromise();
    if (r === 'ok') {
      console.log(o.lienUpload);
      this.uow.files.deleteFiles([o.lienUpload], 'visite').subscribe(r => {
        this.uow.visites.delete(o.id).subscribe(() => this.update.next(true));
      });
    }
  }

  postFile(visite, file: File) {
    this.formData = new FormData();

    this.formData.append(`${file.lastModified}_${file.name}`, file);
    this.uow.files.postFile(this.formData).subscribe((event: any) => {
      if (event.type === HttpEventType.UploadProgress) {
        this.progress = Math.round(100 * event.loaded / event.total);
        console.log(this.progress);
      } else if (event.type === HttpEventType.Response) {
        this.message = event.body.toString();
        console.log(this.message);
        console.log(event);
      } else {
        visite.lienUpload = event.fileName; // `${visite.id}_${file.name}`;
        this.uow.visites.put(visite.id, visite).subscribe(rs => this.update.next(true));
      }
    });
  }

  download(o: Visite) {
    // const p =  this.uow.files.download(o.lienUpload).toPromise();
    // p.then().catch(e => console.warn(e));

    const url = `${this.url}/visite/${o.lienUpload}`;
    window.open(url);
  }

}
