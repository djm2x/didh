import { Component, OnInit, Input } from '@angular/core';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.scss']
})
export class TitleComponent implements OnInit {
  @Input() title = '';
  constructor(public mytranslate: MyTranslateService) { }

  ngOnInit() {
  }

}
