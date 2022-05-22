import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

export interface Toaster {
  typeMessage: string;
  message: string;
  duration:number;
}

@Injectable({
  providedIn: 'root'
})
export class ToastService {

  toast: Subject<Toaster> = new Subject();
  myToast!: Toaster;
  constructor() { }

  showToast(typeMessage: string, message: string, durationInSec:number) {
    this.myToast = {
      typeMessage: typeMessage,
      message: message,
      duration : durationInSec
    }
    this.toast.next(this.myToast);
  }

  closeToast() {
    this.toast.next({ typeMessage: "" } as Toaster);
  }

}
