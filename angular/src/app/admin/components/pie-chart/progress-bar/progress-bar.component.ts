import { Component, OnInit, Input } from '@angular/core';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-progress-bar',
  templateUrl: './progress-bar.component.html',
  styleUrls: ['./progress-bar.component.scss']
})
export class ProgressBarComponent implements OnInit {
  @Input() widthOne = 0;
  @Input() widthTwo = 0;
  @Input() widthThree = 0;
  @Input() title = '';

  rotateY = 0;
  constructor(public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.mytranslate.lang.subscribe(r => {
      this.rotateY = r === 'fr' ? 0 : 180;
    });
  }

  tooltipMsg(prc: number, realise: number, taux: number) {
    if (this.mytranslate.langSync === 'fr') {
      return 'État d\'avancement : ' + prc + '% - Réaliser : ' + realise + '% - Taux : ' + taux.toFixed(0) + '%';
    }

    return `التقدم المحرز : ${prc} % - منجز : ${realise} % - نسبة ${taux.toFixed(0)} %    `;
    // return ` % ${taux.toFixed(0)} : نسبة - % ${prc} التقدم المحرز`;
  }

}
