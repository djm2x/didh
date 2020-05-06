import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class SyntheseService extends SuperService<any> {

  constructor() {
    super('syntheses');
  }

  getAll(startIndex, pageSize, sortBy, sortDir, idOrganisme, idOrganismeEmetteur, idTraite, idRapport, idAxe, idSousAxe) {
    return this.http.get(`${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}` +
      `/${idOrganisme}/${idOrganismeEmetteur}/${idTraite}/${idRapport}/${idAxe}/${idSousAxe}`);
  }

  getAllWithNoRapport(startIndex, pageSize, sortBy, sortDir, idRapport) {
    return this.http.get(
      `${this.urlApi}/${this.controller}/getAllWithNoRapport/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${idRapport}`);
  }

  getDetail(id) {
    return this.http.get(`${this.urlApi}/${this.controller}/getDetail/${id}`);
  }

  updateRange(list) {
    return this.http.post(`${this.urlApi}/${this.controller}/updateRange`, list);
  }

}
