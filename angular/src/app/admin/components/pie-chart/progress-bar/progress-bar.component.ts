import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-progress-bar',
  templateUrl: './progress-bar.component.html',
  styleUrls: ['./progress-bar.component.scss']
})
export class ProgressBarComponent implements OnInit {
  @Input() widthOne = 0;
  @Input() widthTwo = 0;
  @Input() title = '';

  
  constructor() { }

  ngOnInit() {
  }

}