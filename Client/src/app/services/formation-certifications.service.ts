import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import {environment} from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Certification } from '../Models/certification';

@Injectable({
  providedIn: 'root'
})
export class FormationCertificationsService {
  url_certif:string = `${environment.URL}api/Certification`;
  url_formation_certif:string = `${environment.URL}api/FormationCertification`;

  constructor(private http: HttpClient) { }


  getCertifications():Observable<Certification[]>{
    return this.http.get<Certification[]>(this.url_certif);
  }

  getCollabCertif():Observable<CollabFormationCertif[]>{
    return this.http.get<CollabFormationCertif[]>(this.url_formation_certif);
  }

}
