import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CountryModel } from '../Model/CountryModel';



@Injectable({
  providedIn: 'root'
})
export class DataFetchService {

  url:string;
  constructor(private http:HttpClient) {
    this.url = "https://localhost:44345/api/Countries/";
   }

  getdata(): Observable<CountryModel[]>{
    return this.http.get<CountryModel[]>(this.url);
    
  }
}
