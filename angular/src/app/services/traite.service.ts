import { Traite } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class TraiteService  extends SuperService<Traite> {

  constructor() {
    super('traites');
  }

  getCount(idOrganisme) {
    return this.http.get(`${this.urlApi}/traites/getCount/${idOrganisme}`);
  }

  getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme) {
    return this.http.
    get(`${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${idOrganisme}`);
  }

  put$(model) {
    return this.http.post(`${this.urlApi}/traites/put`, model);
  }

}
