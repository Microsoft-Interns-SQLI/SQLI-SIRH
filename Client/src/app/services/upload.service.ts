import {
  HttpClient,
  HttpErrorResponse,
  HttpHeaders,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class UploadService {
  URL = environment.URL;

  constructor(private http: HttpClient) {}
  public upload(file: any): Observable<any> {
    return this.http
      .post(`${this.URL}api/upload`, file, {
        reportProgress: true,
        observe: 'events',
      })
      .pipe(catchError(this.handleError));
  }
  private handleError(error: HttpErrorResponse): Observable<never> {
    if (error.status === 0 || error.status === 500)
      return throwError(() => 'Something went wrong!');
    else if (error.status === 400) return throwError(() => error.message);
    return throwError(() => error.message);
  }
}
