import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { Visite } from '../Models/models';
import { StateOne, StateTwo } from '../Models/state-models';

@Injectable({
  providedIn: 'root'
})
export class VisiteService  extends SuperService<Visite> {

  constructor() {
    super('visites');
  }

  // getDate(month, year) {
  //   return this.http.get(`${this.urlApi}/${this.controller}/getDate/${month}/${year}`);
  // }

  // stateVisites() {
  //   return this.http.get<{ name: string, p: number, t: number, r: number, n: number }[]>(`${this.urlApi}/${this.controller}/stateVisites`);
  // }

  stateDetailByMecanisme() {
    return this.http.get<StateOne[]>(`${this.urlApi}/${this.controller}/stateDetailByMecanisme`);
  }

  stateByMecanisme() {
    return this.http.get<StateTwo[]>(`${this.urlApi}/${this.controller}/stateByMecanisme`);
  }

  mecanismeState() {
    return this.http.get<StateOne>(`${this.urlApi}/${this.controller}/mecanismeState`);
  }

}
