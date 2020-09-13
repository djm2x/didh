import { SessionService } from './../../../shared/session.service';
import { Notification } from './../../../Models/models';
import { Component, OnInit, Input, EventEmitter } from '@angular/core';
import { Validators, FormGroup, FormBuilder, FormControl } from '@angular/forms';
import { Recommendation, Organisme, RecomOrg } from 'src/app/Models/models';
import { ActivatedRoute, Router } from '@angular/router';
import { UowService } from 'src/app/services/uow.service';
import { map } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { MyTranslateService } from 'src/app/my.translate.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {
  eventToChild = new EventEmitter();
  organismes = this.uow.organismes.get();
  public myForm: FormGroup;
  axes = this.uow.axes.get();
  mecanismes = this.uow.mecanismes;
  etats = this.uow.etats;
  cycles = this.uow.cycles.get();
  visites = this.uow.visites.get();
  organes = this.uow.organes.get();
  pays = this.uow.pays.get();
  sousAxes = [];

  folderToSaveInServer = 'recommandation';

  pieceJointeTo = new Subject();
  pieceJointeFrom = new Subject();
  //
  eventSubmitFromParent = new Subject();
  // syntheses = this.uow.syntheses.get();
  o = new Recommendation();
  id = 0;
  title = 'Nouveau utilisateur';
  listOrganisme: Organisme[] = [];
  constructor(private route: ActivatedRoute, private router: Router,
    private uow: UowService, private fb: FormBuilder, private session: SessionService
    , public mytranslate: MyTranslateService) { }

  ngOnInit() {

    this.createForm();
    this.pieceJointeFrom.subscribe(r => this.myForm.get('pieceJointe').setValue(r));

    setTimeout(() =>  this.pieceJointeTo.next(this.o.pieceJointe) , 100);

    this.id = +this.route.snapshot.paramMap.get('id');
    if (this.id !== 0) {
      this.uow.recommendations.getOne(this.id).subscribe(r => {
        this.o = r as Recommendation;
        // console.log(r);
        this.handleEtatAvancementChiffre(this.o.etat);

        this.o.recomOrgs.forEach(e => {
          this.listOrganisme.push({ id: e.idOrganisme } as any);
        });
        this.eventToChild.emit(this.listOrganisme);
        // this.title = 'Modifier Utilisateur';
        this.uow.sousAxes.getByIdAxe(this.o.idAxe).subscribe(s => {
          this.sousAxes = s as any[];
          setTimeout(() =>  this.pieceJointeTo.next(this.o.pieceJointe) , 100);
          this.createForm();
        });
      });
    }


  }

  get isAdmin() {
    return this.session.isAdmin;
  }

  get showEtatDavancement() {
    if ((this.myForm.get('etat').value as string).includes('cour') || (this.myForm.get('etat').value as string).includes('continue')) {
      return true;
    } else {
      return false;
    }
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      codeRecommendation: [this.o.codeRecommendation, /*Validators.required*/],
      nom: [this.o.nom, /*Validators.required*/],
      codeRecommendationAr: [this.o.codeRecommendationAr, /*Validators.required*/],
      nomAr: [this.o.nomAr, /*Validators.required*/],
      mecanisme: [this.o.mecanisme, /*Validators.required*/],
      idVisite: [this.o.idVisite],
      idOrgane: [this.o.idOrgane,],
      idCycle: [this.o.idCycle,],
      idAxe: [this.o.idAxe, /*Validators.required*/],
      idSousAxe: [this.o.idSousAxe, /*Validators.required*/],
      etat: [this.o.etat, /*Validators.required*/],
      etatAvancement: [this.o.etatAvancement],
      etatAvancementChiffre: [this.o.etatAvancementChiffre],
      observation: [this.o.observation],
      complement: [this.o.complement],
      pieceJointe: [this.o.pieceJointe],
      idPays: [this.o.idPays, /*Validators.required*/],
      annee: [this.o.annee],

      // idSynthese: [this.o.idSynthese, Validators.required],
    });
  }

  get mecanisme() { return this.myForm.get('mecanisme') as FormControl; }
  get idVisite() { return this.myForm.get('idVisite') as FormControl; }
  get idCycle() { return this.myForm.get('idCycle') as FormControl; }
  get idOrgane() { return this.myForm.get('idOrgane') as FormControl; }

  get cycleActive() {
    return this.mecanisme.value === 'Examen périodique universal';
  }

  get visiteActive() {
    return this.mecanisme.value === 'Procédure spéciale';
  }

  get organeActive() {
    return this.mecanisme.value === 'Organes de traités';
  }

  submit(form: FormGroup) {
    const recommendation = form.value;

    console.log(recommendation);
    // return;
    if (this.id === 0) {
      this.uow.recommendations.post(recommendation).subscribe((r: Recommendation) => {

        const recomOrgs: RecomOrg[] = [];
        this.listOrganisme.map(o => {
          recomOrgs.push({ idOrganisme: o.id, idRecommendation: r.id, date: new Date() } as any);
        });

        this.uow.recomOrgs.postRange(recomOrgs).subscribe(e => {
          console.log(e);

          const notif: Notification = {
            id: 0,
            date: new Date(),
            destinataire: '',
            idConcerner: r.id,
            idOrganisme: this.session.user.idOrganisme,
            message: 'Nouvelle recommandation a été ajoutée',
            priorite: 1,
            tableConcerner: 'recommandation',
            vu: false
          };
          this.uow.notifications.post(notif).subscribe(n => {
            this.router.navigateByUrl('/admin/recommendation/list');
            this.eventSubmitFromParent.next(true);
          });
        });

      });
    } else {
      this.uow.recommendations.put(recommendation.id, recommendation).subscribe((r: Recommendation) => {
        const recomOrgs: RecomOrg[] = [];
        this.listOrganisme.map(o => {
          recomOrgs.push({ idOrganisme: o.id, idRecommendation: this.o.id, date: new Date() } as any);
        });

        this.uow.recomOrgs.putRange(this.o.recomOrgs, recomOrgs).subscribe(e => {
          const notif: Notification = {
            id: 0,
            date: new Date(),
            destinataire: '',
            idConcerner: recommendation.id,
            idOrganisme: this.session.user.idOrganisme,
            message: 'La recommandation a été modifiée',
            priorite: 1,
            tableConcerner: 'recommandation',
            vu: false
          };
          this.uow.notifications.post(notif).subscribe(n => {
            this.router.navigateByUrl('/admin/recommendation/list');
            this.eventSubmitFromParent.next(true);
          });
        });
      });
    }
  }

  axeChange(idAxe: number) {
    this.uow.sousAxes.getByIdAxe(idAxe).subscribe(r => {
      this.sousAxes = r as any[];
    });
  }

  etat(etat: string) {
    console.log(etat)

    this.handleEtatAvancementChiffre(etat);
  }

  handleEtatAvancementChiffre(etat: string) {
    let v = this.myForm.get('etatAvancementChiffre').value;
    if (etat.includes('Réalisé')) {
      v = 100;
      // this.myForm.get('etatAvancementChiffre').disable({onlySelf: true, emitEvent: false});
    } else if (etat.includes('Non')){
      v = 0;
      // this.myForm.get('etatAvancementChiffre').disable({onlySelf: true, emitEvent: false});
    } else if (etat.includes('cours')){
      v = v > 5 ? v : 5;
      this.myForm.get('etatAvancementChiffre').enable();
    } else {
      this.myForm.get('etatAvancementChiffre').enable();
    }

    this.myForm.get('etatAvancementChiffre').setValue(v);
  }

  selectChange(mecanisme) {
    this.idVisite.setValue(null);
    this.idCycle.setValue(null);
    this.idOrgane.setValue(null);
    // if (this.cycleActive) {
    //   this.idCycle.setValue(null);
    // } else {

    // }
  }

  updateListOrganisme(list: Organisme[]) {
    this.listOrganisme = list;
    let i = 0;
    let b = true;
    this.listOrganisme = this.listOrganisme.filter(e => {
      if (e.id === i) {
        b = false;
      }
      i = e.id;
      return b;
    });
    // console.log('>>>>>>>>>>>>>>>>>>');
    // console.log(this.listOrganisme);
  }

  reset() {
    this.o = new Recommendation();
    this.createForm();
  }
}
