import { SessionService } from './../../../shared/session.service';
import { Notification } from './../../../Models/models';
import { Component, OnInit, ViewChild, EventEmitter } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MatPaginator, MatSort, MatDialog } from '@angular/material';
import { UowService } from 'src/app/services/uow.service';
import { DeleteService } from '../../components/delete/delete.service';
import { merge } from 'rxjs';

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  { position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H' },
  { position: 2, name: 'Helium', weight: 4.0026, symbol: 'He' },
  { position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li' },
  { position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be' },
  { position: 5, name: 'Boron', weight: 10.811, symbol: 'B' },
  { position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C' },
  { position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N' },
  { position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O' },
  { position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F' },
  { position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne' },
];
@Component({
  selector: 'app-notification',
  templateUrl: './notification.component.html',
  styleUrls: ['./notification.component.scss']
})
export class NotificationComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;

  dataSource = [];
  columnDefs = [
    { columnDef: 'priorite', headName: '' },
    { columnDef: 'vu', headName: '' },
    { columnDef: 'date', headName: '' },
    { columnDef: 'message', headName: '' },
    // { columnDef: 'option', headName: '' },
  ].map(e => {
    e.headName = e.columnDef.toUpperCase();
    return e;
  });

  displayedColumns = this.columnDefs.map(e => e.columnDef);

  priorite = ['faible', 'normale', 'élevée', 'Haute'];
  color = ['', 'primary', 'accent', 'warn'];
  displayedColumns2: string[] = ['position', 'name', 'weight', 'symbol'];
  dataSource2 = ELEMENT_DATA;
  prioriteColor = (i) => {
    // console.log('>>>>>>>>>>>>> ', i)
    return this.color[i - 1];
  }

  constructor(
    private router: Router, private uow: UowService, private session: SessionService,
    public dialog: MatDialog, private mydialog: DeleteService,
  ) { }

  ngOnInit() {
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
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idOrganisme) {
    this.uow.notifications.getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme).subscribe(
      (r: any) => {
        console.log(r);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }

  openUrl(o: Notification) {
    console.log(o)
    o.vu = true;
    this.uow.notifications.put(o.id, o).subscribe(r => {
      o.tableConcerner = o.tableConcerner === 'recommandation' ? 'recommendation' : o.tableConcerner;
      o.tableConcerner = o.tableConcerner === 'traité' ? 'rapport' : o.tableConcerner;
      this.router.navigate([`/admin/${o.tableConcerner}/list`], {
        queryParams: {
          data: o.idConcerner
        },
        //  queryParamsHandling: 'merge',
      });
    });
  }

  // Evenement boutton modifier un utilisateur
  edit(o) {
    this.router.navigateByUrl('/admin/modify?id=' + o.id);
  }
  // Evenement boutton rechercher
  search() {
    this.update.next(true);
  }

  async delete(id) {
    const r = await this.mydialog.openDialog('Utilisateur').toPromise();
    if (r === 'ok') {
      this.uow.notifications.delete(id).subscribe(() => this.update.next(true));
    }
  }

}
