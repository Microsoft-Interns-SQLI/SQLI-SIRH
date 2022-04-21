import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';


export interface Modalr{
  typeMessage : string;
  message : string;
}

@Injectable({
  providedIn: 'root'
})
export class ModalService {

  modal : Subject<Modalr> = new Subject();
  myModal!: Modalr;

  constructor() { }

  showModal(typeMessage:string,message:string){
    this.myModal = {
      typeMessage : typeMessage,
      message : message
    }
    this.modal.next(this.myModal);
    setTimeout(()=>{

    },2000);
  }

}
