import { SessionService } from 'src/app/shared';
import { Component, OnInit, ViewChild, EventEmitter, Inject, OnDestroy } from '@angular/core';
import { merge, Subscription } from 'rxjs';
import { UpdateComponent } from './update/update.component';
import { UowService } from 'src/app/services/uow.service';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatDialog } from '@angular/material/dialog';
import { FormControl } from '@angular/forms';
import { startWith } from 'rxjs/operators';
import { DeleteService } from '../components/delete/delete.service';
import { Evenement } from 'src/app/Models/models';
import { DetailComponent } from './detail/detail.component';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-evenement',
  templateUrl: './evenement.component.html',
  styleUrls: ['./evenement.component.scss']
})
export class EvenementComponent implements OnInit, OnDestroy {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  // @ViewChild(MatSort, { static: true }) sort: MatSort;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;

  subs: Subscription[] = [];

  dataSource: Evenement[] = [];
  selectedList: Evenement[] = [];

  displayedColumns = ['select',  'categorie',  'title', 'date', 'option'];

  panelOpenState = false;

  title = new FormControl('');

  constructor(private uow: UowService, public dialog: MatDialog
    , private mydialog: DeleteService, @Inject('BASE_URL') private url: string 
    , public session: SessionService, public mytranslate: MyTranslateService) { }

  ngOnInit() {
    const sub = merge(...[/*this.sort.sortChange, */this.paginator.page, this.update]).pipe(startWith(null as any)).subscribe(
      r => {
        r === true ? this.paginator.pageIndex = 0 : r = r;
        !this.paginator.pageSize ? this.paginator.pageSize = 10 : r = r;
        const startIndex = this.paginator.pageIndex * this.paginator.pageSize;
        this.isLoadingResults = true;
        this.getPage(
          startIndex,
          this.paginator.pageSize,
          /*this.sort.active ? this.sort.active : */'id',
          /*this.sort.direction ? this.sort.direction : */'desc',
          this.title.value === '' ? '*' : this.title.value,

        );
      }
    );

    this.subs.push(sub);
  }

  reset() {
    this.title.setValue('');

    this.update.next(true);
  }

  formatDate(d1: string) {
    const d = new Date(d1);
    return {
      day: d.getDate().toString().length === 1 ? `0${d.getDate()}` : d.getDate(),
      month: this.mytranslate.langSync === 'fr' ? this.uow.monthsAlpha[d.getMonth()].name : this.uow.monthsAlpha[d.getMonth()].nameAr,
      year: d.getFullYear()
    }
  }

  detail(o: Evenement) {
    const dialogRef = this.dialog.open(DetailComponent, {
      width: '7100px',
      disableClose: true,
      data: { model: o, title: o.title }
    });

    return dialogRef.afterClosed();
  }

  // generateExcel() {
  //   this.excel.json_to_sheet(this.dataSource);
  // }

  search() {
    this.update.next(true);
  }

  getPage(startIndex, pageSize, sortBy, sortDir, title,) {
    const sub = this.uow.evenements.getAll(startIndex, pageSize, sortBy, sortDir,  title,).subscribe(
      (r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }
    );

    this.subs.push(sub);
  }

  openDialog(o: Evenement, text) {
    const dialogRef = this.dialog.open(UpdateComponent, {
      width: '750px',
      disableClose: true,
      data: { model: o, title: text },
      direction: this.mytranslate.langSync === 'fr' ? 'ltr' : 'rtl',
    });

    return dialogRef.afterClosed();
  }

  add() {
    this.openDialog(new Evenement(), this.mytranslate.get('admin.event.list.Ajouter_evènement')).subscribe(result => {
      if (result) {
        this.update.next(true);
      }
    });
  }

  edit(o: Evenement) {
    this.openDialog(o, this.mytranslate.get('admin.event.list.Modifier_evènement')).subscribe((result: Evenement) => {
      if (result) {
        this.update.next(true);
      }
    });
  }

  async delete(id: number) {
    const r = await this.mydialog.openDialog(this.mytranslate.get('admin.event.list.evènement')).toPromise();
    if (r === 'ok') {
      const sub = this.uow.evenements.delete(id).subscribe(() => this.update.next(true));

      this.subs.push(sub);
    }
  }

  displayImage(urlImage: string) {
    if (!urlImage) {
      return 'assets/404.jpg';
    }
    if (urlImage && urlImage.startsWith('http')) {
      return urlImage;
    }

    return `${this.url}/evenements/${urlImage.replace(';', '')}`;
  }

  imgError(img: any) {
    img.src = 'assets/404.jpg';
  }

  //check box
  //
  isSelected(row: Evenement): boolean {
    return this.selectedList.find(e => e.id === row.id) ? true : false;
  }

  check(row: Evenement) {
    const i = this.selectedList.findIndex(o => row.id === o.id);
    const existe: boolean = i !== -1;

    existe ? this.selectedList.splice(i, 1) : this.selectedList.push(row);
  }

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected(): boolean {
    const numSelected = this.selectedList.length;
    const numRows = this.dataSource.length;

    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ? this.selectedList = [] : this.selectedList = Array.from(this.dataSource);
  }

  async deleteList() {
    const r = await this.mydialog.openDialog('role').toPromise();
    if (r === 'ok') {
      const sub = this.uow.evenements.deleteRange(this.selectedList.map(e => e.id)).subscribe(() => {
        this.selectedList = [];
        this.update.next(true);
      });

      this.subs.push(sub);
    }
  }

  ngOnDestroy(): void {
    this.subs.forEach(e => {
      e.unsubscribe();
    });
  }

}

