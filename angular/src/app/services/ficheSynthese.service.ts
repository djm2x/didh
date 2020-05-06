import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { FicheSynthese } from '../Models/models';

@Injectable({
  providedIn: 'root'
})
export class FicheSyntheseService  extends SuperService<FicheSynthese> {

  constructor() {
    super('ficheSyntheses');
  }

  getAll(startIndex, pageSize, sortBy, sortDir, idSynthese) {
    return this.http.get(`${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${idSynthese}`);
  }

}
