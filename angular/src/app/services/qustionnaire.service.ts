import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { Questionnaire } from '../Models/models';

@Injectable({
  providedIn: 'root'
})
export class QuestionnaireService  extends SuperService<Questionnaire> {

  constructor() {
    super('Questionnaires');
  }

  getAll(startIndex, pageSize, sortBy, sortDir, idAxe, idSousAxe, annee) {
    return this.http.get(
      `${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${idAxe}/${idSousAxe}/${annee}`);
  }

}
