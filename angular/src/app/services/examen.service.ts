import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { Examen } from '../Models/models';

@Injectable({
  providedIn: 'root'
})
export class ExamenService  extends SuperService<Examen> {

  constructor() {
    super('Examens');
  }

}
