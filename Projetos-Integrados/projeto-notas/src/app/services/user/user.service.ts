import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private https: HttpClient) { }

  testeApi() {
    return this.https.get('');
    //dentro do get vai o link da API
  }
}
