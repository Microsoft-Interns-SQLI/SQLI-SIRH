import { HttpClient, HttpErrorResponse, HttpEvent } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, Observable, tap, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ImagesService {

  readonly myUrl: string = `${environment.URL}api/Image`;

  constructor(private http: HttpClient) { }

  upload(data: FormData, id: number) {
    return this.http.post(`${this.myUrl}/${id}`, data, {
      reportProgress: true,
      observe: "events"
    }).pipe(
      catchError(this.handleError)
    );
  }

  checkImage(id:number){
    return this.http.get(`${environment.URL}api/Image/${id}`, {responseType:'text'}).pipe(
      catchError(this.handleError)
    )
  }
  private handleError(error: HttpErrorResponse) {
    if (error.status === 400 || error.status === 500)
      return throwError(() => error.error);
    if(error.status === 404)
      return throwError(()=> 'Data not found');

    return throwError(() => 'Something went wrong!');

  }
}
