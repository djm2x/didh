import { Examen } from './../../../Models/models';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
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
  o: Examen;
  title = '';

  folderToSaveInServer = 'examen';

  rapportMiParcoursTo = new Subject();
  rapportMiParcoursFrom = new Subject();
  //
  discoursTo = new Subject();
  discoursFrom = new Subject();
  //
  compilationHCDHTo = new Subject();
  compilationHCDHFrom = new Subject();
  //
  observationFinaleTo = new Subject();
  observationFinaleFrom = new Subject();
  //
  rapportNationalTo = new Subject();
  rapportNationalFrom = new Subject();
  //
  miseOeuvrePieceTo = new Subject();
  miseOeuvrePieceFrom = new Subject();
  //
  eventSubmitFromParent = new Subject();
  //
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, private uow: UowService) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
    // this.filename = this.o.lienUpload === '' ? this.filename : this.o.lienUpload;
    this.createForm();

    this.rapportNationalFrom.subscribe(r => this.myForm.get('rapportNational').setValue(r));
    this.compilationHCDHFrom.subscribe(r => this.myForm.get('compilationHCDH').setValue(r));
    this.observationFinaleFrom.subscribe(r => this.myForm.get('observationFinale').setValue(r));
    this.discoursFrom.subscribe(r => this.myForm.get('discours').setValue(r));
    this.rapportMiParcoursFrom.subscribe(r => this.myForm.get('rapportMiParcours').setValue(r));
    this.miseOeuvrePieceFrom.subscribe(r => this.myForm.get('miseOeuvrePiece').setValue(r));

    setTimeout(() => {
      this.miseOeuvrePieceTo.next(this.o.miseOeuvrePiece);
      this.rapportNationalTo.next(this.o.rapportNational);
      this.compilationHCDHTo.next(this.o.compilationHCDH);
      this.observationFinaleTo.next(this.o.observationFinale);
      this.rapportMiParcoursTo.next(this.o.rapportMiParcours);
      this.discoursTo.next(this.o.discours);
    }, 100);
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      libelle: [this.o.libelle, Validators.required],
      libelleAr: [this.o.libelleAr, Validators.required],
      rapportNational: [this.o.rapportNational],
      discours: [this.o.discours],
      compilationHCDH: [this.o.compilationHCDH],
      observationFinale: [this.o.observationFinale],
      rapportMiParcours: [this.o.rapportMiParcours],
      miseOeuvrePiece: [this.o.miseOeuvrePiece],
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: Examen): void {
    this.submit(o);
    // this.dialogRef.close({ model: o, file: this.file });
  }

  submit(o: Examen) {
    // o.rapportMiParcours =
    // return
    if (this.o.id === 0) {
      this.uow.examens.post(o).subscribe(async (r: Examen) => {
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
      this.uow.examens.put(o.id, o).subscribe(async r => {
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
    this.o = new Examen();
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
