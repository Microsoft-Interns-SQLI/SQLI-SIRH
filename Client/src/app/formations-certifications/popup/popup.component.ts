import { DatePipe } from '@angular/common';
import { Component, EventEmitter, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Subscription } from 'rxjs';

import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { FormationCertificationsService } from 'src/app/services/formation-certifications.service';
import { PopupService } from './popup.service';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.css']
})
export class PopupComponent implements OnInit, OnDestroy {

  errorMessage:string = '';
  selected: string = '';
  @Input() type!: string;

  @Output() certificationEvent: EventEmitter<CollabFormationCertif> = new EventEmitter<CollabFormationCertif>();

  model: CollabFormationCertif = {} as CollabFormationCertif;

  sub!: Subscription;

  statusDisabled!: boolean;
  dateFin!: Date;

  constructor(private popupService: PopupService, private formationCertifService: FormationCertificationsService, private datePipe: DatePipe) { }



  ngOnInit(): void {
    this.model = this.popupService.object;
    this.selected = this.model.status;
    this.dateFin = this.model.dateFin;

    this.statusDisabled = new Date().getTime() < new Date(this.model.dateDebut).getTime();
  }

  hideModal() {
    this.popupService.hide();
    this.errorMessage = '';
  }
  onSubmit(form: NgForm) {
    if (this.type === "formation") {
      let item: CollabFormationCertif = {
        id: this.model.id,
        collaborateurId: this.model.collaborateurId,
        idFormationCertif: this.model.idFormationCertif,
        status: form.controls['status'].value,
        dateDebut: form.controls['dateDebut'].value,
        dateFin: form.controls['dateFin'].value
      } as CollabFormationCertif

      this.sub = this.formationCertifService.updateCollabFormation(item).subscribe(
        {
          error: err=> this.errorMessage = err.error,
          complete: () => {
            this.hideModal();
            this.certificationEvent.emit(item);
          }
        }
      )
    } else if (this.type === "certification") {
      let item: CollabFormationCertif = {
        id: this.model.id,
        collaborateurId: this.model.collaborateurId,
        idFormationCertif: this.model.idFormationCertif,
        status: form.controls['status'].value,
        dateDebut: form.controls['dateDebut'].value,
        dateFin: form.controls['dateFin'].value
      } as CollabFormationCertif

      this.sub = this.formationCertifService.updateCollabCertif(item).subscribe(
        {
          error: err=> this.errorMessage = err.error,
          complete: () => {
            this.hideModal();
            this.certificationEvent.emit(item);
          }
        }
      )
    }
  }

  selectChange(value: string) {
    // if (value == "AFAIRE") {
    //   this.dateFin = new Date();
    // } else {
    //   this.dateFin = this.model.dateFin;
    // }
  }

  ngOnDestroy(): void {
    if (this.sub != undefined)
      this.sub.unsubscribe();
  }

}
