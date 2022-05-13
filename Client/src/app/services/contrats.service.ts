import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { CollabTypeContrat } from '../Models/MdmModel';

@Injectable({
  providedIn: 'root'
})
export class ContratsService {
  private CollabTypeContrat_URL: string = `${environment.URL}api/CollaborateurTypeContrats`;

  constructor(private http: HttpClient) { }

  getContratsOfCollab(id_collab: number): Observable<CollabTypeContrat[]> {
    return this.http.get<CollabTypeContrat[]>(`${this.CollabTypeContrat_URL}/collaborateur-${id_collab}`);
  }

  affecteContrat(affectation: CollabTypeContrat) {
    return this.http.post(this.CollabTypeContrat_URL, affectation);
  }

  deleteAffectation(id_affectation: number) {
    return this.http.delete(`${this.CollabTypeContrat_URL}/${id_affectation}`);
  }
}
