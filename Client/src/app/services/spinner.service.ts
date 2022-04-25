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
      bdColor: 'rgba(206,206,206,0.45)',
      color: '#808080', 
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
