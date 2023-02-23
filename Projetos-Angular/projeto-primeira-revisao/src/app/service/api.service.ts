import { ApiReturn } from './../models/api-return';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  public URL_API:string = 'https://rickandmortyapi.com/api/character';

  constructor(public http: HttpClient) { }

  //Pega o retorno das informações da API
  getCharactersList() {
    return this.http.get<ApiReturn>(this.URL_API);
  }
}
