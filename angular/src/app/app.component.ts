import { Component, OnInit } from '@angular/core';
import { SplashScreenService } from './shared/splash-screen.service';
import { MyTranslateService } from './my.translate.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Front';

  constructor(private splashScreenService: SplashScreenService, public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.mytranslate.init();
    this.mytranslate.currentLang().subscribe(r => {
      this.mytranslate.lang.next(r.lang);
    });
  }
}
