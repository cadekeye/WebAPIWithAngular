import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/observable';
import { SugarLevel } from '../models/SugarLevel';

@Injectable({
  providedIn: 'root'
})

export class SugarLevelService {
  public APIUrl = 'http://localhost:8080/api';
  public SugarLevelAPIUrl = `${this.APIUrl}/sugarlevels`;

  constructor(private http: HttpClient) { }
  getAll(): Observable<Array<SugarLevel>> {
   return this.http.get<Array<SugarLevel>>(this.SugarLevelAPIUrl);
  }

  get(id: number) {
    return this.http.get(`${this.SugarLevelAPIUrl}/${id}`);

  }

  remove(id: number) {
   return this.http.delete(`${this.SugarLevelAPIUrl}/${id}`);
  }

  save(sugarLevel: SugarLevel): Observable<SugarLevel> {
    let result: Observable<SugarLevel>;

    if (sugarLevel.id) {
      result = this.http.put<SugarLevel>(`${this.SugarLevelAPIUrl}/${sugarLevel.id}`, sugarLevel);
    } else {
      result = this.http.post<SugarLevel>(this.SugarLevelAPIUrl, sugarLevel);
    }
    return result;
  }
}
