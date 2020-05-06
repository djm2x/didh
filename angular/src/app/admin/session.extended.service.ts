import { SessionService } from './../shared/session.service';
import { Injectable, PLATFORM_ID, Inject, EventEmitter } from '@angular/core';

const ID_ADMIN = 1;
const ID_SUPER_VISUER = 2;
const ID_POINT_FOCAL = 3;
const PROPREITAIRE = 4;
@Injectable({
    providedIn: 'root'
  })
export class SessionExtendedService22 extends SessionService {

  constructor() {
    super();
  }




}
