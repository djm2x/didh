import { Component, OnInit } from '@angular/core';
import { SplashScreenService } from './shared/splash-screen.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Front';

  constructor(private splashScreenService: SplashScreenService) { }

  ngOnInit() { }
}
