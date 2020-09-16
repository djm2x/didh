import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { Visite } from '../Models/models';

@Injectable({
  providedIn: 'root'
})
export class VisiteService  extends SuperService<Visite> {

  constructor() {
    super('visites');
  }

  getDate(month, year) {
    return this.http.get(`${this.urlApi}/${this.controller}/getDate/${month}/${year}`);
  }

  stateVisites() {
    return this.http.get<{ name: string, p: number, t: number, r: number }[]>(`${this.urlApi}/${this.controller}/stateVisites`);
  }

}
