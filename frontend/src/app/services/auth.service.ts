import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private baseURL: string = `${environment.api}/WeatherForecast`;

  constructor( private readonly httpClient: HttpClient) {

   }

   test (){
    return this.httpClient.get(this.baseURL);
   }

}
