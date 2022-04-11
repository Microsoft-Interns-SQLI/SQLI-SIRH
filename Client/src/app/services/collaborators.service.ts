import {
  HttpClient,
  HttpErrorResponse,
  HttpEvent,
  HttpEventType,
  HttpParams,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, tap, throwError, delay } from 'rxjs';
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

  constructor(private http: HttpClient) {}

  getCollaboratorsList(itemsPerPage?: number, page?: number) {
    delay(50000);
    let params = new HttpParams();
    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page.toString());
      params = params.append('pageSize', itemsPerPage.toString());
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

  updateCollaborator(id: number | string, data: any) {
    return this.http.put(this.myUrl + `/${id}`, data);
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

  private handleError(error: HttpErrorResponse): Observable<never> {
    if (error.status === 0 || error.status === 500)
      return throwError(() => 'Something went wrong!');
    return throwError(() => error.error);
  }
}