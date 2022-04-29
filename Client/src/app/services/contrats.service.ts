import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ContratsService {
  private GetContratsByCollaborateur_URL: string = `${environment.URL}/`;

  constructor(
    private http: HttpClient
  ) { }

  getContratsOfCollab(id_collab: number): Observable<any> {
    return this.http.get<any>(this.GetContratsByCollaborateur_URL);
  }
}
