import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Niveau, Poste, RecruteMode } from '../Models/MdmModel';
@Injectable({
  providedIn: 'root'
})
export class MdmService {
  readonly myUrl: string = `${environment.URL}api/mdm/`;

  constructor(private http: HttpClient) { }

  getPostes() {
    return this.http.get<Poste[]>(this.myUrl + "postes");
  }

  getNiveaux() {
    return this.http.get<Niveau[]>(this.myUrl + "niveaux");
  }

  getRecrutementMode() {
    return this.http.get<RecruteMode[]>(this.myUrl + "modes");
  }
}

