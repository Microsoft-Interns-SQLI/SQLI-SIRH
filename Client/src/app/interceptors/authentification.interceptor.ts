import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable()
export class AuthentificationInterceptor implements HttpInterceptor {

  url: string = environment.URL;

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    
    if(request.url === `${this.url}login`){
      return next.handle(request);
    }
      
    const token = localStorage.getItem("token");

    const req = request.clone({headers: request.headers.append("Authorization", "Bearer "+token)});

    return next.handle(req);
  }
}
