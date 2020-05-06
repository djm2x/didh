import { Recommendation } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class RecommendationService extends SuperService<Recommendation> {

  constructor() {
    super('recommendations');
  }

  getCount(idOrganisme) {
    return this.http.get(`${this.urlApi}/${this.controller}/getCount/${idOrganisme}`);
  }

  recommandationByCycle() {
    return this.http.get(`${this.urlApi}/${this.controller}/recommandationByCycle`);
  }

  recommandationByAxe(idCycle) {
    return this.http.get(`${this.urlApi}/${this.controller}/recommandationByAxe/${idCycle}`);
  }

  recommandationByConvention(idTraite) {
    return this.http.get(`${this.urlApi}/${this.controller}/recommandationByConvention/${idTraite}`);
  }

  recommandationByMecanisme(idCycle, idOrgane, idVisite) {
    return this.http.get(`${this.urlApi}/${this.controller}/recommandationByMecanisme/${idCycle}/${idOrgane}/${idVisite}`);
  }

  searchAndGet(o) {
    return this.http.post(`${this.urlApi}/${this.controller}/searchAndGet`, o);
  }
  // updateRange(o) {
  //   // console.log("updating : ", o)
  //   return this.http.post(`${this.urlApi}/${this.controller}/updateRange`, o);
  // }

  // getByIdCycle(id) {
  //   return this.http.get(`${this.urlApi}/${this.controller}/getByIdCycle/${id}`);
  // }

  getAllForSynthese(startIndex, pageSize, sortBy, sortDir, idCycle, idOrgane, idVisite, idAxe, idSousAxe) {
    return this.http.get(
      `${this.urlApi}/${this.controller}/getAllForSynthese/${startIndex}
      /${pageSize}/${sortBy}/${sortDir}/${idCycle}/${idOrgane}/${idVisite}/${idAxe}/${idSousAxe}`);
  }

  getDetail(id) {
    return this.http.get(`${this.urlApi}/${this.controller}/getDetail/${id}`);
  }

  getByIdSynthese(idSynthese) {
    return this.http.get(`${this.urlApi}/${this.controller}/getByIdSynthese/${idSynthese}`);
  }



}
