import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { delay, finalize, Observable } from 'rxjs';
import { SpinnerService } from '../services/spinner.service';

@Injectable()
export class LoadingInterceptor implements HttpInterceptor {

  constructor(private spinnerService: SpinnerService) { }

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {

    let runLoading: boolean = false;
    this.spinnerService.isSearch.subscribe((data: boolean) => {
      runLoading = data;
    })

    if (!runLoading) {
      this.spinnerService.loading();
      return next.handle(request).pipe(
        delay(400),
        finalize(() => {
          this.spinnerService.idle();
        })
      )
    }
    return next.handle(request);

  }
}
