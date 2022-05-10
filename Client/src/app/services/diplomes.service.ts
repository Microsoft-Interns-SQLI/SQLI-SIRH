import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Diplome } from '../Models/MdmModel';

@Injectable({
  providedIn: 'root'
})
export class DiplomesService {
  private Diplomes_URL: string = `${environment.URL}api/Diplomes`;


  constructor(private httpClient: HttpClient) { }

  deleteDiplome(idDiplome: number) {
    return this.httpClient.delete(`${this.Diplomes_URL}/${idDiplome}`);
  }

  updateDiplome() {
    console.log("update diplomes");
  }

  addDiplome(diplome: Diplome) {
    return this.httpClient.post(this.Diplomes_URL, diplome);
  }

  getAllDiplomes(): Observable<Diplome[]> {
    return this.httpClient.get<Diplome[]>(`${this.Diplomes_URL}`);
  }

  getCollabDiplomes(idCollab: number): Observable<Diplome[]> {
    return this.httpClient.get<Diplome[]>(`${this.Diplomes_URL}/collab-${idCollab}`);
  }
}
