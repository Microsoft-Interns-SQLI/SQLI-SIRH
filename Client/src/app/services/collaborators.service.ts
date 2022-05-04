import {
  HttpClient,
  HttpErrorResponse,
  HttpEvent,
  HttpParams,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError, tap } from 'rxjs';
import { map } from 'rxjs';

import { environment } from 'src/environments/environment';
import { Collaborator } from '../Models/Collaborator';
import { PaginatedResults } from '../Models/pagination';

@Injectable({
  providedIn: 'root',
})
export class CollaboratorsService {
  readonly myUrl: string = `${environment.URL}api/Collaborateurs`;
  paginatedResult: PaginatedResults<Collaborator[]> = new PaginatedResults<
    Collaborator[]
  >();

  constructor(private http: HttpClient) { }

  getCollaboratorsList(itemsPerPage?: number, page?: number, filtrerPar?: string, search?: string, orderby?: string, orderbyCertification?:string) {
    //delay(50000);
    let params = new HttpParams();
    if (page != undefined && itemsPerPage != undefined) {
      params = params.append('pageNumber', page.toString());
      params = params.append('pageSize', itemsPerPage.toString());
    }
    if (filtrerPar != undefined) {
      params = params.append("Site", filtrerPar)
    }
    if (orderby != undefined)
      params = params.append('OrderBy', orderby.toString());

    if (search != undefined) {
      params = params.append("Search", search);
    }

    if(orderbyCertification !=undefined){
      params = params.append("OrderByCertification", orderbyCertification);
    }

    return this.http.get<any>(this.myUrl, { observe: 'response', params }).pipe(
      map((response) => {
        this.paginatedResult.result = response.body;
        if (response.headers.get('Pagination') != null) {
          this.paginatedResult.pagination = JSON.parse(
            response.headers.get('Pagination') || ''
          );
        }
        return this.paginatedResult;
      })
    );
  }

  getCollaboratorByMatricule(id: number | string): Observable<Collaborator> {
    return this.http.get<any>(this.myUrl + '/' + id, { responseType: 'json' });
  }

  addCollaborator(collabToAdd: any) {
    return this.http.post(this.myUrl, collabToAdd);
  }

  updateCollaborator(id: number | string, data: any): Observable<Collaborator> {
    return this.http.put<any>(this.myUrl + `/${id}`, data);
  }

  deleteCollaborator(id: number | string) {
    return this.http.delete(this.myUrl + `/${id}`);
  }

  importCollaborateurs(file: FormData): Observable<HttpEvent<any>> {
    return this.http
      .post<any>(this.myUrl + '/import', file, {
        reportProgress: true,
        observe: 'events',
      })
      .pipe(catchError(this.handleError));
  }

  exportCollaborateurs(){
    return this.http.get(this.myUrl+ '/export', {
      responseType: 'blob'
    })
  }
  private handleError(error: HttpErrorResponse): Observable<never> {
    if (error.status === 0 || error.status === 500)
      return throwError(() => 'Something went wrong!');
    return throwError(() => error.error);
  }
}
