import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms';

import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { PopupService } from './popup.service';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.css']
})
export class PopupComponent implements OnInit {

  selected:string = '';

  certification!:CollabFormationCertif;

  constructor(private popupService: PopupService) { }


  ngOnInit(): void {
    this.certification = this.popupService.certification;
    this.selected = this.certification.status;
  }

  hideModal(){
    this.popupService.hide();
  }
  onSubmit(form: NgForm){

  }

}
