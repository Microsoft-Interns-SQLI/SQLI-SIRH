import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class MdmService {
  readonly myUrl: string = `${environment.URL}api/mdm/`;

  constructor(private http: HttpClient) {}

  getAll(mdmItem: string) {
    return this.http.get<any[]>(`${this.myUrl}${mdmItem}/`);
  }

  getById(mdmItem: string, id: number): Observable<any> {
    return this.http.get<any>(`${this.myUrl}${mdmItem}/${id}`);
  }

  add(mdmItem: string, item: any) {
    return this.http.post<any>(`${this.myUrl}${mdmItem}/`, item);
  }

  update(mdmItem: string, id: number, item: any) {
    return this.http.put<any>(`${this.myUrl}${mdmItem}/${id}`, item);
  }

  delete(mdmItem: string, id: number) {
    return this.http.delete(`${this.myUrl}${mdmItem}/${id}`);
  }

  // Reasons Demission

  getReasonDemissions() {
    return this.http.get<Contrat[]>(this.myUrl + 'reasondemission');
  }

  getReasonDemission(id: number): Observable<Contrat> {
    return this.http.get<Contrat>(`${this.myUrl}reasondemission/${id}`);
  }

  addReasonDemission(contrat: any) {
    return this.http.post<Contrat>(`${this.myUrl}reasondemission/`, contrat);
  }

  updateReasonDemission(id: number, contrat: any) {
    return this.http.put<Contrat>(`${this.myUrl}reasondemission/${id}`, contrat);
  }

  deleteReasonDemission(id: number) {
    return this.http.delete(`${this.myUrl}reasondemission/${id}`);
  }

}
