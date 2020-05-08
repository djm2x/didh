import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ParticipationSessionComponent } from './participation-session.component';


const routes: Routes = [
  { path: '', redirectTo: 'list', pathMatch: 'full'},
  { path: 'list', component: ParticipationSessionComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ParticipationSessionRoutingModule { }
