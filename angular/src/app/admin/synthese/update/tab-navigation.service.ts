import { Injectable, EventEmitter } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TabNavigationService {
  navigateTo = new EventEmitter();
  constructor() { }
}
