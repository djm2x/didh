export class User {
  id = 0;
  nom = '';
  prenom = '';
  email = '';
  password = '';
  adresse = '';
  tel = '';
  fix = '';
  username = '';
  actif = false;
  idOrganisme = 0;
  idProfil = 0;
  organisme = new Organisme();
  profil = new Profil();
  traites: Traite[] = [];
  syhthese: Synthese[] = [];
}

export class Organisme {
  id = 0;
  label = '';
  adresse = '';
  tel = '';
  users: User[] = [];
}

export class Examen {
  id = 0;
  libelle = '';
  rapportNational = '';
  compilationHCDH = '';
  observationFinale = '';
  rapportMiParcours = '';
  discours = '';
}

export class Notification {
  id = 0;
  idConcerner = 0;
  idOrganisme = 0;
  tableConcerner = '';
  message = '';
  destinataire = '';
  date = new Date();
  vu = false;
  priorite = 1;
}

export class Traite {
  id = 0;
  nom = '';
  dateSignature = new Date();
  dateRatification = new Date();
  idUser = 0;
  conventionPiece = '';
  miseOeuvrePiece = '';
  observationPiece = '';
  analytiquePiece = '';
  discours = '';
  rapports: Rapport[] = [];
  user = new User();
}

export class FicheSynthese {
  id = 0;
  ficheUrl = '';
  idOrganisme = 0;
  idSynthese = 0;
  idUser = 0;
  organisme = new Organisme();
  synthese = new Synthese();
}

export class Rapport {
  id = 0;
  titre = '';
  dateDernierRapport = new Date();
  dateObservation = new Date();
  dateProchaineRapport = new Date();
  reference = '';
  pieceJointe = '';
  idTraite = 0;
  traite = new Traite();
  syntheses: Synthese[] = [];
}


export class Synthese {
  id = 0;
  code = '';
  detail = '';
  idRapport = null;
  idUser = 0;
  user = new User();
  rapport = new Rapport();
  syntheseRecommandations: SyntheseRecommandation[] = [];
}

export class Visite {
  id = 0;
  // objet = '';
  mandat = '';
  date = new Date();
  lienRapport = '';
  lienUpload = '';
  discours = '';
}

export class Evenement {
  id = 0;
  title = '';
  description = '';
  categorie = '';

  date = new Date();
}

export class Profil {
  id = 0;
  label = '';
}

export class RecomOrg {
  idRecommendation = 0;
  idOrganisme = 0;
  date = new Date();
  organisme = new Organisme();
  recommendation = new Recommendation();
}

export class SyntheseRecommandation {
  idRecommandation = 0;
  idSynthese = 0;
  synthese = new Synthese();
  recommendation = new Recommendation();
}

export class Recommendation {
  id = 0;
  codeRecommendation = '';
  nom = '';
  mecanisme = '';
  idCycle = 0;
  idAxe = 0;
  etat = '';
  etatAvancement = '';
  etatAvancementChiffre = 0;
  observation = '';
  pieceJointe = '';
  idOrgane = null;
  idVisite = null;
  idSousAxe = null;
  idPays = null;
  recomOrgs: RecomOrg[] = [];
  organe = new Organe();
  visite = new Visite();
  axe = new Axe();
  sousAxe = new SousAxe();
  cycle = new Cycle();
  pays = new Pays();
  syntheseRecommandations: SyntheseRecommandation[] = [];
}

export class Questionnaire {
  id = 0;
  theme = '';
  sousTheme = '';
  pieceJointe = '';
}

export class ParticipationSession {
  id = 0;
  session = '';
  discours = '';
  documents = '';
}

export class Cycle {
  id = 0;
  label = '';
}

export class Axe {
  id = 0;
  label = '';
}

export class Organe {
  id = 0;
  label = '';
  recommandations: Recommendation[] = [];
}

export class SousAxe {
  id = 0;
  label = '';
  idAxe = 0;
  axe = new Axe();
}

export class SituationReserve {
  id = 0;
  url = '';
}

export class Pays {
  id = 0;
  nom = '';
}
