import { Synthese, SyntheseRecommandation } from './../../../../Models/models';
import { FormControl } from '@angular/forms';
import { Component, OnInit, ViewChild, EventEmitter, Output, Input } from '@angular/core';
import { MatPaginator, MatSort, MatDialog } from '@angular/material';
import { merge } from 'rxjs';
import { UowService } from 'src/app/services/uow.service';
import { SelectionModel, SelectionChange } from '@angular/cdk/collections';
import { Recommendation } from 'src/app/Models/models';
import { TabNavigationService } from '../tab-navigation.service';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-recommendations',
  templateUrl: './recommendations.component.html',
  styleUrls: ['./recommendations.component.scss']
})
export class RecommendationsComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  @Output() eventToParent = new EventEmitter<any[]>();

  @Input() selectedList: Recommendation[] = [];
  todeleteList: SyntheseRecommandation[] = [];
  @Input() listFromParent: Recommendation[] = [];
  @Input() isEdit: boolean;
  update = new EventEmitter();
  isLoadingResults = false;
  resultsLength = 0;
  isRateLimitReached = false;

  cycles = this.uow.cycles.get();
  visites = this.uow.visites.get();
  organes = this.uow.organes.get();

  mecanisme = '';
  selectInput = new FormControl(0);
  idVisite = new FormControl(0);
  idCycle = new FormControl(0);
  idOrgane = new FormControl(0);
  //
  idAxe = new FormControl(0);
  idSousAxe = new FormControl(0);
  //
  dataSource = [];
  columnDefs = [
    { columnDef: 'select', headName: 'select' },
    { columnDef: 'nom', headName: 'RECOMMENDATION' },
    // { columnDef: 'mecanisme', headName: 'MECANISME' },
    // { columnDef: 'tel', headName: 'TEL' },
    // { columnDef: 'option', headName: 'OPTION' },
  ];
  axes = this.uow.axes.get();
  sousAxes = [];
  mecanismes = this.uow.mecanismes;
  @Input() synthese = new Synthese();
  displayedColumns = this.columnDefs.map(e => e.columnDef);
  synRecm: SyntheseRecommandation[] = [];
  selection = new SelectionModel<Recommendation>(true, []);
  constructor(private uow: UowService, private navTab: TabNavigationService
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {
    // console.log(this.selection.hasValue());
    // console.log(this.isEdit);
    // if (this.isEdit) {
    //   const idOrganisme = this.selectedList ? this.selectedList[0].idOrganisme : 0;
    //   if (idOrganisme !== 0) {
    //     this.getPage(0, 10, 'id', 'desc', idOrganisme);
    //   }
    // }
    this.uow.recommendations.getByIdSynthese(this.synthese.id).subscribe(r => {
      this.selectedList = r as any[];
      // console.log(this.selectedList)
      this.selectedList.forEach(row => {
        this.todeleteList.push({ idRecommandation: row.id, idSynthese: this.synthese.id } as any);
        this.selection.select(row);
      });
    });

    // this.selectedList = [];


    if (this.synthese.id !== 0) {
      this.isEdit = true;
      // const mecanisme = this.selectedList[0] ? this.selectedList[0].mecanisme : '';
      // console.log('>>>>>>>>>>>>>> : ', this.selectedList[0]);
      // if (mecanisme !== '') {
      //   this.mecanisme = mecanisme;
      //   this.selectInput.setValue(mecanisme);
      //   this.getPage(0, 10, 'id', 'desc', mecanisme);
      // }
    }
    // this.isLoadingResults = false;
    // this.getPage(0, 10, 'id', 'desc', this.idOrganisme);

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
          this.idCycle ? this.idCycle.value : 0,
          this.idOrgane ? this.idOrgane.value : 0,
          this.idVisite ? this.idVisite.value : 0,
          this.idAxe ? this.idAxe.value : 0,
          this.idSousAxe ? this.idSousAxe.value : 0,
        );
      }
    );
  }

  axeChange(idAxe: number) {
    this.uow.sousAxes.getByIdAxe(idAxe).subscribe(r => {
      this.sousAxes = r as any[];
    });
  }

  getPage(startIndex, pageSize, sortBy, sortDir, idCycle, idOrgane, idVisite, idAxe, idSousAxe) {
    this.isLoadingResults = true;
    this.uow.recommendations.getAllForSynthese(
      startIndex, pageSize, sortBy, sortDir, idCycle, idOrgane, idVisite, idAxe, idSousAxe).subscribe(
        (r: any) => {
          console.log(r.list);
          this.dataSource = r.list;
          this.resultsLength = r.count;
          this.isLoadingResults = false;


        }
      );
  }

  submit() {
    this.synRecm = [];
    this.selectedList.map(r => {
      this.synRecm.push({ idRecommandation: r.id, idSynthese: this.synthese.id } as any);
    });
    // console.log('listRecommendation', this.selectedList, 'this.o.recommendations', this.o.recommendations)
    console.log(this.todeleteList, this.synRecm);
    this.uow.syntheseRecommandations.putRange(this.todeleteList, this.synRecm).subscribe(e => {
      // this.navTab.navigateTo.next(2);
      this.todeleteList = this.synRecm;
    });
  }

  selectMecanismeChange(e) {
    // this.idOrganisme = idOrganisme;
    // this.selectedList = [];
    this.idVisite.setValue(null);
    this.idCycle.setValue(null);
    this.idOrgane.setValue(null);
    // this.getPage(0, 10, 'id', 'desc', mecanisme);
  }

  selectChange(id) {
    // console.log(this.idCycle.value, this.idOrgane.value, this.idVisite.value);

  }

  search() {
    this.getPage(0, 10, 'id', 'desc',
      this.idCycle.value ? this.idCycle.value : 0,
      this.idOrgane.value ? this.idOrgane.value : 0,
      this.idVisite.value ? this.idVisite.value : 0,
      this.idAxe.value ? this.idAxe.value : 0,
      this.idSousAxe.value ? this.idSousAxe.value : 0);
  }

  // reset() {
  //   this.getPage(0, 10, 'id', 'desc', 0, 0, 0, 0, 0);
  // }

  isSelected(row): boolean {
    // console.log(this.selectedList)
    // this.selectedList.forEach(e => console.log(+e.id, +row.id))
    // console.log(this.selectedList.find(e => +e.id === +row.id) ? true : false);
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
    // console.log(this.todeleteList);
    // this.eventToParent.next(this.selectedList);
  }

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selectedList.length;
    const numRows = this.paginator.pageSize;
    // console.log(numSelected, numRows)
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    if (this.isAllSelected()) {
      this.selectedList = [];
    } else {
      this.selectedList = [];
      this.dataSource.forEach(row => this.selectedList.push(row));
    }
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: Recommendation): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    // return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.id}`;
    return `${this.selectedList.find(e => e.id === row.id) ? 'deselect' : 'select'} row ${row.id}`;
  }
  //
  get cycleActive() {
    return this.selectInput.value === 'Examen périodique universal';
  }

  get visiteActive() {
    return this.selectInput.value === 'Procédure spéciale';
  }

  get organeActive() {
    return this.selectInput.value === 'Organes de traités';
  }

}
