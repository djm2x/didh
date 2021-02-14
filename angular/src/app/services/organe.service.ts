import { Organe } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { StateOne, StateTwo } from '../Models/state-models';

@Injectable({
  providedIn: 'root'
})
export class OrganeService  extends SuperService<Organe> {

  constructor() {
    super('organes');
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
