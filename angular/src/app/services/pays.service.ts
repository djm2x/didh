import { Pays } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class PaysService  extends SuperService<Pays> {

  constructor() {
    super('Pays');
  }


  getAll(startIndex, pageSize, sortBy, sortDir, nom) {
    return this.http.get(
      `${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${nom}`);
  }
}
