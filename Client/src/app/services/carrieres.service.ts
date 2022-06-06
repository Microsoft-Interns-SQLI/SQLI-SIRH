import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Carriere } from '../Models/Carriere';

@Injectable({
  providedIn: 'root'
})
export class CarrieresService {
  private Carriere_URL: string = `${environment.URL}api/Carriere`;

  constructor(private http: HttpClient) { }

  getCarrieresOfCollab(id_collab: number): Observable<Carriere[]> {
    return this.http.get<Carriere[]>(`${this.Carriere_URL}/Carrieres-du-collab-${id_collab}`);
  }

  addCarriere(carriere: Carriere) {
    return this.http.post(this.Carriere_URL, carriere);
  }

  deleteCarriere(idCarriere: number) {
    return this.http.delete(`${this.Carriere_URL}/${idCarriere}`);
  }

}
