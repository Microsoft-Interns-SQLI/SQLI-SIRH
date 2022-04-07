import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class UploadService {
  URL = environment.URL;

  constructor(private http: HttpClient) {}
  public upload(file: any): Observable<any> {
    return this.http.post(`${this.URL}api/upload`, file, {
      reportProgress: true,
    });
  }
}
