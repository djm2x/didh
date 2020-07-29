import { Cycle } from './../Models/models';
import { Injectable } from '@angular/core';
import { SuperService } from './super.service';

@Injectable({
  providedIn: 'root'
})
export class CycleService  extends SuperService<Cycle> {

  constructor() {
    super('cycles');
  }

}
