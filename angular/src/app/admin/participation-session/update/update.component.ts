import { ParticipationSession } from './../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { UowService } from 'src/app/services/uow.service';
import { Visite } from 'src/app/Models/models';
import { Subject } from 'rxjs';
@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {
  myForm: FormGroup;
  o: ParticipationSession;
  title = '';

  folderToSaveInServer = 'participation';

  discoursTo = new Subject();
  discoursFrom = new Subject();
  //
  documentsTo = new Subject();
  documentsFrom = new Subject();
  //
  eventSubmitFromParent = new Subject();
  //
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, public uow: UowService) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
    // this.filename = this.o.lienUpload === '' ? this.filename : this.o.lienUpload;
    this.createForm();

    this.documentsFrom.subscribe(r => this.myForm.get('documents').setValue(r));
    this.discoursFrom.subscribe(r => this.myForm.get('discours').setValue(r));

    setTimeout(() => {
      this.documentsTo.next(this.o.documents);
      this.discoursTo.next(this.o.discours);
    }, 100);
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      session: [this.o.session, Validators.required],
      sessionAr: [this.o.sessionAr, Validators.required],
      discours: [this.o.discours],
      documents: [this.o.documents],
      annee: [this.o.annee],
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: ParticipationSession): void {
    this.submit(o);
    // this.dialogRef.close({ model: o, file: this.file });
  }

  submit(o: ParticipationSession) {
    // o.rapportMiParcours =
    // return
    if (this.o.id === 0) {
      this.uow.participations.post(o).subscribe(async (r: ParticipationSession) => {
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
      this.uow.participations.put(o.id, o).subscribe(async r => {
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
    this.o = new ParticipationSession();
    this.createForm();
  }

  // setIcon(filaName) {
  //   const i = filaName.lastIndexOf('.');
  //   const s = filaName.substring(i + 1);
  //   // // console.log(s);
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
