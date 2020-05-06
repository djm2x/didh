import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class OrganismeService  extends SuperService<any> {

  constructor() {
    super('organisme');
  }

  getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme) {
    return this.http.get(
      `${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${idOrganisme}`);
  }

}
