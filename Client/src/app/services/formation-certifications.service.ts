import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { environment } from 'src/environments/environment';
import { map, Observable, tap } from 'rxjs';
import { CertificationOrFormation } from '../Models/certification-formation';

export interface FormationCertificationResponse {
  list: CollabFormationCertif[];
  annees: number;
}
@Injectable({
  providedIn: 'root'
})
export class FormationCertificationsService {
  url_certif: string = `${environment.URL}api/Certification`;
  url_formation: string = `${environment.URL}api/Formation`;
  url_collab_certif: string = `${environment.URL}api/FormationCertification/certifications`;
  url_collab_formation: string = `${environment.URL}api/FormationCertification/formations`;

  opts: any = {
    responseType: 'text'
  };

  constructor(private http: HttpClient) { }


  getCertifications(): Observable<CertificationOrFormation[]> {
    return this.http.get<CertificationOrFormation[]>(this.url_certif);
  }

  getFormations(): Observable<CertificationOrFormation[]> {
    return this.http.get<CertificationOrFormation[]>(this.url_formation);
  }

  getCollabCertif(status?: number, annee?: number): Observable<FormationCertificationResponse> {

    let params: HttpParams = new HttpParams();

    if (status != undefined)
      params = params.append("status", status);
    if (annee != undefined)
      params = params.append("annee", annee);

    return this.http.get<FormationCertificationResponse>(this.url_collab_certif, { params }).pipe(
      map(data => {
        if (data.list.length != 0) {
          data.list = data.list.map((item: any) => {
          const cc: CollabFormationCertif = {
            id: item.id,
            status: item.status,
            dateDebut: item.dateDebut,
            dateFin: item.dateFin,
            collaborateurId: item.collaborateurId,
            idFormationCertif: item['certificationId'],
            name: item['certificationLibelle']
          } as CollabFormationCertif
          return cc;
        });}

        return data;
      })
    );
  }
  getCertificationByCollab(id: number, status?: number, annee?: number): Observable<FormationCertificationResponse> {
    let params: HttpParams = new HttpParams();
    if (status != undefined)
      params = params.append("status", status);
    if (annee != undefined)
      params = params.append("annee", annee);

    return this.http.get<FormationCertificationResponse>(`${this.url_collab_certif}/${id}`, { params }).pipe(
      map((data: FormationCertificationResponse) => {
        if (data.list.length != 0)
          data.list = data.list.map((item: any) => {
            const cc: CollabFormationCertif = {
              id: item.id,
              status: item.status,
              dateDebut: item.dateDebut,
              dateFin: item.dateFin,
              collaborateurId: item.collaborateurId,
              idFormationCertif: item['certificationId']
            } as CollabFormationCertif
            return cc;
          });

        return data;
      })
    );
  }
  getCollabFormation(status?: number, annee?: number): Observable<FormationCertificationResponse> {

    let params: HttpParams = new HttpParams();
    if (status != undefined)
      params = params.append("status", status);
    if (annee != undefined)
      params = params.append("annee", annee);

    return this.http.get<FormationCertificationResponse>(this.url_collab_formation, { params }).pipe(
      map((data: FormationCertificationResponse) => {
        if (data.list.length != 0) {
          data.list = data.list.map((item: any) => {
            const cc: CollabFormationCertif = {
              id: item.id,
              status: item.status,
              dateDebut: item.dateDebut,
              dateFin: item.dateFin,
              collaborateurId: item.collaborateurId,
              idFormationCertif: item['formationId']
            } as CollabFormationCertif
            return cc;
          });
        }

        return data;
      })
    );
  }
  getFormationByCollab(id: number, status?: number, annee?: number): Observable<FormationCertificationResponse> {
    let params: HttpParams = new HttpParams();
    if (status != undefined)
      params = params.append("status", status);
    if (annee != undefined)
      params = params.append("annee", annee);

    return this.http.get<FormationCertificationResponse>(`${this.url_collab_formation}/${id}`, { params }).pipe(
      map((data: FormationCertificationResponse) => {
        if (data.list.length != 0)
          data.list = data.list.map((item: any) => {
            const cc: CollabFormationCertif = {
              id: item.id,
              status: item.status,
              dateDebut: item.dateDebut,
              dateFin: item.dateFin,
              collaborateurId: item.collaborateurId,
              idFormationCertif: item['formationId']
            } as CollabFormationCertif
            return cc;
          });

        return data;
      })
    );
  }
  getFormationYears(): Observable<number[]> {
    return this.http.get<number[]>(`${this.url_collab_formation}/years`)
  }
  getFormationYearsByCollab(id: number): Observable<number[]> {
    return this.http.get<number[]>(`${this.url_collab_formation}/years/${id}`)
  }
  getCertificationYears(): Observable<number[]> {
    return this.http.get<number[]>(`${this.url_collab_certif}/years`)
  }
  getCertificationYearsByCollab(id: number): Observable<number[]> {
    return this.http.get<number[]>(`${this.url_collab_certif}/years/${id}`)
  }
  updateCollabCertif(data: CollabFormationCertif) {
    return this.http.put<CollabFormationCertif>(
      `${this.url_collab_certif}/${data.collaborateurId}/${data.idFormationCertif}`,
      {
        id: data.id,
        status: data.status,
        dateDebut: data.dateDebut,
        dateFin: data.dateFin,
        collaborateurId: data.collaborateurId,
        certificationId: data.idFormationCertif
      },
      this.opts
    );
  }
  updateCollabCertifs(collaborateurId: number, data: CollabFormationCertif[]) {

    const result = data.map(item => {
      return {
        id: item.id,
        status: item.status,
        dateDebut: item.dateDebut,
        dateFin: item.dateFin,
        collaborateurId: item.collaborateurId,
        certificationId: item.idFormationCertif
      }
    })

    return this.http.put<CollabFormationCertif[]>(
      `${this.url_collab_certif}/${collaborateurId}`,
      result
    );
  }
  updateCollabFormation(data: CollabFormationCertif) {
    

    return this.http.put<CollabFormationCertif>(
      `${this.url_collab_formation}/${data.collaborateurId}/${data.idFormationCertif}`,
      {
        id: data.id,
        status: data.status,
        dateDebut: data.dateDebut,
        dateFin: data.dateFin,
        collaborateurId: data.collaborateurId,
        formationId: data.idFormationCertif
      },
      this.opts
    );
  }

  updateCollabFormations(collaborateurId: number, data: CollabFormationCertif[]) {

    const result = data.map(item => {
      return {
        id: item.id,
        status: item.status,
        dateDebut: item.dateDebut,
        dateFin: item.dateFin,
        collaborateurId: item.collaborateurId,
        formationId: item.idFormationCertif
      }
    })

    return this.http.put<CollabFormationCertif[]>(
      `${this.url_collab_formation}/${collaborateurId}`,
      result
    );
  }

  removeCollabCertification(id:number){
    return this.http.delete<CollabFormationCertif>(`${this.url_collab_certif}/${id}`,this.opts);
  }

  removeCollabFormation(id:number){
    return this.http.delete<CollabFormationCertif>(`${this.url_collab_formation}/${id}`,this.opts);
  }


}
