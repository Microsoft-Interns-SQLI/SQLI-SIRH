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

  selected: string = '';
  @Input() type!: string;

  @Output() certificationEvent: EventEmitter<CollabFormationCertif> = new EventEmitter<CollabFormationCertif>();

  certification: CollabFormationCertif = {} as CollabFormationCertif;

  sub!: Subscription;

  statusDisabled!: boolean;
  dateFin!: Date;

  constructor(private popupService: PopupService, private formationCertifService: FormationCertificationsService, private datePipe: DatePipe) { }



  ngOnInit(): void {
    this.certification = this.popupService.certification;
    this.selected = this.certification.status;
    this.dateFin = this.certification.dateFin;

    this.statusDisabled = new Date().getTime() < new Date(this.certification.dateDebut).getTime();
  }

  hideModal() {
    this.popupService.hide();
  }
  onSubmit(form: NgForm) {
    let item: CollabFormationCertif = {
      collaborateurId: this.certification.collaborateurId,
      id: this.certification.id,
      status: form.controls['status'].value,
      dateDebut: form.controls['dateDebut'].value,
      dateFin: form.controls['dateFin'].value,
    } as CollabFormationCertif
    if (this.type === 'certification')
      this.sub = this.formationCertifService.updateCollabCertif(item).subscribe(
        {
          complete: () => {
            this.hideModal();
            this.certificationEvent.emit(item);
          }
        }
      );
    else if(this.type ==='formation'){
      this.sub = this.formationCertifService.updateCollabFormation(item).subscribe(
        {
          complete: () => {
            this.hideModal();
            this.certificationEvent.emit(item);
          }
        }
      )
    }
  }

  selectChange(value: string) {
    if (value == "AFAIRE") {
      this.dateFin = new Date();
    } else {
      this.dateFin = this.certification.dateFin;
    }
  }

  ngOnDestroy(): void {
    if (this.sub != undefined)
      this.sub.unsubscribe();
  }

}
