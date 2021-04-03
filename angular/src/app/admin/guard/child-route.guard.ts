import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { SessionService } from 'src/app/shared';

@Injectable({
  providedIn: 'root'
})
export class ChildRouteGuard implements CanActivate {

  constructor(private session: SessionService, private router: Router) { }

  canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
    // console.log(state)
    if (state.url.includes('update') && !this.session.isAdmin && !this.session.isProprietaire) {
      this.router.navigate(['/admin']);
      return false;
    }
    return true;
  }
}
