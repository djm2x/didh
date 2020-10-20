import { Questionnaire } from './../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
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
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, public uow: UowService, public mytranslate: MyTranslateService) { }

  async ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;

    this.createForm();
    this.themes = await this.uow.themes.toPromise();

    if (this.o.id !== 0) {
      // const t = this.themes.find(e => e.name.includes(this.o.theme));
      // this.sousThemes = t ? t.sousThemes : [];

      this.selectChange(this.o.theme)
    }


    this.pieceJointeFrom.subscribe(r => this.myForm.get('pieceJointe').setValue(r));

    setTimeout(() => {
      this.pieceJointeTo.next(this.o.pieceJointe);
    }, 100);

  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      theme: [this.o.theme, Validators.required],
      sousTheme: [this.o.sousTheme],
      // themeAr: [this.o.themeAr],
      // sousThemeAr: [this.o.sousThemeAr],
      pieceJointe: [this.o.pieceJointe],
      reporter: [this.o.reporter],
      reporterAr: [this.o.reporterAr],
      annee: [this.o.annee],
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
