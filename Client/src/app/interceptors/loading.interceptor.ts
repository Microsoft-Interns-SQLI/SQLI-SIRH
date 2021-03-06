import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { delay, finalize, map, Observable, Subscription, take, tap } from 'rxjs';
import { SpinnerService } from '../services/spinner.service';
import { environment } from 'src/environments/environment';

const url: string = environment.URL;
@Injectable()
export class LoadingInterceptor implements HttpInterceptor {

  constructor(private spinnerService: SpinnerService) { }

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
      this.spinnerService.loading();
      return next.handle(request).pipe(
        delay(100),
        finalize(() => {
          this.spinnerService.idle();
        })
      )
  }

}
