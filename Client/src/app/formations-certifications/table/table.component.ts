import { Component, ElementRef, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges, ViewChild } from '@angular/core';
import { Subscription } from 'rxjs';

import { CertificationOrFormation } from 'src/app/Models/certification-formation';
import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { Collaborator } from 'src/app/Models/Collaborator';
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
  @Input() cols: CertificationOrFormation[] = [];
  @Input() type!: boolean;
  @Input() yearSelected!: number;
  @Output() sortValue: EventEmitter<string> = new EventEmitter<string>();
  @Output() yearChanged: EventEmitter<number> = new EventEmitter<number>();

  subPopup!: Subscription;

  newRows: { collaborateur: Collaborator, certificates: CollabFormationCertif[] }[] = [];

  libelle: string = "test";

  constructor(private popupService: PopupService) { }



  ngOnChanges(changes: SimpleChanges): void {
    this.prepareData();
  }

  ngOnInit(): void {
    this.subPopup = this.popupService.isShow.subscribe(data => this.displayed = data);
  }

  details(model: CollabFormationCertif) {
    this.popupService.show(model);
  }

  boxUpdated(value: CollabFormationCertif) {
    this.yearChanged.emit(new Date(value.dateDebut).getFullYear());
    this.newRows = this.newRows.map(item => {
      return {
        collaborateur: item.collaborateur,
        certificates: item.certificates.map(certif => {
          if (certif.idFormationCertif === value.idFormationCertif && certif.collaborateurId === value.collaborateurId && new Date(value.dateDebut).getFullYear() === this.yearSelected) {
            return value;
          }
          return certif;
        })
      }
    })
  }
  boxDelete(id: number) {
    const index = this.table.findIndex(x => x.id === id);
    if (index !== -1){
      this.table.splice(index, 1);
      this.prepareData();
    }
  }
  sort(libelle: string) {
    this.sortValue.emit(libelle);
    this.libelle = libelle;
  }

  private prepareData() {
    this.newRows = [];
    this.rows.forEach(collab => {
      let certificates: CollabFormationCertif[] = [];

      this.cols.forEach(certif => {
        const collabFormCert = this.table.find(x => x.collaborateurId === collab.id && x.idFormationCertif === certif.id);

        if (collabFormCert != undefined) {
          certificates.push(collabFormCert);
        } else {
          certificates.push({ status: '', collaborateurId: collab.id, idFormationCertif: certif.id } as CollabFormationCertif);
        }
      });

      this.newRows.push({ collaborateur: collab, certificates: certificates })

    });


  }
  ngOnDestroy(): void {
    this.subPopup.unsubscribe();
  }
}
