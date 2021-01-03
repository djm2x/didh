import { Synthese } from './../../../../Models/models';
import { Component, OnInit, Inject, EventEmitter, Input } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Visite, Rapport } from 'src/app/Models/models';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { UowService } from 'src/app/services/uow.service';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.scss']
})
export class PopupComponent implements OnInit {
  myForm: FormGroup;
  o: Rapport;
  title = '';


  listSynthese: Synthese[] = [];
  eventToChild = new EventEmitter();
  // formData = new FormData();
  file: File;
  // progress: number;
  // message: any;
  filename = 'Choisie un rapport';
  iconFile = '';
  pieceJointe = '';
  pieceJointeToShow: string[] = [];
  pieceJointeToDelete: string[] = [];
  formData = new FormData();
  oneFile = true;
  isEdit = false;
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, private uow: UowService) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
    this.pieceJointe = this.o.pieceJointe;
    console.log(this.o)
    // this.filename = this.o.lienUpload === '' ? this.filename : this.o.lienUpload;
    this.createForm();
    if (this.title === 'edit') {
      this.isEdit = true;
      // const pieces = this.o.pieceJointe.split(';');
      // pieces.pop();
      // pieces.forEach(e => this.pieceJointeToShow.push(e));
      // this.pieceJointe = this.o.pieceJointe;
      // console.log(this.pieceJointeToShow);
      // this.pieceJointeToShow.push(`${f.lastModified}_${f.name};`);
      this.createForm();

    }
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      titre: [this.o.titre, Validators.required],
      dateDernierRapport: [this.o.dateDernierRapport, Validators.required],
      dateObservation: [this.o.dateObservation, Validators.required],
      dateProchaineRapport: [this.o.dateProchaineRapport, Validators.required],
      reference: [this.o.reference, Validators.required],
      idTraite: [this.o.idTraite],
      pieceJointe: [this.o.pieceJointe],
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: Rapport): void {
    o.dateDernierRapport = this.valideDate(o.dateDernierRapport);
    o.dateObservation = this.valideDate(o.dateObservation);
    o.dateProchaineRapport = this.valideDate(o.dateProchaineRapport);
    o.pieceJointe = this.pieceJointe;



    // console.log(this.listSynthese);
    const synthIds: number[] = [];



    if (!this.isEdit) {


      o.syntheses = null;
      this.uow.rapports.post(o).subscribe((r: any) => {
        this.listSynthese.map(e => {
          // get deleted items and make foreign key null

          e.idRapport = r.id;
          synthIds.push(e.id);
          // return e;
        });
        this.uow.syntheses.updateRange(this.listSynthese).subscribe(rr => {
          if (this.file) {
            const nameFile = `${this.file.lastModified}_${this.file.name}` as string;
            const formData = new FormData();
            formData.append(nameFile, this.file, nameFile);

            this.uow.rapports.uploadFiles(formData).subscribe(rs => {
              this.dialogRef.close('ok');
            });
          }
          this.dialogRef.close('ok');
        });
      });
    } else {
      console.log(this.listSynthese);

      this.listSynthese.map(e => {
        // get deleted items and make foreign key null

        e.idRapport = o.id;
        synthIds.push(e.id);
        // return e;
      });

      this.o.syntheses.map(syn => {
        if (!synthIds.includes(syn.id)  && synthIds.length !== 0) {
          syn.idRapport = null;
          this.listSynthese.push(syn);
        }
      });

      o.syntheses = null;

      this.uow.rapports.put(o.id, o).subscribe((r: any) => {
        console.log(this.listSynthese);
        this.uow.syntheses.updateRange(this.listSynthese).subscribe(rr => {

          if (this.file) {
            const nameFile = `${this.file.lastModified}_${this.file.name}` as string;
            const formData = new FormData();
            formData.append(nameFile, this.file, nameFile);
            this.uow.rapports.uploadFiles(formData).subscribe(rs => {
              this.uow.rapports.deleteFiles(this.pieceJointeToDelete, 'rapport').subscribe(() => {
                this.dialogRef.close('ok');
              });
            });
          } else {
            this.dialogRef.close('ok');
          }
        });
      });
    }


  }

  updateListSynthese(list: Synthese[]) {
    // console.log(list);
    this.listSynthese = list;
    // let i = 0;
    // let b = true;
    // this.listSynthese = this.listSynthese.filter(e => {
    //   if (e.id === i) {
    //     b = false;
    //   }
    //   i = e.id;
    //   return b;
    // });
    // console.log('>>>>>>>>>>>>>>>>>>');
    // console.log(this.listRecommendation);
  }

  valideDate(date: Date): Date {
    date = new Date(date);

    const hoursDiff = date.getHours() - date.getTimezoneOffset() / 60;
    const minutesDiff = (date.getHours() - date.getTimezoneOffset()) % 60;
    date.setHours(hoursDiff);
    date.setMinutes(minutesDiff);

    return date;
  }

  openInput(o/*: HTMLInputElement*/) {
    // console.log('>>>>>>>>>>>>>');
    o.click();
  }

  upload(files: FileList) {
    // console.log('>>>>>>>>>>>>>');
    // console.log(this.pieceJointe)
    if (this.oneFile) {
      this.file = files.item(0);
      this.pieceJointe = `${this.file.lastModified}_${this.file.name}`;
      this.o.pieceJointe = this.pieceJointe;
      // console.log(this.pieceJointe)
      // this.formData = new FormData();
      // this.formData.append(nameFile, file, nameFile);
      // this.pieceJointeToShow[0] = `${file.lastModified}_${file.name};`;
      // console.log('>>>>>>>>>>>>>');
      // console.log(file);
    } else {


      Array.from(files).forEach((file: File) => {
        const nameFile = `${file.lastModified}_${file.name}` as string;
        const exist = this.formData.has(`${file.lastModified}_${file.name}`) || this.pieceJointe.includes(nameFile) as boolean;

        if (!exist) {
          this.formData.append(nameFile, file, nameFile);
          this.pieceJointe += `${nameFile};`;
          this.pieceJointeToShow.push(`${file.lastModified}_${file.name};`);
          // console.log('>>>>>>>>>>>>>');
          // console.log(file);
        }


      });
    }
    // console.log(this.pieceJointe);

    // to delete
  }


  remove(nameFile: string) {
    if (this.oneFile) {
      this.pieceJointe = '';
      this.pieceJointeToDelete[0] = nameFile;
    } else {


      // this.pieceJointeToDelete.push(nameFile);
      // this.pieceJointeToShow = this.pieceJointeToShow.filter(e => e !== nameFile);
      // this.formData.delete(nameFile);
      // // this.files = this.files.splice(i, 1);
      // console.log(this.pieceJointe);
      // this.pieceJointe = this.pieceJointe.replace(`${nameFile};`, '');
      // console.log(this.pieceJointe);
      // // this.files = [];
      // // this.filename = 'Choisie un rapport';
      // // this.myForm.get('pieceJointe').setValue('');
      // // this.iconFile = '';
    }
  }

  resetForm() {
    this.o = new Rapport();
    this.createForm();
  }

  setIcon(filaName) {
    const i = filaName.lastIndexOf('.');
    const s = filaName.substring(i + 1);
    // console.log(s);
    return (s === 'pdf' || s === 'pdf;') ? 'assets/svg/pdf.svg' : 'assets/svg/word.svg';
  }

}
