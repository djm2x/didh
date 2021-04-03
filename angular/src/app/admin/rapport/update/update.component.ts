import { SnackBarService } from './../../../loader/snack-bar.service';
import { SessionService } from './../../../shared/session.service';
import { Component, OnInit, Input, EventEmitter, ɵConsole, Inject } from '@angular/core';
import { Validators, FormGroup, FormBuilder } from '@angular/forms';
import { Traite, Rapport } from 'src/app/Models/models';
import { ActivatedRoute, Router } from '@angular/router';
import { UowService } from 'src/app/services/uow.service';
import { map } from 'rxjs/operators';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {

  public myForm: FormGroup;
  o = new Traite();
  id = 0;
  // title = typeof (Rapport).name;


  folderToSaveInServer = 'traite';

  conventionPieceTo = new Subject();
  conventionPieceFrom = new Subject();
  //
  discoursTo = new Subject();
  discoursFrom = new Subject();

  observationPieceTo = new Subject();
  observationPieceFrom = new Subject();
  //
  miseOeuvrePieceTo = new Subject();
  miseOeuvrePieceFrom = new Subject();
  //
  analytiquePieceTo = new Subject();
  analytiquePieceFrom = new Subject();
  //
  rapportParallelePieceTo = new Subject();
  rapportParallelePieceFrom = new Subject();
  //
  rapportINDHTo = new Subject();
  rapportINDHFrom = new Subject();
  //
  avisPositionTo = new Subject();
  avisPositionFrom = new Subject();

  eventSubmitFromParent = new Subject();

  constructor(private route: ActivatedRoute, private snack: SnackBarService
    , private uow: UowService, private fb: FormBuilder, private session: SessionService
    ) { }

  ngOnInit() {
    this.createForm();
    this.id = +this.route.snapshot.paramMap.get('id');
    if (this.id !== 0) {
      this.uow.traites.getOne(this.id).subscribe(r => {
        this.o = r as any;
        // this.rapportsToChild.next(this.o.rapports);
        // console.log(this.o)
        // const pieces = this.o.pieceJointe.split(';');
        // pieces.pop();
        // pieces.forEach(e => this.pieceJointeToShow.push(e));
        // this.pieceJointe = this.o.pieceJointe;
        // // console.log(this.pieceJointeToShow);
        // this.pieceJointeToShow.push(`${f.lastModified}_${f.name};`);
        this.createForm();

        setTimeout(() => {
          this.discoursTo.next(this.o.discours);
          this.rapportParallelePieceTo.next(this.o.rapportParallelePiece);
          this.conventionPieceTo.next(this.o.conventionPiece);
          this.observationPieceTo.next(this.o.observationPiece);
          this.miseOeuvrePieceTo.next(this.o.miseOeuvrePiece);
          this.analytiquePieceTo.next(this.o.analytiquePiece);
          this.rapportINDHTo.next(this.o.rapportINDH);
          this.avisPositionTo.next(this.o.avisPosition);
        }, 100);
      });
    }

    this.rapportParallelePieceFrom.subscribe(r => this.myForm.get('rapportParallelePiece').setValue(r));
    this.conventionPieceFrom.subscribe(r => this.myForm.get('conventionPiece').setValue(r));
    this.discoursFrom.subscribe(r => this.myForm.get('discours').setValue(r));
    this.observationPieceFrom.subscribe(r => this.myForm.get('observationPiece').setValue(r));
    this.miseOeuvrePieceFrom.subscribe(r => this.myForm.get('miseOeuvrePiece').setValue(r));
    this.analytiquePieceFrom.subscribe(r => this.myForm.get('analytiquePiece').setValue(r));
    this.rapportINDHFrom.subscribe(r => this.myForm.get('rapportINDH').setValue(r));
    this.avisPositionFrom.subscribe(r => this.myForm.get('avisPosition').setValue(r));
    // this.dataFromChild.subscribe((r: { datasource: any[], file: File, rapportToDelete: any[] }) => {
    //   this.rapports = r.datasource;
    //   if (r.file) {
    //     // console.log(r.file)
    //     const nameFile = `${r.file.lastModified}_${r.file.name}` as string;
    //     this.formData.append(nameFile, r.file, nameFile);
    //   }

    //   this.rapportToDelete = r.rapportToDelete;
    //   this.pieceJointeToDelete = this.rapportToDelete.map((e: Rapport) => e.pieceJointe);
    //   // // console.log('>>>>>>>>>>>>>>>>>>>>>');
    //   // // console.log(this.rapports);
    // });


  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      nom: [this.o.nom, Validators.required],
      nomAr: [this.o.nomAr, Validators.required],
      discours: [this.o.discours],
      dateSignature: [this.o.dateSignature, Validators.required],
      dateRatification: [this.o.dateRatification, Validators.required],
      conventionPiece: [this.o.conventionPiece],
      observationPiece: [this.o.observationPiece],
      miseOeuvrePiece: [this.o.miseOeuvrePiece],
      analytiquePiece: [this.o.analytiquePiece],
      rapportParallelePiece: [this.o.rapportParallelePiece],
      rapportINDH: [this.o.rapportINDH],
      avisPosition: [this.o.avisPosition],
    });
  }

  submit(o: Traite) {
    o.dateRatification = this.valideDate(o.dateRatification);
    o.dateSignature = this.valideDate(o.dateSignature);
    // o.rapports = this.rapports;
    o.idUser = this.session.user.id;
    if (this.id === 0) {
      this.uow.traites.post(o).subscribe(async (r: Traite) => {
        this.eventSubmitFromParent.next(true);
        // this.uow.rapports.uploadFiles(this.formData).subscribe(rs => {
        this.o = r;
        // const notif: any = {
        //   id: 0,
        //   date: new Date(),
        //   destinataire: '',
        //   idConcerner: r.id,
        //   idOrganisme: this.session.user.idOrganisme,
        //   message: 'Nouveau traité a été ajoutée',
        //   priorite: 1,
        //   tableConcerner: 'traite',
        //   vu: false
        // };
        // this.uow.notifications.post(notif).subscribe(n => {
        //   // this.router.navigateByUrl('/admin/rapport/list');
        // });
        // this.snack.notifyOk('Nouveau traité a été ajoutée');


        // const formData = new FormData();
        // if (this.conventionPiece) {
        //   const nameFile = `${this.conventionPiece.lastModified}_${this.conventionPiece.name}`;
        //   formData.append(nameFile, this.conventionPiece, nameFile);
        // }

        // if (this.miseOeuvrePiece) {
        //   const nameFile = `${this.miseOeuvrePiece.lastModified}_${this.miseOeuvrePiece.name}`;
        //   formData.append(nameFile, this.miseOeuvrePiece, nameFile);
        // }

        // if (this.observationPiece) {
        //   const nameFile = `${this.observationPiece.lastModified}_${this.observationPiece.name}`;
        //   formData.append(nameFile, this.observationPiece, nameFile);
        // }

        // if (formData) {
        //   await this.uow.files.uploadFiles(formData, 'traite').toPromise();
        // }

      });
    } else {
      // (o as any).rapportToDelete = this.rapportToDelete;
      this.uow.traites.put(o.id, o).subscribe(async r => {
        this.eventSubmitFromParent.next(true);
        // this.uow.rapports.uploadFiles(this.formData).subscribe(rs => {
        //   this.uow.rapports.deleteFiles(this.pieceJointeToDelete, 'rapport').subscribe(() => {
        const notif: any = {
          id: 0,
          date: new Date(),
          destinataire: '',
          idConcerner: o.id,
          idOrganisme: this.session.user.idOrganisme,
          message: 'Le traité a été modifié',
          priorite: 1,
          tableConcerner: 'traite',
          vu: false
        };

        // this.uow.notifications.post(notif).subscribe(n => {});

        // const formData = new FormData();
        // if (this.conventionPiece) {
        //   const nameFile = `${this.conventionPiece.lastModified}_${this.conventionPiece.name}`;
        //   formData.append(nameFile, this.conventionPiece, nameFile);
        // }

        // if (this.miseOeuvrePiece) {
        //   const nameFile = `${this.miseOeuvrePiece.lastModified}_${this.miseOeuvrePiece.name}`;
        //   formData.append(nameFile, this.miseOeuvrePiece, nameFile);
        // }

        // if (this.observationPiece) {
        //   const nameFile = `${this.observationPiece.lastModified}_${this.observationPiece.name}`;
        //   formData.append(nameFile, this.observationPiece, nameFile);
        // }

        // // // console.log(this.conventionPiece)
        // // // console.log(this.miseOeuvrePiece)
        // // // console.log(this.observationPiece)

        // if (formData) {
        //   await this.uow.files.uploadFiles(formData, 'traite').toPromise();
        //   await this.uow.rapports.deleteFiles(this.pieceJointeToDelete, 'traite').toPromise();
        // }
      });
    }
  }

  reset() {
    this.o = new Traite();
    this.createForm();
  }

  valideDate(date: Date): Date {
    date = new Date(date);

    const hoursDiff = date.getHours() - date.getTimezoneOffset() / 60;
    const minutesDiff = (date.getHours() - date.getTimezoneOffset()) % 60;
    date.setHours(hoursDiff);
    date.setMinutes(minutesDiff);

    return date;
  }

  // openInput(o/*: HTMLInputElement*/) {
  //   // // console.log('>>>>>>>>>>>>>');
  //   o.click();
  // }

  // uploadConvention(files: FileList) {
  //   this.conventionPiece = files.item(0);
  //   // this.pieceJointe = `${this.conventionPiece.lastModified}_${this.conventionPiece.name}`;
  //   if (this.o.conventionPiece !== '') {
  //     this.pieceJointeToDelete.push(this.o.conventionPiece);
  //   }
  //   this.o.conventionPiece = `${this.conventionPiece.lastModified}_${this.conventionPiece.name}`;

  //   this.myForm.get('conventionPiece').setValue(this.o.conventionPiece);
  // }


  // removeConvention(nameFile) {
  //   this.o.conventionPiece = '';
  //   this.conventionPiece = null;
  //   this.pieceJointeToDelete.push(nameFile);
  //   this.myForm.get('conventionPiece').setValue(this.o.conventionPiece);
  // }

  // uploadMiseOeuvre(files: FileList) {
  //   this.miseOeuvrePiece = files.item(0);
  //   // this.pieceJointe = `${this.miseOeuvrePiece.lastModified}_${this.miseOeuvrePiece.name}`;
  //   if (this.o.miseOeuvrePiece !== '') {
  //     this.pieceJointeToDelete.push(this.o.miseOeuvrePiece)
  //   }
  //   this.o.miseOeuvrePiece = `${this.miseOeuvrePiece.lastModified}_${this.miseOeuvrePiece.name}`;
  //   this.myForm.get('miseOeuvrePiece').setValue(this.o.miseOeuvrePiece);
  // }

  // removeMiseOeuvre(nameFile) {
  //   this.o.miseOeuvrePiece = '';
  //   this.miseOeuvrePiece = null;
  //   this.pieceJointeToDelete.push(nameFile);
  //   this.myForm.get('miseOeuvrePiece').setValue(this.o.miseOeuvrePiece);
  // }

  // uploadObservation(files: FileList) {
  //   this.observationPiece = files.item(0);
  //   // this.pieceJointe = `${this.observationPiece.lastModified}_${this.observationPiece.name}`;
  //   if (this.o.observationPiece !== '') {
  //     this.pieceJointeToDelete.push(this.o.observationPiece)
  //   }
  //   this.o.observationPiece = `${this.observationPiece.lastModified}_${this.observationPiece.name}`;
  //   this.myForm.get('observationPiece').setValue(this.o.observationPiece);
  // }

  // removeObservation(nameFile) {
  //   this.o.observationPiece = '';
  //   this.observationPiece = null;
  //   this.pieceJointeToDelete.push(nameFile);
  //   this.myForm.get('observationPiece').setValue(this.o.observationPiece);
  // }



  // // resetForm() {
  // //   this.o = new FicheSynthese();
  // //   this.createForm();
  // // }

  // setIcon(filaName) {
  //   const i = filaName.lastIndexOf('.');
  //   const s = filaName.substring(i + 1);
  //   // // console.log(s);
  //   return (s === 'pdf' || s === 'pdf;') ? 'assets/svg/pdf.svg' : 'assets/svg/word.svg';
  // }

}

