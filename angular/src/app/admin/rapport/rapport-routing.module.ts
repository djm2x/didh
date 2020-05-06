import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './list/list.component';
import { UpdateComponent } from './update/update.component';
import { RapportComponent } from './rapport.component';
import { ChildRouteGuard } from '../guard/child-route.guard';


const routes: Routes = [
  { path: '', redirectTo: '', pathMatch: 'full' },
  {
    path: '', component: RapportComponent,
    children: [
      { path: '', redirectTo: 'list', pathMatch: 'full' },
      { path: 'list', component: ListComponent },
      { path: 'update/:id', component: UpdateComponent },
    ],
    canActivate: [ChildRouteGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RapportRoutingModule { }
