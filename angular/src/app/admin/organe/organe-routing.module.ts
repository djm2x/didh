import { OrganeComponent } from './organe.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: 'organe', redirectTo: '', pathMatch: 'full'},
  { path: '', component: OrganeComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrganeRoutingModule { }
