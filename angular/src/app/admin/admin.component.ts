import { Router, NavigationStart, RouterOutlet } from '@angular/router';
import { Component, ViewChild, ChangeDetectorRef, OnInit } from '@angular/core';
import { MatButton } from '@angular/material';
import { MediaMatcher } from '@angular/cdk/layout';
import { routerTransition } from '../shared/animations';
import { SessionService } from '../shared';
import { User } from '../Models/models';
import { TranslateService } from '@ngx-translate/core';
import { MyTranslateService } from '../my.translate.service';
@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss'],
  animations: [routerTransition],
})
export class AdminComponent implements OnInit {
  @ViewChild('btndev', { static: true }) btndev: MatButton;
  @ViewChild('snav', { static: true }) snav: any;
  keyDevTools = '';
  panelOpenState = false;
  mobileQuery: MediaQueryList;
  currentSection = 'section1';
  userImg = '../../assets/caisse.jpg';
  opened = false;
  idRole = -1;
  isConnected = false;
  // montantCaisse = this.s.notify;
  route = this.router.url;
  user = new User();
  navs = [
    // { name: 'Accueil', route: ['/admin/home'], width: '70px' , children: [] },
    // { name: 'Mecanisme', route: ['/admin/home'], width: '70px' , children: [
    //   { name: 'Examen Périodique universel', route: ['/admin/examen'], width: '126px' },
    //   { name: 'Organes de Traités', route: ['/admin/rapport'], width: '76px' },
    //   { name: 'Procédures spéciales', route: ['/admin/visite'], width: '70px' },
    // ] },

    { name: this.mytranslate.getObs('admin.header.SessionsDH'), route: ['/admin/participation-session']/*, width: '167px'*/, children: [] },
    { name: this.mytranslate.getObs('admin.header.Questionnaires'), route: ['/admin/questionnaire'], /*width: '95px' , */children: [] },
    // tslint:disable-next-line:max-line-length Diagrammes et
    // { name: 'Participation aux sessions\r\n des droits de l’homme', route: ['/admin/participation-session'], width: '167px' , children: [] },
    // { name: 'Statistiques', route: ['/admin/state'], width: '100px' , children: [] },
    { name: this.mytranslate.getObs('admin.header.Documentation'), route: ['/admin/evenement'], /*width: '100px' ,*/ children: [] },
    // { name: 'Recommandations', route: ['/admin/recommendation'], width: '113px' , children: [] },
    // { name: 'Synthèse', route: ['/admin/synthese'], width: '70px' , children: [] },
  ];

  navs2 = [
    { name: this.mytranslate.getObs('admin.header.ExamenPériodiqueuniverselle'), route: ['/admin/examen'],},
    { name: this.mytranslate.getObs('admin.header.OrganesdeTraités'), route: ['/admin/rapport'], },
    { name: this.mytranslate.getObs('admin.header.Procéduresspéciales'), route: ['/admin/visite'], },
    { name: this.mytranslate.getObs('admin.header.Statistiques'), route: ['/admin/state'],  },
    { name: this.mytranslate.getObs('admin.header.Recommandations'), route: ['/admin/recommendation'],  },
    { name: this.mytranslate.getObs('admin.header.Synthèse'), route: ['/admin/synthese'], },
  ];

  menus = [
    { name: this.mytranslate.getObs('admin.header.Utilisateur'), route: ['/admin/user'], width: '' },
    { name: this.mytranslate.getObs('admin.header.Profils'), route: ['/admin/profil'], width: '' },
    { name: this.mytranslate.getObs('admin.header.Organisations'), route: ['/admin/organisme'], width: '' },
    { name: this.mytranslate.getObs('admin.header.Organedetraités'), route: ['/admin/organe'], width: '' },
    { name: this.mytranslate.getObs('admin.header.Cycles'), route: ['/admin/cycle'], width: '' },
    { name: this.mytranslate.getObs('admin.header.Axes'), route: ['/admin/axe'], width: '' },
    { name: this.mytranslate.getObs('admin.header.Sousaxe'), route: ['/admin/sous-axe'], width: '' },
    { name: this.mytranslate.getObs('admin.header.Pays'), route: ['/admin/pays'], width: '' },
  ];


  constructor(public session: SessionService, changeDetectorRef: ChangeDetectorRef
    , media: MediaMatcher, public router: Router , public mytranslate: MyTranslateService) {

    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this.mobileQuery.addListener((e: MediaQueryListEvent) => changeDetectorRef.detectChanges());

    if (this.session.isPublic) {
      const i = this.navs2.findIndex(e => e.route.includes('/admin/state'));
      this.navs2.splice(i, 1);
    }
  }

  ngOnInit() {
    this.getRoute();
  }

  changeLanguage(currentLanguage) {
    this.mytranslate.changeLanguage(currentLanguage);
  }

  get patchRoute() { return this.route.split('/'); }

  getRoute() {
    this.router.events.subscribe(route => {
      if (route instanceof NavigationStart) {
        this.route = route.url;
        // console.log(this.route);
      }
    });
  }

  get routes() {
    return [
      { name: 'Accueil', route: '/admin/home' },
      { name: 'Examen Périodique universel', route: '/admin/examen' },
      // { name: 'Organes de Traités', route: '/admin/rapport' },
      // { name: 'Procédures spéciales', route: '/admin/visite' },
      // { name: 'Evènements ', route: '/admin/evenements' },
      // { name: 'Questionnaires', route: '/admin/questionnaire' },
      // { name: 'Participation aux sessions des droits de l’homme', route: '/admin/participation-session' },
      // { name: 'Diagrammes et Statistiques', route: '/admin/state' },
      // { name: 'Documentation', route: '' },
      // { name: 'Recommandations', route: '/admin/documentation' },
      // { name: 'Synthèse', route: '/admin/synthese' },
    ];
  }



  disconnect() {
    this.session.doSignOut();
    this.router.navigate(['/auth']);
  }

  getState(outlet: RouterOutlet) {
    return outlet.activatedRouteData.state;
  }
}
