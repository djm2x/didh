import { Component, OnInit, ViewChild, EventEmitter, Output, Input } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatAutocompleteSelectedEvent } from '@angular/material';
import { merge, Observable } from 'rxjs';
import { UowService } from 'src/app/services/uow.service';
import { SelectionModel, SelectionChange } from '@angular/cdk/collections';
import { Organisme } from 'src/app/Models/models';
import { FormControl } from '@angular/forms';
import { switchMap } from 'rxjs/operators';
import { SessionService } from 'src/app/shared';

@Component({
  selector: 'app-organismes',
  templateUrl: './organismes.component.html',
  styleUrls: ['./organismes.component.scss']
})
export class OrganismesComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  @Output() eventToParent = new EventEmitter<any[]>();

  @Input() selectedList: Organisme[] = [];
  @Input() private listFromParent = new EventEmitter();
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;

  dataSource = [];
  columnDefs = [
    { columnDef: 'select', headName: 'select' },
    { columnDef: 'label', headName: 'ORGANISMES' },
    { columnDef: 'adresse', headName: 'ADRESSE' },
    // { columnDef: 'tel', headName: 'TEL' },
    // { columnDef: 'option', headName: 'OPTION' },
  ];

  displayedColumns = this.columnDefs.map(e => e.columnDef);

  selection = new SelectionModel<Organisme>(true, []);
  // filter
  myAuto = new FormControl('');
  filteredOptions: Observable<any>;

  idOrganisme = 0;

  constructor(private uow: UowService, private session: SessionService) { }

  ngOnInit() {
    // console.log(this.selection.hasValue());
    // console.log(this.isAllSelected());
    this.listFromParent.subscribe(r => {
      this.selectedList = r;
      this.selectedList.forEach(row => {
        this.selection.select(row);
      });
    });

    this.getPage(0, 5, 'id', 'desc', this.idOrganisme);

    merge(...[this.sort.sortChange, this.paginator.page, this.update]).subscribe(
      r => {
        r === true ? this.paginator.pageIndex = 0 : r = r;
        !this.paginator.pageSize ? this.paginator.pageSize = 5 : r = r;
        const startIndex = this.paginator.pageIndex * this.paginator.pageSize;
        this.isLoadingResults = true;
        this.getPage(
          startIndex,
          this.paginator.pageSize,
          this.sort.active ? this.sort.active : 'id',
          this.sort.direction ? this.sort.direction : 'desc',
          this.idOrganisme
        );
      }
    );

    this.autoComplete();
  }

  get isAdmin() {
    return this.session.isAdmin;
  }

  autoComplete() {
    this.filteredOptions = this.myAuto.valueChanges.pipe(
      // startWith(''),
      switchMap((value: string) => value.length > 1 ? this.uow.organismes.autocompletePost('label', value) : []),
      // map(r => r)
    );
  }

  selected(event: MatAutocompleteSelectedEvent): void {
    const o = event.option.value as any;
    console.log(o);
    this.idOrganisme = o.id;
    this.update.next(true);
    // this.myAuto.setValue(o.label);
    // (this.myForm.get('idOrganisme') as FormControl).setValue(o.id);
  }

  clear() {
    this.myAuto.setValue({ label: '' });
    this.idOrganisme = 0;
    this.update.next(true);
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idOrganisme) {
    this.uow.organismes.getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme).subscribe(
      (r: any) => {
        // console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
        //
        // this.selection.clear();
        // this.selectedList.forEach(row => {
        //   this.selection.select(row);
        // } );
      }
    );
  }

  isSelected(row): boolean {
    return this.selectedList.find(e => e.id === row.id) ? true : false;
  }

  check(r) {
    const i = this.selectedList.findIndex(o => r.id === o.id);
    const existe: boolean = i !== -1;
    if (!existe) {
      this.selectedList.push(r);
    } else {
      this.selectedList.splice(i, 1);
    }
    this.eventToParent.next(this.selectedList);
  }

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.paginator.pageSize;
    // console.log(numSelected, numRows)
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ?
      this.selection.clear() :
      this.dataSource.forEach(row => this.selection.select(row));
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: Organisme): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    // return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.id}`;
    return `${this.selectedList.find(e => e.id === row.id) ? 'deselect' : 'select'} row ${row.id}`;
  }

}
