import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-intros',
  templateUrl: './intros.component.html',
  styleUrls: ['./intros.component.scss']
})
export class IntrosComponent implements OnInit {
  text = '';
  text2 = '';
  length = 400;
  @Input() mecanisme = '';
  constructor(public mytranslate: MyTranslateService, private http: HttpClient) { }

  ngOnInit() {
    this.mytranslate.lang.subscribe(l => {
      this.http.get<string>(`assets/htmls/${l === 'fr' ? this.mecanisme + '_fr' : this.mecanisme + '_ar'}.html`, {responseType: 'text'} as any).subscribe(r => {
        this.text = r as any;
        this.text2 = this.text.substring(0, this.length);
      });
    });
  }

  moreInfo() {
    const isSmall = this.text2.length === this.length;

    this.text2 = isSmall ? this.text : this.text.substring(0, this.length);
  }

}
