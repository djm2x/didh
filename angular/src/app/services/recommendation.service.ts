import { Recommendation } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RecommendationService extends SuperService<Recommendation> {

  constructor() {
    super('recommendations');
  }

  annee() {
    return this.http.get<number[]>(`${this.urlApi}/${this.controller}/annee`);
  }

  recommandationValues() {
    return this.http.get(`${this.urlApi}/${this.controller}/recommandationValues`);
  }

  getCount(idOrganisme) {
    return this.http.get(`${this.urlApi}/${this.controller}/getCount/${idOrganisme}`);
  }

  recommandationByOrganisme() {
    return this.http.get(`${this.urlApi}/${this.controller}/recommandationByOrganisme`);
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
    // tslint:disable-next-line:max-line-length
    return this.http.post(`${this.urlApi}/${this.controller}/searchAndGet`, o);
  }

  stateParamAxe(o) {
    return this.http.post<{
      count: number,
      mecanisme: {
        epu: { name: string, p: number, t: number, r: number, n: number },
        ot: { name: string, p: number, t: number, r: number, n: number },
        ps: { name: string, p: number, t: number, r: number, n: number }
      },
      recommandationValues: {realise: number, nonRealise: number, enCours: number, count: number}
      axe: { name: string, p: number, t: number, r: number, n: number }[],
      epu: { name: string, p: number, t: number, r: number, n: number }[],
      visite: { name: string, p: number, t: number, r: number, n: number }[],
      organe: { name: string, p: number, t: number, r: number, n: number }[],
      department: { name: string, nameAr: string, id: number, p: number, c: number, t: number, r: number, n: number, type: string }[]
      pays: { name: string, p: number, t: number, r: number, n: number }[]
    }>(`${this.urlApi}/${this.controller}/stateParamAxe`, o);
  }

  stateMecanisme() {
    return this.http.get<{
      epu: { name: string | Observable<string>, p: number, t: number, r: number, n: number},
      ot: { name: string | Observable<string>, p: number, t: number, r: number , n: number},
      ps: { name: string | Observable<string>, p: number, t: number, r: number , n: number},
      count: number,
    }>(`${this.urlApi}/${this.controller}/stateMecanisme`);
  }

  stateParamOrganisme(o) {
    return this.http.post(`${this.urlApi}/${this.controller}/stateParamOrganisme`, o);
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

  genericByRecommendation(table: 'axe' | 'organe' | 'visite', type: string) {
    return this.http.get<{ table: string, value: number }[]>(`${this.urlApi}/${this.controller}/genericByRecommendation/${table}/${type}`);
  }

  stateRecommendationByOrganisme() {
    return this.http.get(`${this.urlApi}/${this.controller}/stateRecommendationByOrganisme`);
  }

  stateRecommendationByMecanismeTaux() {
    return this.http.get<{ table: string, value: number }[]>(`${this.urlApi}/${this.controller}/stateRecommendationByMecanismeTaux`);
  }

  stateRecommendationByMecanismePercentage() {
    return this.http.get<{ table: string, value: number }[]>(`${this.urlApi}/${this.controller}/stateRecommendationByMecanismePercentage`);
  }

  stateRecommendationByAxe() {
    return this.http.get<{ id: number, table: string, value: number }[]>(`${this.urlApi}/${this.controller}/stateRecommendationByAxe`);
  }

  //
  stateEPU() {
    return this.http.get<{ p: number, t: number }>(`${this.urlApi}/${this.controller}/stateEPU`);
  }

  stateOT() {
    return this.http.get<{ p: number, t: number }>(`${this.urlApi}/${this.controller}/stateOT`);
  }

  statePS() {
    return this.http.get<{ p: number, t: number }>(`${this.urlApi}/${this.controller}/statePS`);
  }

  stateOrgane() {
    return this.http.get<{ name: string, p: number, t: number, r: number, n: number }[]>(`${this.urlApi}/${this.controller}/stateOrgane`);
  }

  stateVisite() {
    return this.http.get<{ name: string, p: number, t: number, r: number, n: number  }[]>(`${this.urlApi}/${this.controller}/stateVisite`);
  }

}
