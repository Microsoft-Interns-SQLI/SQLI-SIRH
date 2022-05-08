import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';

@Injectable({
  providedIn: 'root'
})
export class PopupService {

  isShow: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  certification!:CollabFormationCertif;
  constructor() { }

  show(certif: CollabFormationCertif){
    this.certification = certif;
    this.isShow.next(true);
  }

  hide(){
    this.isShow.next(false);
  }
}
