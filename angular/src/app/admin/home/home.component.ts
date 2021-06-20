import { SessionService } from 'src/app/shared';
import { UowService } from 'src/app/services/uow.service';
import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  departementSubjectPE = new Subject();
  departementSubjectAutre = new Subject();
  departementSubjectIN = new Subject();
  departementSubjectPJ = new Subject();

  constructor(private uow: UowService, public session: SessionService
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {
    this.stateRecommendationByOrganisme();
    // const lfr = []
    // Promise.all([
    //   'رئاسة الحكومة',
    //   'العلاقات مع البرلمان و  حقوق الإنسان',
    //   ' الفلاحة و الصيد البحري و المياه والغابات',
    //   'الدفاع الوطني والدرك الملكي',
    //   'الشؤون العامة والحكامة  و إصلاح الإدارة و الاقتصاد والمالية',
    //   'التكوين المهني و التعليم العالي  و التربية الوطنية',
    //   ' المغاربة المقيمون بالخارج و الشؤون الخارجية',
    //   'العدل',
    //   'الاتصال و الثقافة و الشباب والرياضة',
    //   'الأمن الوطني و الداخلية',
    //   'الأوقاف والشؤون الإسلامية',
    //   'السكنى',
    //   'السياحة',
    //   'الصحة',
    //   'التجهيز و النقل و الماء',
    //   ' البيئة و الطاقة والمعادن',
    //   'الشغل',
    //   'إدارة السجون',
    //   'التنمية الاجتماعية والتضامن',
    //   'التجارة والصناعة',
    //   'المندوبية السامية للتخطيط',
    // ].map(async e => {
    //   const r = await this.uow.recommendations.searchByName(e).toPromise();

    //   lfr.push(r);

    //   console.log(lfr.map(c => c.nom));
    // }))
  }

  async stateRecommendationByOrganisme() {
    const listToShowPE = (await this.uow.organismeHomePE.toPromise())?.fr;

    const listToShowPEAr = (await this.uow.organismeHomePE.toPromise())?.ar;

    const listToDelete = ['Observatoire National des Droits de l’Enfant'];

    const listToWorkWith: {
      name: string,
      type: string,
      one: number,
      two: number,
      three: number,
      four: number,
      total: number,
    }[] = [];

    this.uow.recommendations.stateRecommendationByOrganisme().subscribe((r: {
      name: string, nameAr: string, type: string, one: number, two: number, three: number, four: number, total: number,
    }[]) => {
      // return
      r = r.filter(e => e.type && e.type !== '' && listToDelete.includes(e.name) === false && e.name !== undefined);

      r.forEach(e => {
        listToShowPEAr.forEach((p, index) => {
          // console.log(p.includes(e.name), p,e.nameAr)
          if (p.includes(e.nameAr)) {
            const o = {
              nameAr: p,
              one: e.one,
              two: e.two,
              three: e.three,
              four: e.four,
              total: e.total,
              type: e.type,
              name: listToShowPE[index], // (e as any).nameAr
            };

            const i = listToWorkWith.findIndex(w => w.name.includes(o.name));

            if (i !== -1) {
              listToWorkWith[i].one += o.one;
              listToWorkWith[i].two += o.two;
              listToWorkWith[i].three += o.three;
              listToWorkWith[i].four += o.four;
              listToWorkWith[i].total += o.total;
            } else {
              listToWorkWith.push(o);
            }
          }
        });
      });

      r = r.filter(e => e);

      const barChartLabelsPE = listToWorkWith.filter(e => e.type === 'PE')
        .map(e => this.mytranslate.langSync === 'fr' ? e.name : (e as any).nameAr);

      const barChartLabelsIN = r.filter(e => e.type === 'IN')
        .map(e => this.mytranslate.langSync === 'fr' ? e.name : (e as any).nameAr);

      const barChartLabelsPG = r.filter(e => e.type === 'PJ')
        .map(e => this.mytranslate.langSync === 'fr' ? e.name : (e as any).nameAr);

      const barChartLabelsAutre = r.filter(e => e.type === 'Autre')
        .map(e => this.mytranslate.langSync === 'fr' ? e.name : (e as any).nameAr);

      //
      const pe = listToWorkWith.filter(e => e.type === 'PE');

      const barChartDataPE = [
        { data: pe.map(e => +(e.four * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Réalisé') },
        { data: pe.map(e => +(e.three * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Recommendation_continue') },
        { data: pe.map(e => +(e.two * 100 / e.total).toFixed(0)), label: this.mytranslate.get('EnCours') },
        { data: pe.map(e => +(e.one * 100 / e.total).toFixed(0)), label: this.mytranslate.get('NonRéalisé') },
      ];

      const autre = r.filter(e => e.type === 'Autre');

      const barChartDataAutre = [
        { data: autre.map(e => +(e.four * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Réalisé') },
        { data: autre.map(e => +(e.three * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Recommendation_continue') },
        { data: autre.map(e => +(e.two * 100 / e.total).toFixed(0)), label: this.mytranslate.get('EnCours') },
        { data: autre.map(e => +(e.one * 100 / e.total).toFixed(0)), label: this.mytranslate.get('NonRéalisé') },
      ];

      const IN = r.filter(e => e.type === 'IN');

      const barChartDataIN = [
        { data: IN.map(e => +(e.four * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Réalisé') },
        { data: IN.map(e => +(e.three * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Recommendation_continue') },
        { data: IN.map(e => +(e.two * 100 / e.total).toFixed(0)), label: this.mytranslate.get('EnCours') },
        { data: IN.map(e => +(e.one * 100 / e.total).toFixed(0)), label: this.mytranslate.get('NonRéalisé') },
      ];

      const PJ = r.filter(e => e.type === 'PJ');

      const barChartDataPJ = [
        { data: PJ.map(e => +(e.four * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Réalisé') },
        { data: PJ.map(e => +(e.three * 100 / e.total).toFixed(0)), label: this.mytranslate.get('Recommendation_continue') },
        { data: PJ.map(e => +(e.two * 100 / e.total).toFixed(0)), label: this.mytranslate.get('EnCours') },
        { data: PJ.map(e => +(e.one * 100 / e.total).toFixed(0)), label: this.mytranslate.get('NonRéalisé') },
      ];

      this.departementSubjectAutre.next({
        barChartLabels: barChartLabelsAutre, barChartData: barChartDataAutre
        , title: this.mytranslate.get('admin.home.Parlement')
      });

      this.departementSubjectPE.next({
        barChartLabels: barChartLabelsPE, barChartData: barChartDataPE
        , title: this.mytranslate.get('admin.home.Départementsgouvernementaux')
      });

      this.departementSubjectPJ.next({
        barChartLabels: barChartLabelsPG, barChartData: barChartDataPJ
        , title: this.mytranslate.get('admin.home.Départementàpouvoirjudiciaire')
      });

      this.departementSubjectIN.next({
        barChartLabels: barChartLabelsIN, barChartData: barChartDataIN
        , title: this.mytranslate.get('admin.home.InstitutionsNationales')
      });
    });
  }
}
