import { PaysService } from './pays.service';
import { SituationReserveService } from './situation-reserve.service';
import { OrganeService } from './organe.service';
import { TraiteService } from './traite.service';
import { NotificationService } from './notification.service';
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
  notifications = new NotificationService();
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




  mecanismes = ['Examen périodique universal', 'Organes de traités', 'Procédure spéciale'];
  etats = ['Finalisée', 'clôture'];

  constructor() { }
}
