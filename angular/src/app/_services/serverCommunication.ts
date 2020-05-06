 
import { HttpClient } from '@angular/common/http'; 
import { Injectable } from '@angular/core';
@Injectable({ providedIn: 'root' })
export class ServerCommunication {


  constructor(private http: HttpClient) {

  }

  get(url: string,out : any) {
     this.http.get<any>(url).subscribe(
    data => {
      out = data;
      console.log(data);
    },
    error => {
      console.log(error)
    });

   
  }
}
