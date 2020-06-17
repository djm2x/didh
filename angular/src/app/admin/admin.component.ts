import { Router, NavigationStart, RouterOutlet } from '@angular/router';
import { Component, ViewChild, ChangeDetectorRef, OnInit } from '@angular/core';
import { MatButton } from '@angular/material';
import { MediaMatcher } from '@angular/cdk/layout';
import { routerTransition } from '../shared/animations';
import { SessionService } from '../shared';
import { User } from '../Models/models';
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
    { name: 'Accueil', route: ['/admin/home'], width: '70px' },
    { name: 'Examen Périodique universelle', route: ['/admin/examen'], width: '126px' },
    { name: 'Organes de Traités', route: ['/admin/rapport'], width: '76px' },
    { name: 'Procédures spéciales', route: ['/admin/visite'], width: '70px' },
    { name: 'Evènements ', route: ['/admin/evenement'], width: '80px' },
    { name: 'Questionnaires', route: ['/admin/questionnaire'], width: '95px' },
    { name: 'Participation aux sessions\r\n des droits de l’homme', route: ['/admin/participation-session'], width: '167px' },
    { name: 'Diagrammes et Statistiques', route: ['/admin/state'], width: '100px' },
    { name: 'Documentation', route: ['documentation'], width: '100px' },
    { name: 'Recommandations', route: ['/admin/documentation'], width: '113px' },
    { name: 'Synthèse', route: ['/admin/synthese'], width: '70px' },
  ];

  menus = [
    { name: 'Utilisateur', route: ['/admin/user'], width: '' },
    { name: 'Profils', route: ['/admin/profil'], width: '' },
    { name: 'Organisations', route: ['/admin/organisme'], width: '' },
    { name: 'Organe de traités', route: ['/admin/organe'], width: '' },
    { name: 'Cycles', route: ['/admin/cycle'], width: '' },
    { name: 'Axes', route: ['/admin/axe'], width: '' },
    { name: 'Sous axe', route: ['/admin/sous-axe'], width: '' },
    { name: 'Pays', route: ['/admin/pays'], width: '' },
  ];
  constructor(public session: SessionService, changeDetectorRef: ChangeDetectorRef
    , media: MediaMatcher, public router: Router) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this.mobileQuery.addListener((e: MediaQueryListEvent) => changeDetectorRef.detectChanges());
  }

  ngOnInit() {


    this.getRoute();
    // setTimeout(() => {
    //   this.user = this.session.user;
    //   console.log(this.user);
    //   this.snav.toggle();
    // }, 300);

  }

  get patchRoute() { return this.route.split('/'); }

  getRoute() {
    this.router.events.subscribe(route => {
      if (route instanceof NavigationStart) {
        this.route = route.url;
        console.log(this.route);
      }
    });
  }

  get routes() {
    return [
      { name: 'Accueil', route: '/admin/home' },
      { name: 'Examen Périodique universelle', route: '/admin/examen' },
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
