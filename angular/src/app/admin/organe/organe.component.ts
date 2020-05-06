import { Component, OnInit, ViewChild, EventEmitter } from '@angular/core';
import { MatPaginator, MatSort, MatDialog } from '@angular/material';
import { merge } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { DeleteService } from '../components/delete/delete.service';
import { UowService } from 'src/app/services/uow.service';
import { Organe } from 'src/app/Models/models';
@Component({
  selector: 'app-organe',
  templateUrl: './organe.component.html',
  styleUrls: ['./organe.component.scss']
})
export class OrganeComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;

  dataSource = [];
  columnDefs = [
    { columnDef: 'label', headName: 'NOM' },
    { columnDef: 'option', headName: 'OPTION' },
  ];

  displayedColumns = this.columnDefs.map(e => e.columnDef);

  constructor(private uow: UowService, public dialog: MatDialog, private mydialog: DeleteService, ) { }

  ngOnInit() {
    this.getPage(0, 10, 'id', 'desc');
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
    this.uow.organes.getList(startIndex, pageSize, sortBy, sortDir).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );
  }

  openDialog(o: Organe, text) {
    const dialogRef = this.dialog.open(UpdateComponent, {
      width: '750px',
      disableClose: true,
      data: { model: o, title: text }
    });

    return dialogRef.afterClosed();
  }

  add() {
    this.openDialog(new Organe(), 'Ajouter organe').subscribe(result => {
      if (result) {
        this.uow.organes.post(result).subscribe(
          r => {
            this.update.next(true);
          }
        );
      }
    });
  }

  edit(o: Organe) {
    this.openDialog(o, 'Modifier organe').subscribe((result: Organe) => {
      if (result) {
        this.uow.organes.put(result.id, result).subscribe(
          r => {
            this.update.next(true);
          }
        );
      }
    });
  }

  async delete(id: number) {
    const r = await this.mydialog.openDialog('organe').toPromise();
    if (r === 'ok') {
      this.uow.organes.delete(id).subscribe(() => this.update.next(true));
    }
  }

}

