import {
  HttpClient,
  HttpErrorResponse,
  HttpEvent,
  HttpParams,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError, tap, switchMap, Subscription } from 'rxjs';
import { map } from 'rxjs';

import { environment } from 'src/environments/environment';
import { Collaborator } from '../Models/Collaborator';
import { PaginatedResults } from '../Models/pagination';
import { ImagesService } from './images.service';

@Injectable({
  providedIn: 'root',
})
export class CollaboratorsService {
  readonly myUrl: string = `${environment.URL}api/Collaborateurs`;
  paginatedResult: PaginatedResults<Collaborator[]> = new PaginatedResults<
    Collaborator[]
  >();

  constructor(private http: HttpClient, private imageService: ImagesService) { }

  getCollaboratorsList(itemsPerPage?: number, page?: number, filtrerPar?: string, search?: string, orderby?: string, orderbyFormation?: string, orderbyCertification?: string) {
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
    if (orderbyFormation != undefined) {
      params = params.append("OrderByFormation", orderbyFormation);
    }

    if (orderbyCertification != undefined) {
      params = params.append("OrderByCertification", orderbyCertification);
    }
    let sub: Subscription;
    return this.http.get<any>(this.myUrl, { observe: 'response', params }).pipe(
      map((response) => {
        this.paginatedResult.result = <Collaborator[]>response.body.map((collab: Collaborator) => {
          sub = this.imageService.checkImage(collab.id).subscribe({
            next: d => {
              collab.imgPath = d ? `${environment.URL}api/Image/${collab.id}` : 'https://bootstrapious.com/i/snippets/sn-team/teacher-2.jpg';
            },
            error: er => console.log(er)
          });
          return collab;
        });
        if (response.headers.get('Pagination') != null) {
          this.paginatedResult.pagination = JSON.parse(
            response.headers.get('Pagination') || ''
          );
        }
        sub.unsubscribe();
        return this.paginatedResult;
      })
    );
  }

  getDemissionsList(itemsPerPage?: number, page?: number, filtrerPar?: string, search?: string, orderby?: string, orderbyFormation?: string, orderbyCertification?: string) {
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
    if (orderbyFormation != undefined) {
      params = params.append("OrderByFormation", orderbyFormation);
    }

    if (orderbyCertification != undefined) {
      params = params.append("OrderByCertification", orderbyCertification);
    }

    return this.http.get<any>(this.myUrl + '/demission', { observe: 'response', params }).pipe(
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

  exportCollaborateurs(lstIds?: number[]) {
    let params = new HttpParams();
    if (lstIds) {
      for (let i = 0; i < lstIds.length; i++)
        params = params.append('ids', lstIds[i]);
      }
    return this.http.get(this.myUrl + '/export', {
      responseType: 'blob',
      params
    })
  }

  getIntegrationsYearRange() : Observable<number[]> {
    return this.http.get<number[]>(this.myUrl + '/IntrgrationsRange');
  }

  getIntegrationsList(itemsPerPage?: number, page?: number, year?: number, filtrerPar?: string, search?: string, orderby?: string, orderbyFormation?: string, orderbyCertification?: string) {
    //delay(50000);
    let params = new HttpParams();
    if (year != undefined)
      params = params.append('year', year);
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
    if (orderbyFormation != undefined) {
      params = params.append("OrderByFormation", orderbyFormation);
    }

    if (orderbyCertification != undefined) {
      params = params.append("OrderByCertification", orderbyCertification);
    }

    return this.http.get<any>(this.myUrl + '/integrations', { observe: 'response', params }).pipe(
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

  private handleError(error: HttpErrorResponse): Observable<never> {
    if (error.status === 0 || error.status === 500)
      return throwError(() => 'Something went wrong!');
    return throwError(() => error.error);
  }
}
