import { Questionnaire } from './../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { UowService } from 'src/app/services/uow.service';
import { Visite } from 'src/app/Models/models';
import { Subject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { MyTranslateService } from 'src/app/my.translate.service';
@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {
  myForm: FormGroup;
  o: Questionnaire;
  title = '';

  folderToSaveInServer = 'questionnaire';

  pieceJointeTo = new Subject();
  pieceJointeFrom = new Subject();
  //
  themes: {
    id: number
    name: string,
    nameAr: string,
    sousThemes: {
      id: number
      name: string,
      nameAr: string,
    }[]
  }[] = [];
  sousThemes: {
    id: number
    name: string,
    nameAr: string,
  }[] = [];
  //
  eventSubmitFromParent = new Subject();
  //

  axes = this.uow.axes.get();
  sousAxes = [];

  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, public uow: UowService, public mytranslate: MyTranslateService) { }

  async ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;

    this.createForm();
    this.themes = await this.uow.themes.toPromise();

    if (this.o.id !== 0) {
      this.uow.sousAxes.get().subscribe(r => this.sousAxes = r);

      // this.selectChange(this.o.theme)
    }


    this.pieceJointeFrom.subscribe(r => this.myForm.get('pieceJointe').setValue(r));

    setTimeout(() => {
      this.pieceJointeTo.next(this.o.pieceJointe);
    }, 100);

  }

  axeChange(idAxe: number) {
    this.uow.sousAxes.getByIdAxe(idAxe).subscribe(r => {
      this.sousAxes = r as any[];
    });
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      theme: [this.o.theme],
      sousTheme: [this.o.sousTheme],
      idAxe: [this.o.idAxe, Validators.required],
      idSousAxe: [this.o.idSousAxe],
      pieceJointe: [this.o.pieceJointe],
      reporter: [this.o.reporter],
      reporterAr: [this.o.reporterAr],
      annee: [this.o.annee, Validators.required],
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: Questionnaire): void {
    this.submit(o);
    // this.dialogRef.close({ model: o, file: this.file });
  }

  selectChange(id: number) {
    this.sousThemes = this.themes.find(e => e.id === id).sousThemes;
  }

  submit(o: Questionnaire) {
    // o.rapportMiParcours =
    // return
    if (this.o.id === 0) {
      this.uow.questionnaires.post(o).subscribe(async (r: Questionnaire) => {
        this.eventSubmitFromParent.next(true);
        this.dialogRef.close(true);

      });
    } else {
      this.uow.questionnaires.put(o.id, o).subscribe(async r => {
        this.eventSubmitFromParent.next(true);

        this.dialogRef.close(true);
      });
    }
  }

  resetForm() {
    this.o = new Questionnaire();
    this.createForm();
  }

}
