import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SpinnerService {

  isSearch:BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  loadingRequestCount = 0;

  constructor(private ngxSpinnerService: NgxSpinnerService) { }

  loading() {
    this.loadingRequestCount++;
    this.ngxSpinnerService.show(undefined, {
      bdColor: 'rgba(255,255,255,0)',
      color: '#333333',
      
    });
  }

  idle() {
    this.loadingRequestCount--;
    if (this.loadingRequestCount <= 0) {
      this.loadingRequestCount = 0;
      this.ngxSpinnerService.hide();

    }
  }

}
