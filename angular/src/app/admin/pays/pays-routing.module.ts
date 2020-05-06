import { PaysComponent } from './pays.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: 'pays', redirectTo: '', pathMatch: 'full'},
  { path: '', component: PaysComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PaysRoutingModule { }
