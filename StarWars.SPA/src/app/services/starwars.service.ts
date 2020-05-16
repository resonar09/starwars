import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StarWarsService {
  baseUrl = 'http://localhost:5000/';
  constructor(private http: HttpClient) { }

  getCharacters(){
    console.log(this.http.get(this.baseUrl + 'starwars'));
    return this.http.get(this.baseUrl + 'starwars');
  }
}
