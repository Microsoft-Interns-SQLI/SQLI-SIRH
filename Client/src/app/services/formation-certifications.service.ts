import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { environment } from 'src/environments/environment';
import { map, Observable, tap } from 'rxjs';
import { CertificationOrFormation } from '../Models/certification-formation';

@Injectable({
  providedIn: 'root'
})
export class FormationCertificationsService {
  url_certif: string = `${environment.URL}api/Certification`;
  url_formation: string = `${environment.URL}api/Formation`;
  url_collab_certif: string = `${environment.URL}api/FormationCertification/certifications`;
  url_collab_formation: string = `${environment.URL}api/FormationCertification/formations`;


  constructor(private http: HttpClient) { }


  getCertifications(): Observable<CertificationOrFormation[]> {
    return this.http.get<CertificationOrFormation[]>(this.url_certif);
  }

  getFormations(): Observable<CertificationOrFormation[]> {
    return this.http.get<CertificationOrFormation[]>(this.url_formation);
  }

  getCollabCertif(): Observable<CollabFormationCertif[]> {
    return this.http.get<CollabFormationCertif[]>(this.url_collab_certif).pipe(
      map(data=> data.map((item:any)=>{
        const cc:CollabFormationCertif = {
          status: item.status,
          dateDebut:item.dateDebut, 
          dateFin:item.dateFin,
          collaborateurId:item.collaborateurId,
          id: item['certificationId']
        } as CollabFormationCertif
         return cc;})
      )
    );
  }
  getCollabFormation(): Observable<CollabFormationCertif[]> {
    return this.http.get<CollabFormationCertif[]>(this.url_collab_formation).pipe(
      map(data=> data.map((item:any)=>{
        const cc:CollabFormationCertif = {
          status: item.status,
          dateDebut:item.dateDebut, 
          dateFin:item.dateFin,
          collaborateurId:item.collaborateurId,
          id: item['formationId']
        } as CollabFormationCertif
         return cc;})
      )
    );
  }

  updateCollabCertif(data: CollabFormationCertif) {
    const opts: any = {
      responseType: 'text'
    };
    return this.http.put<CollabFormationCertif>(
      `${this.url_collab_certif}/${data.collaborateurId}/${data.id}`,
      {
        status: data.status,
        dateDebut: data.dateDebut, 
        dateFin: data.dateFin, 
        collaborateurId: data.collaborateurId, 
        certificationId: data.id
      },
      opts
    );
  }
  updateCollabFormation(data: CollabFormationCertif) {
    const opts: any = {
      responseType: 'text'
    };

    return this.http.put<CollabFormationCertif>(
      `${this.url_collab_formation}/${data.collaborateurId}/${data.id}`,
      {
        status: data.status,
        dateDebut: data.dateDebut, 
        dateFin: data.dateFin, 
        collaborateurId: data.collaborateurId, 
        formationId: data.id
      },
      opts
    );
  }

}
