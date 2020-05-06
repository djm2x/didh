import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { SituationReserve } from '../Models/models';

@Injectable({
  providedIn: 'root'
})
export class SituationReserveService  extends SuperService<SituationReserve> {

  constructor() {
    super('SituationReserves');
  }

  getFirst = () => this.http.get<SituationReserve>(`${this.urlApi}/${this.controller}/getFirst`);
}
