import { HttpClient } from '@angular/common/http';
import { PaysService } from './pays.service';
import { SituationReserveService } from './situation-reserve.service';
import { OrganeService } from './organe.service';
import { TraiteService } from './traite.service';
// import { NotificationService } from './notification.service';
import { CycleService } from './cycle.service';
import { RecommendationService } from './recommendation.service';
import { VisiteService } from './visite.service';
import { ProfilService } from './profil.service';
import { OrganismeService } from './organisme.service';
import { UserService } from './user.service';
import { Injectable } from '@angular/core';
import { FileUploadService } from './file.upload.service';
import { SousAxeService } from './sous.axe.service';
import { AxeService } from './axe.service';
import { SyntheseService } from './synthese.service';
import { RapportService } from './rapport.service';
import { RecomOrgService } from './recomOrg.service';
import { FicheSyntheseService } from './ficheSynthese.service';
import { SyntheseRecommandationService } from './syntheseRecommandation.service';
import { ExamenService } from './examen.service';
import { QuestionnaireService } from './qustionnaire.service';
import { ParticipationSessionService } from './participation.service';
import { EvenementService } from './evenement.service';


@Injectable({
  providedIn: 'root'
})
export class UowService {
  users = new UserService();
  profils = new ProfilService();
  organismes = new OrganismeService();
  visites = new VisiteService();
  files = new FileUploadService();
  cycles = new CycleService();
  organes = new OrganeService();
  // notifications = new NotificationService();
  sousAxes = new SousAxeService();
  axes = new AxeService();
  pays = new PaysService();
  recommendations = new RecommendationService();
  syntheses = new SyntheseService();
  rapports = new RapportService();
  traites = new TraiteService();
  recomOrgs = new RecomOrgService();
  ficheSyntheses = new FicheSyntheseService();
  examens = new ExamenService();
  syntheseRecommandations = new SyntheseRecommandationService();
  situationReserves = new SituationReserveService();
  questionnaires = new QuestionnaireService();
  participations = new ParticipationSessionService();
  evenements = new EvenementService();


  years = [...Array(new Date().getFullYear() - 2000).keys()].map(e => 2008 + e);
  // mecanismes = ['Examen périodique universal', 'Organes de traités', 'Procédure spéciale'];
  // etats = ['Réalisé', 'En cours', 'En continue', 'Non réalisé'];
  mecanismes = this.http.get<{ name: string, nameAr: string }[]>('assets/json/mecanisme.json');
  etats = this.http.get<{ name: string, nameAr: string }[]>('assets/json/etats.json');
  themes = this.http.get<{
    id: number
    name: string,
    nameAr: string,
    sousThemes: {
      id: number
      name: string,
      nameAr: string,
    }[]
  }[]>('assets/json/themes.json');

  monthsAlpha = [
    { name: 'Janvier', nameAr: 'يناير' },
    { name: 'Fevrier', nameAr: 'فبراير' },
    { name: 'Mars', nameAr: 'مارس' },
    { name: 'Avril', nameAr: 'أبريل' },
    { name: 'Mai', nameAr: 'ماي' },
    { name: 'Juin', nameAr: 'يونيو' },
    { name: 'Juillet', nameAr: 'يوليو' },
    { name: 'Août', nameAr: 'غشت' },
    { name: 'Septembre', nameAr: 'شتنبر' },
    { name: 'Octobre', nameAr: 'اكتوبر' },
    { name: 'Novembre', nameAr: 'نونبر' },
    { name: 'Décembre', nameAr: 'دجنبر' },
  ].map((e, i) => {
    return { id: i + 1, name: e.name, nameAr: e.nameAr };
  });

  constructor(private http: HttpClient) { }

  valideDate(date: Date): Date {
    date = new Date(date);

    const hoursDiff = date.getHours() - date.getTimezoneOffset() / 60;
    const minutesDiff = (date.getHours() - date.getTimezoneOffset()) % 60;
    date.setHours(hoursDiff);
    date.setMinutes(minutesDiff);

    return date;
  }

  decoupe(r) {
    const l = r.split(';');

    l.pop();

    // // console.log(l)

    return l;
  }
}
