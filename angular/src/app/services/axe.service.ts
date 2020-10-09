import { Axe } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class AxeService  extends SuperService<Axe> {

  constructor() {
    super('axes');
  }

  stateAxes() {
    return this.http.get<{ name: string, p: number, t: number, r: number, n: number }[]>(`${this.urlApi}/${this.controller}/stateAxes`);
  }

}
