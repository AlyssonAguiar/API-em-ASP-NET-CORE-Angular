import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {Observable, tap} from 'rxjs';
import {IUsuario} from './IUsuario';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="https://localhost:5001/ApiFormulario/Usuarios";
private headers: HttpHeaders;

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
   }

  // getUsuariosList():Observable<any[]>{
  //   return this.http.get<any>(this.APIUrl+'/')
  // }

  postUsuario(usuario: IUsuario){
    return this.http.post<IUsuario>(this.APIUrl+'/',usuario, {headers: this.headers}).toPromise();
  }

  getUsuarios(){
    return this.http.get<IUsuario[]>(this.APIUrl+'/', {headers: this.headers}); //toPromise()
  }

}
