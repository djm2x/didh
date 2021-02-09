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
  }

  stateRecommendationByOrganisme() {
    const listToShowPE = [
      'Intérieur et DGSN',
      'Economie et Finances et Fonction Public',
      'Agriculture et Pêche maritime',
      'Equipement, Eau et Environnement',
      'Communication et Culture',
      'Défense Nationale et Gendarmerie Royale',
      'Droits de l’Homme et Relations avec parlement',
      'Développement Social et Solidarité',
      'Affaires Etrangères',
      'Justice',
      'Chef du Gouvernement',
      'Santé',
      'Emploi',
      'Commerce et Industrie',
      'DGAPR',
      'Habous et des Affaires Islamiques',
      'Education nationale',
      'Habitat',
      'Tourisme',
    ];

    const listToShowPEAr = [
      ' الداخلية و الأمن الوطني',
      'المالية و الوظيفة العمومية',
      'الفلاحة و الصيد البحري',
      'التجهيز و النقل و الماء و البيئة',
      'الاتصال و الثقافة',
      'الدفاع الوطني والدرك الملكي',
      'حقوق الإنسان والعلاقات مع البرلمان',
      'التضامن والتنمية الاجتماعية',
      'الشؤون الخارجية',
      'العدل',
      'رئاسة الحكومة',
      'الصحة',
      'الشغل',
      'التجارة والصناعة',
      'إدارة السجون',
      'الأوقاف والشؤون الإسلامية',
      'التربية الوطنية',
      'السكنى',
      'السياحة',
    ];

    const listToDelete = [
      // 'Chef du Gouvernement',
      'Observatoire National des Droits de l’Enfant',
    ]

    const listToWorkWith: { name: string, p: number, r: number, n: number, t: number, type: string, }[] = [];


    this.uow.recommendations.stateRecommendationByOrganisme()
      .subscribe((r: { name: string, p: number, r: number, n: number, t: number, type: string }[]) => {

      console.log(r);
      // return
      r = r.filter(e => e.type && e.type !== '' && listToDelete.includes(e.name) === false && e.name !== undefined);

      r.forEach(e => {
        listToShowPE.forEach((p, index) => {
          if (p.includes(e.name)) {
            const o = {
              name: p,
              p: e.p,
              r: e.r,
              n: e.n,
              t: e.t,
              type: e.type,
              nameAr: listToShowPEAr[index], // (e as any).nameAr
            };

            const i = listToWorkWith.findIndex(w => w.name.includes(o.name));

            if (i !== -1) {
              listToWorkWith[i].p += o.p;
              listToWorkWith[i].r += o.r;
              listToWorkWith[i].n += o.n;
              listToWorkWith[i].t += o.t;
            } else {
              listToWorkWith.push(o);
            }
          }
        });
      });

      const barChartLabelsPE = listToWorkWith.filter(e => e.type === 'PE')
        .map(e => this.mytranslate.langSync === 'fr' ? e.name : (e as any).nameAr);

      const barChartLabelsIN = r.filter(e => e.type === 'IN')
        .map(e => this.mytranslate.langSync === 'fr' ? e.name : (e as any).nameAr);
      const barChartLabelsPG = r.filter(e => e.type === 'PJ')
        .map(e => this.mytranslate.langSync === 'fr' ? e.name : (e as any).nameAr);
      const barChartLabelsAutre = r.filter(e => e.type === 'Autre')
        .map(e => this.mytranslate.langSync === 'fr' ? e.name : (e as any).nameAr);


      const barChartDataPE = [
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.NonRéalisé')/*, stack: 'a'*/ },
      ];

      const barChartDataIN = [
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.NonRéalisé')/*, stack: 'a'*/ },
      ];

      const barChartDataPJ = [
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.NonRéalisé')/*, stack: 'a'*/ },
      ];

      const barChartDataAutre = [
        { data: [], label: this.mytranslate.get('admin.organe.list.Etatavancement')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.Réalisé')/*, stack: 'a'*/ },
        { data: [], label: this.mytranslate.get('admin.organe.list.NonRéalisé')/*, stack: 'a'*/ },
      ];


      listToWorkWith.forEach(e => {
        if (e.type === 'PE') {
          barChartDataPE[0].data.push((e.p * 100 / e.t).toFixed(0));
          barChartDataPE[1].data.push((e.r * 100 / e.t).toFixed(0));
          barChartDataPE[2].data.push((e.n * 100 / e.t).toFixed(0));
        }
      })

      r.forEach(e => {
        if (e.type === 'Autre') {
          barChartDataAutre[0].data.push((e.p * 100 / e.t).toFixed(0));
          barChartDataAutre[1].data.push((e.r * 100 / e.t).toFixed(0));
          barChartDataAutre[2].data.push((e.n * 100 / e.t).toFixed(0));
          // barChartDataAutre[2].data.push((e.t - (e.p * 100 / e.t) - (e.r * 100 / e.t)).toFixed(0));
        } else if (e.type === 'IN') {
          barChartDataIN[0].data.push((e.p * 100 / e.t).toFixed(0));
          barChartDataIN[1].data.push((e.r * 100 / e.t).toFixed(0));
          barChartDataIN[2].data.push((e.n * 100 / e.t).toFixed(0));
          // barChartDataIN[2].data.push((e.t - (e.p * 100 / e.t) - (e.r * 100 / e.t)).toFixed(0));
        } else if (e.type === 'PJ') {
          barChartDataPJ[0].data.push((e.p * 100 / e.t).toFixed(0));
          barChartDataPJ[1].data.push((e.r * 100 / e.t).toFixed(0));
          barChartDataPJ[2].data.push((e.n * 100 / e.t).toFixed(0));
          // barChartDataPJ[2].data.push((e.t - (e.p * 100 / e.t) - (e.r * 100 / e.t)).toFixed(0));
        }
      });

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
