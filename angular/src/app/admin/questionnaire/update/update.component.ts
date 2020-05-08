import { Questionnaire } from './../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { UowService } from 'src/app/services/uow.service';
import { Visite } from 'src/app/Models/models';
import { Subject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
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
  themes: { name: string, sousThemes: string[] }[] = [];
  sousThemes = [];
  //
  eventSubmitFromParent = new Subject();
  //
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, private uow: UowService, private http: HttpClient) { }

  async ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;

    this.createForm();
    this.themes = await this.http.get<any[]>('assets/json/themes.json').toPromise();

    if (this.o.id !== 0 && this.o.sousTheme !== '') {
      const t = this.themes.find(e => e.name.includes(this.o.theme));
      this.sousThemes = t ? t.sousThemes : [];
      this.createForm();
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
      pieceJointe: [this.o.pieceJointe],
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: Questionnaire): void {
    this.submit(o);
    // this.dialogRef.close({ model: o, file: this.file });
  }

  selectChange(name: string) {
    this.sousThemes = this.themes.find(e => e.name.includes(name)).sousThemes;
  }

  submit(o: Questionnaire) {
    // o.rapportMiParcours =
    // return
    if (this.o.id === 0) {
      this.uow.questionnaires.post(o).subscribe(async (r: Questionnaire) => {
        this.eventSubmitFromParent.next(true);
        // const formData = new FormData();
        // if (this.rapportNational) {
        //   const nameFile = `${this.rapportNational.lastModified}_${this.rapportNational.name}`;
        //   formData.append(nameFile, this.rapportNational, nameFile);
        // }

        // if (this.observationFinale) {
        //   const nameFile = `${this.observationFinale.lastModified}_${this.observationFinale.name}`;
        //   formData.append(nameFile, this.observationFinale, nameFile);
        // }

        // if (formData) {
        //   await this.uow.files.uploadFiles(formData, 'examen').toPromise();
        // }
        this.dialogRef.close(true);

      });
    } else {
      this.uow.questionnaires.put(o.id, o).subscribe(async r => {
        this.eventSubmitFromParent.next(true);
        // const formData = new FormData();
        // if (this.rapportNational) {
        //   const nameFile = `${this.rapportNational.lastModified}_${this.rapportNational.name}`;
        //   formData.append(nameFile, this.rapportNational, nameFile);
        // }

        // if (this.observationFinale) {
        //   const nameFile = `${this.observationFinale.lastModified}_${this.observationFinale.name}`;
        //   formData.append(nameFile, this.observationFinale, nameFile);
        // }

        // if (formData) {
        //   await this.uow.files.uploadFiles(formData, 'examen').toPromise();
        //   await this.uow.files.deleteFiles(this.pieceJointeToDelete, 'examen').toPromise();
        // }

        this.dialogRef.close(true);
      });
    }


  }

  openInput(o/*: HTMLInputElement*/) {
    o.click();
  }



  resetForm() {
    this.o = new Questionnaire();
    this.createForm();
  }

  // setIcon(filaName) {
  //   const i = filaName.lastIndexOf('.');
  //   const s = filaName.substring(i + 1);
  //   // console.log(s);
  //   return (s === 'pdf' || s === 'pdf;') ? 'assets/svg/pdf.svg' : 'assets/svg/word.svg';
  // }

  // uploadRapportNational(files: FileList) {
  //   this.rapportNational = files.item(0);
  //   // this.pieceJointe = `${this.rapportNational.lastModified}_${this.rapportNational.name}`;
  //   if (this.o.rapportNational !== '') {
  //     this.pieceJointeToDelete.push(this.o.rapportNational)
  //   }
  //   this.o.rapportNational = `${this.rapportNational.lastModified}_${this.rapportNational.name}`;
  //   this.myForm.get('rapportNational').setValue(this.o.rapportNational);
  // }


  // removeRapportNational(nameFile) {
  //   this.o.rapportNational = '';
  //   this.rapportNational = null;
  //   this.pieceJointeToDelete.push(nameFile);
  //   this.myForm.get('rapportNational').setValue(this.o.rapportNational);
  // }

  // uploadObservationFinale(files: FileList) {
  //   this.observationFinale = files.item(0);
  //   // this.pieceJointe = `${this.observationFinale.lastModified}_${this.observationFinale.name}`;
  //   if (this.o.observationFinale !== '') {
  //     this.pieceJointeToDelete.push(this.o.observationFinale)
  //   }
  //   this.o.observationFinale = `${this.observationFinale.lastModified}_${this.observationFinale.name}`;
  //   this.myForm.get('observationFinale').setValue(this.o.observationFinale);
  // }

  // removeObservationFinale(nameFile) {
  //   this.o.observationFinale = '';
  //   this.observationFinale = null;
  //   this.pieceJointeToDelete.push(nameFile);
  //   this.myForm.get('observationFinale').setValue(this.o.observationFinale);
  // }

}
