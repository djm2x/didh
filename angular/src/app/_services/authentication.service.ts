import { Injectable, ViewChild, ElementRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class AuthenticationService { 
    private currentUserSubject: BehaviorSubject<any>;
    public currentUser: Observable<any>;

    constructor(private http: HttpClient) {
        this.currentUserSubject = new BehaviorSubject<any>(JSON.parse(localStorage.getItem('currentUser')));
        this.currentUser = this.currentUserSubject.asObservable();
    }

    public get currentUserValue() {
        return this.currentUserSubject.value;
    }

    login(Email, password) {
       

        // return this.http.post<any>(`http://localhost:56596/api/users/log`, { "Nom":username,"Password":password})
        // .pipe(map(user => {
        //     // store user details and jwt token in local storage to keep user logged in between page refreshes
        //     localStorage.setItem('currentUser', JSON.stringify(user));
        //     this.currentUserSubject.next(user);
        //     return user;
        // })); 

        return this.http.post<any>(`https://localhost:44364/api/users/log`, {"id" : 0 ,
         "Nom":"",
          "Prenom": "" ,
          "Email":Email,
          "Password":password
        }).pipe(map(user => {
                // store user details and jwt token in local storage to keep user logged in between page refreshes
                localStorage.setItem('currentUser', JSON.stringify(user));
                this.currentUserSubject.next(user);

            })); 


        // this.http.post<any>(`http://localhost:56596/api/users/register`,
        // {"id" : 12 ,
        //  "Nom":"soufiane2",
        //   "Prenom": "pass2" ,
        //   "Email":"email23",
        //   "Password":"pass2"
        // })
        // .pipe(map(user => {
        //     // store user details and jwt token in local storage to keep user logged in between page refreshes
        //     console.log(user)
        // }));


    }

    logout() {
        // remove user from local storage and set current user to null
        localStorage.removeItem('currentUser');
        this.currentUserSubject.next(null);
    }
}