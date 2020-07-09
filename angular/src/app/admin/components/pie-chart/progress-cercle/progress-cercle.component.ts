import { Component, OnInit, Input } from '@angular/core';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-progress-cercle',
  templateUrl: './progress-cercle.component.html',
  styleUrls: ['./progress-cercle.component.scss']
})
export class ProgressCercleComponent implements OnInit {
  @Input() width = 300;
  @Input() fontSize = .93;
  @Input() widthText = 'auto';
  @Input() diameter = 120;

  @Input() public isInForLoop = false;
  @Input() public data = new Subject<{ name: string, t: number, p: number }>();
  @Input() o = { name: '', t: 0, p: 0 };
  @Input() public elementFromForLoop: { name: string, p: number, t: number };
  constructor() { }

  ngOnInit() {
    this.data.subscribe(r => {
      console.log(r)
      this.o = r;
    });
  }

}
