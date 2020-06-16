import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class RecomOrgService extends SuperService<any> {

  constructor() {
    super('recomOrgs');
  }

  postRange(list) {
    return this.http.post(`${this.urlApi}/recomOrgs/postRange`, list);
  }

  putRange(modelsToDelete, modelsToAdd) {
    return this.http.post(`${this.urlApi}/recomOrgs/putRange`, { modelsToDelete, modelsToAdd });
  }

  deleteRangeCutm(modelsToDelete, modelsToAdd) {
    return this.http.post(`${this.urlApi}/recomOrgs/deleteRange`, { modelsToDelete, modelsToAdd });
  }

}
