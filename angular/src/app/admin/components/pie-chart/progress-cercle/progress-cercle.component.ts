import { Component, OnInit, Input } from '@angular/core';
import { Subject, Observable, of } from 'rxjs';
import { MyTranslateService } from 'src/app/my.translate.service';

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
  @Input() transform = 50;

  @Input() public isInForLoop = false;
  @Input() public data = new Subject<{ name: string | Observable<string>, t: number, p: number }>();
  @Input() o = { name: null, t: 0, p: 0 };
  @Input() public elementFromForLoop: { name: string | Observable<string>, p: number, t: number };

  retate = 0;

  constructor(public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.mytranslate.lang.subscribe(lang => {
      this.retate = lang === 'fr' ? 0 : 180;
    });
    
    this.data.subscribe(async r => {

      if (r.name instanceof Observable) {
        r.name.subscribe(name => {
          this.o.name = name;
          this.o.t = r.t;
          this.o.p = r.p;
        });

      } else {
        this.o = r;
      }

    });
  }

  tooltipMsg(prc: number, taux: number) {
    if (this.mytranslate.langSync === 'fr') {
      return 'État d\'avancement : ' + prc + '%' + ' - Taux : ' + taux.toFixed(0) + '%';
    }

    return `التقدم المحرز : ${prc} % - نسبة ${taux.toFixed(0)} %    `;
    // return ` % ${taux.toFixed(0)} : نسبة - % ${prc} التقدم المحرز`;
  }

}
