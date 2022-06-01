import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';

@Injectable({
  providedIn: 'root'
})
export class PopupService {

  isShow: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  object!: CollabFormationCertif;

  constructor() { }

  show(model: CollabFormationCertif) {
    this.object = model;
    this.isShow.next(true);
  }

  hide() {
    this.isShow.next(false);
  }
}
