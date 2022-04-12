import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

export interface Toaster {
  typeMessage: string;
  message: string;
}

@Injectable({
  providedIn: 'root'
})
export class ToastService {

  toast: Subject<Toaster> = new Subject();
  myToast!: Toaster;
  constructor() { }

  showToast(typeMessage: string, message: string) {
    this.myToast = {
      typeMessage: typeMessage,
      message: message
    }
    this.toast.next(this.myToast);
    setTimeout(()=>{

    },2000);
    
  }

}
