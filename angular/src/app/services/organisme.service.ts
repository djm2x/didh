import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { Organisme } from 'src/app/Models/models';
@Injectable({
  providedIn: 'root'
})
export class OrganismeService  extends SuperService<Organisme> {

  constructor() {
    super('organisme');
  }

  getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme, type, nom = '*') {
    return this.http.get(
      `${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${idOrganisme}/${type}/${nom}`);
  }

}
