import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

export interface Toaster {
  typeMessage: string | undefined;
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

    window.setTimeout(()=>{
      this.toast.next({ typeMessage: undefined } as Toaster);
    },durationInSec*1000);
    
  }

  closeToast() {
    this.toast.next({ typeMessage: "" } as Toaster);
  }

}
