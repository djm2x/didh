import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Axe } from 'src/app/Models/models';
import { MyTranslateService } from 'src/app/my.translate.service';
import { UowService } from 'src/app/services/uow.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.scss']
})
export class TestComponent implements OnInit {
  myForm: FormGroup;
  axes: Axe[] = [];
  o = {
    axesString: "",
    sousAxesString: "[3,4,7,1]",
  };

  constructor(public uow: UowService, public mytranslate: MyTranslateService, private fb: FormBuilder) { }

  async ngOnInit() {
    this.createForm();
    this.axes = await this.uow.axes.get().toPromise();

    this.myForm.get('idAxe').setValue(this.o.axesString !== '' ? JSON.parse(this.o.axesString) : []);
    this.myForm.get('idSousAxe').setValue(this.o.sousAxesString !== '' ? JSON.parse(this.o.sousAxesString) : []);

    this.myForm.get('idAxe').valueChanges.subscribe((e: string[]) => {
      this.o.axesString = JSON.stringify(e);
    });

    this.myForm.get('idSousAxe').valueChanges.subscribe((e: string[]) => {
      this.o.sousAxesString = JSON.stringify(e);
    });
  }

  createForm() {
    this.myForm = this.fb.group({
      idAxe: [[]],
      idSousAxe: [[]],
    });
  }

}
