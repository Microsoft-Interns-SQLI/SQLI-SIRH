import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class SpinnerService {

  loadingRequestCount = 0;

  constructor(private ngxSpinnerService: NgxSpinnerService) { }

  loading() {
    this.loadingRequestCount++;
    this.ngxSpinnerService.show(undefined, {
      type: 'ball-scale-multiple',
      bdColor: 'rgba(255,255,255,0)',
      color: '#333333'
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
