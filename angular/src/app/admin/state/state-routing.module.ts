import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StateComponent } from './state.component';


const routes: Routes = [
  { path: 'state', redirectTo: '', pathMatch: 'full'},
  { path: '', component: StateComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StateRoutingModule { }
