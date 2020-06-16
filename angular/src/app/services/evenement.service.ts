import { SuperService } from './super.service';
import { Injectable } from '@angular/core';
import { Evenement } from '../Models/models';

@Injectable({
  providedIn: 'root'
})
export class EvenementService extends SuperService<Evenement> {

  constructor() {
    super('evenements');
  }

  getAll(startIndex, pageSize, sortBy, sortDir, title) {

    return this.http.get(`${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${title}`);
  }

}
