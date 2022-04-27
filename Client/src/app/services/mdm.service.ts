import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import {
  Contrat,
  Niveau,
  Poste,
  RecruteMode,
  Site,
  SkillCenter,
} from '../Models/MdmModel';
@Injectable({
  providedIn: 'root',
})
export class MdmService {
  readonly myUrl: string = `${environment.URL}api/mdm/`;

  constructor(private http: HttpClient) {}

  //Postes

  getPostes() {
    return this.http.get<Poste[]>(this.myUrl + 'postes');
  }

  getPoste(id: number): Observable<Poste> {
    return this.http.get<Poste>(`${this.myUrl}postes/${id}`);
  }

  addPoste(poste: any) {
    return this.http.post<Poste>(`${this.myUrl}postes/`, poste);
  }

  updatePoste(id: number, poste: any) {
    return this.http.put<Poste>(`${this.myUrl}postes/${id}`, poste);
  }

  deletePoste(id: number) {
    return this.http.delete(`${this.myUrl}postes/${id}`);
  }
  //Niveaux

  getNiveaux() {
    return this.http.get<Niveau[]>(this.myUrl + 'niveaux');
  }

  getNiveau(id: number): Observable<Niveau> {
    return this.http.get<Niveau>(`${this.myUrl}niveaux/${id}`);
  }

  addNiveau(niveau: any) {
    return this.http.post<Niveau>(`${this.myUrl}niveaux/`, niveau);
  }

  updateNiveau(id: number, niveau: any) {
    return this.http.put<Niveau>(`${this.myUrl}niveaux/${id}`, niveau);
  }

  deleteNiveau(id: number) {
    return this.http.delete(`${this.myUrl}niveaux/${id}`);
  }
  //Mode de recrutement

  getRecrutementMode() {
    return this.http.get<RecruteMode[]>(this.myUrl + 'modes');
  }

  getMode(id: number): Observable<RecruteMode> {
    return this.http.get<RecruteMode>(`${this.myUrl}modes/${id}`);
  }

  addMode(mode: any) {
    return this.http.post<RecruteMode>(`${this.myUrl}modes/`, mode);
  }

  updateMode(id: number, mode: any) {
    return this.http.put<RecruteMode>(`${this.myUrl}modes/${id}`, mode);
  }

  deleteMode(id: number) {
    return this.http.delete(`${this.myUrl}modes/${id}`);
  }

  //Sites

  getSites() {
    return this.http.get<Site[]>(this.myUrl + 'sites');
  }

  getSite(id: number): Observable<Site> {
    return this.http.get<Site>(`${this.myUrl}sites/${id}`);
  }

  addSite(site: any) {
    return this.http.post<Site>(`${this.myUrl}sites/`, site);
  }

  updateSite(id: number, site: any) {
    return this.http.put<Site>(`${this.myUrl}sites/${id}`, site);
  }

  deleteSite(id: number) {
    return this.http.delete(`${this.myUrl}sites/${id}`);
  }

  //Skill Centers

  getSkillCenters() {
    return this.http.get<SkillCenter[]>(this.myUrl + 'skillcenters');
  }

  getSkillCenter(id: number): Observable<SkillCenter> {
    return this.http.get<SkillCenter>(`${this.myUrl}skillcenters/${id}`);
  }

  addSkillCenter(skillcenter: any) {
    return this.http.post<SkillCenter>(
      `${this.myUrl}skillcenters/`,
      skillcenter
    );
  }

  updateSkillCenter(id: number, skillcenter: any) {
    return this.http.put<SkillCenter>(
      `${this.myUrl}skillcenters/${id}`,
      skillcenter
    );
  }

  deleteSkillCenter(id: number) {
    return this.http.delete(`${this.myUrl}skillcenters/${id}`);
  }

  //Types Contrats

  getContrats() {
    return this.http.get<Contrat[]>(this.myUrl + 'contrats');
  }

  getContrat(id: number): Observable<Contrat> {
    return this.http.get<Contrat>(`${this.myUrl}contrats/${id}`);
  }

  addContrat(contrat: any) {
    return this.http.post<Contrat>(`${this.myUrl}contrats/`, contrat);
  }

  updateContrat(id: number, contrat: any) {
    return this.http.put<Contrat>(`${this.myUrl}contrats/${id}`, contrat);
  }

  deleteContrat(id: number) {
    return this.http.delete(`${this.myUrl}contrats/${id}`);
  }
}
