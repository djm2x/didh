import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './admin.component';
import { AdminGuard } from './guard/admin.guard';
import { PublicGuard } from './guard/state.guard';

const routes: Routes = [
  { path: '', redirectTo: '', pathMatch: 'full' },
  {
    path: '', component: AdminComponent,
    children: [
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', loadChildren: () => import('./home/home.module').then(m => m.HomeModule), },
      { path: 'home1', loadChildren: () => import('./home1/home1.module').then(m => m.Home1Module), },
      {
        path: 'participation-session', loadChildren: () =>
          import('./participation-session/participation-session.module').then(m => m.ParticipationSessionModule),
      },
      { path: 'questionnaire', loadChildren: () => import('./questionnaire/questionnaire.module').then(m => m.QuestionnaireModule), canActivate: [PublicGuard] },
      { path: 'state', loadChildren: () => import('./state/state.module').then(m => m.StateModule), canActivate: [PublicGuard]},
      { path: 'user', loadChildren: () => import('./user/user.module').then(m => m.UserModule), canActivate: [AdminGuard] },
      { path: 'pays', loadChildren: () => import('./pays/pays.module').then(m => m.PaysModule) },
      { path: 'synthese', loadChildren: () => import('./synthese/synthese.module').then(m => m.SyntheseModule), },
      { path: 'organisme', loadChildren: () => import('./organisme/organisme.module').then(m => m.OrganismeModule), },
      { path: 'profil', loadChildren: () => import('./profil/profil.module').then(m => m.ProfilModule), canActivate: [AdminGuard] },
      {
        path: 'recommendation',
        loadChildren: () => import('./recommendation/recommendation.module').then(m => m.RecommendationModule),
      },
      { path: 'cycle', loadChildren: () => import('./cycle/cycle.module').then(m => m.CycleModule), canActivate: [AdminGuard] },
      { path: 'axe', loadChildren: () => import('./axe/axe.module').then(m => m.AxeModule), canActivate: [AdminGuard] },
      { path: 'sous-axe', loadChildren: () => import('./sous-axe/sous-axe.module').then(m => m.SousAxeModule), canActivate: [AdminGuard] },
      { path: 'organe', loadChildren: () => import('./organe/organe.module').then(m => m.OrganeModule), canActivate: [AdminGuard] },

      { path: 'examen', loadChildren: () => import('./examen/examen.module').then(m => m.ExamenModule), },
      { path: 'rapport', loadChildren: () => import('./rapport/rapport.module').then(m => m.RapportModule), },
      { path: 'visite', loadChildren: () => import('./visite/visite.module').then(m => m.VisiteModule), },

      { path: 'compte', loadChildren: () => import('./compte/compte.module').then(m => m.CompteModule), canActivate: [AdminGuard] },
      {
        path: 'evenement', loadChildren: () =>
          import('./evenement/evenement.module').then(m => m.EvenementModule), data: { animation: 'evenement' }
      },

    ]
  },
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
