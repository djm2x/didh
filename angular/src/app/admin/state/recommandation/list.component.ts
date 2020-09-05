import { Component, OnInit, ViewChild, EventEmitter, Input } from '@angular/core';
import { MatPaginator, MatSort, MatDialog, MatAutocompleteSelectedEvent, MatInput, MatBottomSheet } from '@angular/material';
import { merge, Observable, Subject } from 'rxjs';
import { UowService } from 'src/app/services/uow.service';
import { SnackbarService } from 'src/app/shared/snakebar.service';
import { Visite, Recommendation } from 'src/app/Models/models';
import { DeleteService } from '../../components/delete/delete.service';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { SessionService } from 'src/app/shared';
import { switchMap } from 'rxjs/operators';
import { DownloadSheetComponent } from 'src/app/manage-files/download-sheet/download-sheet.component';
import { MyTranslateService } from 'src/app/my.translate.service';
import { Model } from '../../recommendation/list/list.component';

@Component({
  selector: 'app-recomm',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  // @ViewChild('myAutocomplete', { static: true }) myAutocomplete: MatInput;
  update = new EventEmitter();
  isLoadingResults = true;
  resultsLength = 0;
  isRateLimitReached = false;
  dataSource = [];
  columnDefs = [
    { columnDef: 'codeRecommendation', headName: 'CODE' },
    { columnDef: 'nom', headName: 'INTITULE' },
    { columnDef: 'mecanisme', headName: 'mecanisme' },
    { columnDef: 'axe', headName: 'Axe' },
    { columnDef: 'sousAxe', headName: 'SOUS AXE' },
    { columnDef: 'organismes', headName: 'DEPARTEMENT' },
    { columnDef: 'etat', headName: 'ETAT DE MISE EN OEUVRE' },
    { columnDef: 'observation', headName: '' },
    { columnDef: 'complement', headName: '' },
  ].map(e => {
    e.headName = e.headName === '' ? e.columnDef.toUpperCase() : e.headName.toUpperCase();
    return e;
  });
  //
  displayedColumns = this.columnDefs.map(e => e.columnDef);

  @Input() fromParent = new Subject<Model>();

  constructor(private uow: UowService, public session: SessionService) { }

  ngOnInit() {
    this.isLoadingResults = false;
    // this.searchAndGet(this.o);
    this.fromParent.subscribe(o => {
      o.idOrganisme = this.session.isPointFocal || this.session.isProprietaire ? this.session.user.idOrganisme : o.idOrganisme;

      o.startIndex = 0;
      o.pageSize = 10;
      o.sortBy = 'id';
      o.sortDir = 'desc';
      o.nom = '';
      o.idPays = 0;

      console.log(o.mecanisme)

      this.uow.recommendations.searchAndGet(o).subscribe((r: any) => {
        console.log(r.list);
        this.dataSource = r.list;
        this.resultsLength = r.count;
        this.isLoadingResults = false;
      }, e => this.isLoadingResults = false,
      );
    }
    );
  }


}


