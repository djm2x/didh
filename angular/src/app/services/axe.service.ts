import { Axe } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { StateOne, StateTwo } from '../Models/state-models';

@Injectable({
  providedIn: 'root'
})
export class AxeService  extends SuperService<Axe> {

  constructor() {
    super('axes');
  }

  stateAxes(mecanisme: string) {
    return this.http.get<{ name: string, p: number, t: number, r: number, n: number }[]>(`${this.urlApi}/${this.controller}/stateAxes/${mecanisme}`);
  }

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
