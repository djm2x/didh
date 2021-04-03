import { SessionService } from 'src/app/shared';



import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { Validators, FormGroup, FormBuilder } from '@angular/forms';
import { Synthese, Recommendation } from 'src/app/Models/models';
import { ActivatedRoute, Router } from '@angular/router';
import { UowService } from 'src/app/services/uow.service';
import { SnackBarService } from 'src/app/loader/snack-bar.service';
import { TabNavigationService } from './tab-navigation.service';
import { Subject } from 'rxjs';
import { MatTabGroup } from '@angular/material/tabs';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {
  @ViewChild('matgroup', { static: true }) matTab: MatTabGroup;
  recommendations = this.uow.recommendations.get();
  public myForm: FormGroup;
  cycles = this.uow.cycles.get();
  o = new Synthese();
  id = 0;
  title = 'Synthese';

  folderToSaveInServer = 'synthese';

  lienUploadTo = new Subject();
  lienUploadFrom = new Subject();

  eventSubmitFromParent = new Subject();

  listRecommendation: Recommendation[] = [];
  eventToChild = new EventEmitter();

  constructor(private route: ActivatedRoute, private snack: SnackBarService,
    private uow: UowService, private fb: FormBuilder, private session: SessionService
    , private navTab: TabNavigationService, private router: Router) { }

  ngOnInit() {
    this.o.idUser = this.session.user.id;

    this.createForm();

    this.id = +this.route.snapshot.paramMap.get('id');

    this.lienUploadFrom.subscribe(r => this.myForm.get('lienUpload').setValue(r));

    setTimeout(() => {
      this.lienUploadTo.next(this.o.lienUpload);
    }, 100);

    if (this.id !== 0) {
      this.uow.syntheses.getOne(this.id).subscribe(r => {
        // // console.log(r)
        this.o = r as Synthese;
        // this.o.syntheseRecommandations.forEach(e => {
        //   this.listRecommendation.push(e.recommendation);
        // });

        this.title = 'Modifier synthese';
        this.eventToChild.emit(this.o.syntheseRecommandations);
        // // console.log('la lissssssssssssssssste', this.o.syntheseRecommandations);
        this.createForm();
      });
    }

    this.navTab.navigateTo.subscribe(index => this.matTab.selectedIndex = index);
  }

  createForm() {
    this.myForm = this.fb.group({
      id: this.o.id,
      code: [this.o.code, Validators.required],
      detail: [this.o.detail, Validators.required],
      detailAr: [this.o.detailAr, Validators.required],
      idUser: [this.o.idUser, Validators.required],
      lienUpload: [this.o.lienUpload, Validators.required],
    });
  }

  submit(form: FormGroup) {
    const o = form.value;
    // // console.log(form)
    if (this.id === 0) {


      this.uow.syntheses.post(o).subscribe((s: Synthese) => {
        // const recomOrgs: RecomOrg[] = [];

        // const notif: any = {
        //   id: 0,
        //   date: new Date(),
        //   destinataire: '',
        //   idConcerner: s.id,
        //   idOrganisme: this.session.user.idOrganisme,
        //   message: 'Nouvelle synthèse a été ajoutée',
        //   priorite: 1,
        //   tableConcerner:   'synthese',
        //   vu: false
        // };

        // this.uow.notifications.post(notif).subscribe(n => {
        // });
        // // this.snack.notifyOk('Nouveau synthèse a été ajoutée');
        // this.o = s;
        // this.navTab.navigateTo.next(1);
        this.eventSubmitFromParent.next(true);

        this.router.navigateByUrl('/admin/synthese/list');
      });

      /*
            this.uow.syntheses.post(o).subscribe(r => {
              this.router.navigateByUrl('/admin/synthese/list');

              this.uow.recomOrgs.postRange(recomOrgs).subscribe(e => {
                // console.log(e);
                this.router.navigateByUrl('/admin/recommendation/list');
              });


            }); */
    } else {
      this.uow.syntheses.put(o.id, o).subscribe((r: Synthese) => {
        // const notif: any = {
        //   id: 0,
        //   date: new Date(),
        //   destinataire: '',
        //   idConcerner: o.id,
        //   message: 'La synthèse a été modifiée',
        //   priorite: 1,
        //   tableConcerner: 'synthese',
        //   vu: false
        // };
        // this.uow.notifications.post(notif).subscribe(n => {
        // });

        // this.navTab.navigateTo.next(1);

        this.eventSubmitFromParent.next(true);
        this.router.navigateByUrl('/admin/synthese/list');

      });
    }
  }

  reset() {
    this.o = new Synthese();
    this.createForm();
  }





  updateListRecommendation(list: Recommendation[]) {
    this.listRecommendation = list;
    let i = 0;
    let b = true;
    this.listRecommendation = this.listRecommendation.filter(e => {
      if (e.id === i) {
        b = false;
      }
      i = e.id;
      return b;
    });
    // // console.log('>>>>>>>>>>>>>>>>>>');
    // // console.log(this.listRecommendation);
  }


}
