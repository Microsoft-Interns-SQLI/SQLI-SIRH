import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable, pipe } from 'rxjs';
import { environment } from 'src/environments/environment';
import { SelectInputObject } from '../collaborateurs/add-edit-collaborateur/add-edit-form-table/_form_inputs/select-input/select-input';
import { Niveaux } from '../Models/nivaux';
import { Poste } from '../Models/Postes';

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
    return this.http.get<Niveaux[]>(this.myUrl + "niveaux");
  }

}
