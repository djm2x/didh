import { FicheSynthese } from './../../../../../Models/models';
import { Component, OnInit, Inject, EventEmitter, Input } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { Visite, Rapport } from 'src/app/Models/models';
import { MatDialogRef, MAT_DIALOG_DATA, MatAutocompleteSelectedEvent } from '@angular/material';
import { UowService } from 'src/app/services/uow.service';
import { Observable } from 'rxjs';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.scss']
})
export class PopupComponent implements OnInit {
  myForm: FormGroup;
  o: FicheSynthese;
  title = '';

  file: File;
  formData = new FormData();
  // progress: number;
  // message: any;
  filename = 'Choisie un rapport';
  iconFile = '';
  pieceJointe = '';
  pieceJointeToShow: string[] = [];
  pieceJointeToDelete: string[] = [];
  oneFile = true;
  isEdit = false;
  organismes = this.uow.organismes.get();

  myAuto = new FormControl('');
  filteredOptions: Observable<any>;
  constructor(public dialogRef: MatDialogRef<any>, @Inject(MAT_DIALOG_DATA) public data: any
    , private fb: FormBuilder, private uow: UowService) { }

  ngOnInit() {
    this.o = this.data.model;
    this.title = this.data.title;
    this.pieceJointe = this.o.ficheUrl;
    console.log(this.o)
    // this.filename = this.o.lienUpload === '' ? this.filename : this.o.lienUpload;
    this.createForm();
    if (this.title === 'edit') {
      this.isEdit = true;
      this.myAuto.setValue(this.o.organisme.label);
      // const pieces = this.o.pieceJointe.split(';');
      // pieces.pop();
      // pieces.forEach(e => this.pieceJointeToShow.push(e));
      // this.pieceJointe = this.o.pieceJointe;
      // console.log(this.pieceJointeToShow);
      // this.pieceJointeToShow.push(`${f.lastModified}_${f.name};`);
      // this.createForm();

    }
    this.autoComplete();
  }

  autoComplete() {
    this.filteredOptions = this.myAuto.valueChanges.pipe(
      // startWith(''),
      switchMap((value: string) => value.length > 1 ? this.uow.organismes.autocompletePost('label', value) : []),
      // map(r => r)
    );
  }

  selected(event: MatAutocompleteSelectedEvent): void {
    const o = event.option.value as any;
    console.log(o);
    this.myAuto.setValue(o.label);
    (this.myForm.get('idOrganisme') as FormControl).setValue(o.id);
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      ficheUrl: [this.o.ficheUrl],
      idOrganisme: [this.o.idOrganisme, Validators.required],
      idSynthese: [this.o.idSynthese],
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onOkClick(o: FicheSynthese): void {

    o.ficheUrl = this.pieceJointe;



    // console.log(this.listSynthese);
    // const synthIds: number[] = [];



    if (!this.isEdit) {
      this.uow.ficheSyntheses.post(o).subscribe(rr => {
        if (this.file) {
          const nameFile = `${this.file.lastModified}_${this.file.name}` as string;
          const formData = new FormData();
          formData.append(nameFile, this.file, nameFile);

          this.uow.files.uploadFiles(formData, 'FicheSynthese').subscribe(rs => {
            this.dialogRef.close('ok');
          });
        }
        this.dialogRef.close('ok');
      });
    } else {
      this.uow.ficheSyntheses.put(o.id, o).subscribe((r: any) => {
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
    }
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
      this.o.ficheUrl = this.pieceJointe;
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
    this.o = new FicheSynthese();
    this.createForm();
  }

  setIcon(filaName) {
    const i = filaName.lastIndexOf('.');
    const s = filaName.substring(i + 1);
    // console.log(s);
    return (s === 'pdf' || s === 'pdf;') ? 'assets/svg/pdf.svg' : 'assets/svg/word.svg';
  }

}

