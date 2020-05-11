import { Injectable } from '@angular/core';
import { SuperService } from './super.service';
import { ParticipationSession } from '../Models/models';

@Injectable({
  providedIn: 'root'
})
export class ParticipationSessionService  extends SuperService<ParticipationSession> {

  constructor() {
    super('ParticipationSessions');
  }

  getAll(startIndex, pageSize, sortBy, sortDir, session) {
    return this.http.get(`${this.urlApi}/${this.controller}/getAll/${startIndex}/${pageSize}/${sortBy}/${sortDir}/${session}`);
  }

}
