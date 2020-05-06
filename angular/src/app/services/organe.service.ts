import { Organe } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class OrganeService  extends SuperService<Organe> {

  constructor() {
    super('organes');
  }

}
