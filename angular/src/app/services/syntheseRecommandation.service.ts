import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { SyntheseRecommandation } from '../Models/models';

@Injectable({
  providedIn: 'root'
})
export class SyntheseRecommandationService  extends SuperService<SyntheseRecommandation> {

  constructor() {
    super('SyntheseRecommandations');
  }

  putRange(modelsToDelete, modelsToAdd) {
    return this.http.post(`${this.urlApi}/${this.controller}/putRange`, { modelsToDelete, modelsToAdd });
  }

}
