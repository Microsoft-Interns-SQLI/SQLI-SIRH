import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Dashboard } from '../Models/Dashboard';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  readonly Url: string = `${environment.URL}Dashboard`;
  constructor(private http:HttpClient) { }

  getDashboard():Observable<Dashboard>
  {
    return this.http.get<Dashboard>(this.Url);
  }

}
