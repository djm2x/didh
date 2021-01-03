import { Rapport } from './../../../../../Models/models';
import { FormControl } from '@angular/forms';
import { Component, OnInit, ViewChild, EventEmitter, Output, Input } from '@angular/core';
import { merge } from 'rxjs';
import { UowService } from 'src/app/services/uow.service';
import { SelectionModel, SelectionChange } from '@angular/cdk/collections';
import { Organisme, Synthese } from 'src/app/Models/models';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

@Component({
  selector: 'app-synthese',
  templateUrl: './synthese.component.html',
  styleUrls: ['./synthese.component.scss']
})
export class SyntheseComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  @Output() eventToParent = new EventEmitter<any[]>();

  @Input() selectedList: Synthese[] = [];
  @Input() rapport: Rapport;
  @Input() isEdit: boolean;

  update = new EventEmitter();
  isLoadingResults = false;
  resultsLength = 0;
  isRateLimitReached = false;

  selectInput = new FormControl(0);
  dataSource = [];
  columnDefs = [
    { columnDef: 'select', headName: 'select' },
    { columnDef: 'code', headName: 'CODE' },
    { columnDef: 'detail', headName: 'DETAIL' },
  ];

  displayedColumns = this.columnDefs.map(e => e.columnDef);

  selection = new SelectionModel<Synthese>(true, []);
  constructor(private uow: UowService) { }

  ngOnInit() {
    // console.log(this.selection.hasValue());
    // console.log(this.isEdit);
    // if (this.isEdit) {
    //   const idCycle = this.selectedList ? this.selectedList[0].idCycle : 0;
    //   if (idCycle !== 0) {
    //     this.getPage(0, 10, 'id', 'desc', idCycle);
    //   }
    // }
    // console.log(this.rapport.syntheses);
    // this.rapport.map(r => {
    this.selectedList = this.rapport.syntheses;
    this.selectedList.forEach(row => {
      this.selection.select(row);
      // });


    });
    // this.isLoadingResults = false;
    this.getPage(0, 10, 'id', 'desc', this.rapport.id);

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
          this.rapport.id
        );
      }
    );
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idRapport) {
    this.isLoadingResults = true;
    this.uow.syntheses.getAllWithNoRapport(startIndex, pageSize, sortBy, sortDir, idRapport).subscribe(
      (r: any) => {
        // console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
        /*  this.selection.clear();
          this.selectedList.forEach(row => {
            this.selection.select(row);
          } );
  */

      }
    );
  }

  // selectChange(idCycle) {
  //   this.selectedList = [];
  //   this.getPage(0, 10, 'id', 'desc');
  // }

  isSelected(row): boolean {
    return this.selectedList.find(e => e.id === row.id) ? true : false;
  }

  check(r) {
    const i = this.selectedList.findIndex(o => r.id === o.id);
    const existe: boolean = i !== -1;
    if (!existe) {
      this.selectedList.push(r);
    }  else {
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
  checkboxLabel(row?: Synthese): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    // return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.id}`;
    return `${this.selectedList.find(e => e.id === row.id) ? 'deselect' : 'select'} row ${row.id}`;
  }

  subString(detail: string) {
    return detail.length > 1010 ? `${detail.substring(0, 1010)}...` : detail;
  }

}



