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

}
