import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class VisiteService  extends SuperService<any> {

  constructor() {
    super('visites');
  }

  getDate(month, year) {
    return this.http.get(`${this.urlApi}/${this.controller}/getDate/${month}/${year}`);
  }

}
