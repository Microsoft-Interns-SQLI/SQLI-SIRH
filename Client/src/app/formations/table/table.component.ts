import { Component, ElementRef, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges, ViewChild } from '@angular/core';
import { Subscription } from 'rxjs';

import { Certification } from 'src/app/Models/certification';
import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollaboratorsService } from 'src/app/services/collaborators.service';
import { PopupService } from '../popup/popup.service';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit, OnDestroy, OnChanges {
  displayed: boolean = false;

  @Input() table!: CollabFormationCertif[];
  @Input() rows: Collaborator[] = [];
  @Input() cols: Certification[] = [];
  @Output() sortValue: EventEmitter<string> = new EventEmitter<string>();
  
  subPopup!: Subscription;

  newRows: { collaborateur: Collaborator, certificates: CollabFormationCertif[] }[] = [];

  constructor(private popupService: PopupService) { }



  ngOnChanges(changes: SimpleChanges): void {
    this.prepareData();
  }

  ngOnInit(): void {
    this.subPopup = this.popupService.isShow.subscribe(data => this.displayed = data);
  }

  details(certif: CollabFormationCertif) {
    this.popupService.show(certif);
  }

  boxUpdated(value: CollabFormationCertif) {
    this.newRows = this.newRows.map(item => {
      return {
        collaborateur: item.collaborateur,
        certificates: item.certificates.map(certif => {
          if (certif.certificationId === value.certificationId && certif.collaborateurId === value.collaborateurId) {
            return value;
          }
          return certif;
        })
      }
    })
  }

  sort(libelle:string){
    this.sortValue.emit(libelle);
  }
  private prepareData(){
    this.newRows = [];
    this.rows.forEach(collab => {
      let certificates: CollabFormationCertif[] = [];

      this.cols.forEach(certif => {
        const collabFormCert = this.table.find(x => x.collaborateurId === collab.id && x.certificationId === certif.id);
        if (collabFormCert != undefined) {
          certificates.push(collabFormCert);
        } else {
          certificates.push({ status: '' } as CollabFormationCertif);
        }
      });

      this.newRows.push({ collaborateur: collab, certificates: certificates })
    });
  }
  ngOnDestroy(): void {
    this.subPopup.unsubscribe();
  }
}
