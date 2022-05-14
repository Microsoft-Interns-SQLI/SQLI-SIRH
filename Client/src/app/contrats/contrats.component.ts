import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { Collaborator } from '../Models/Collaborator';
import { CollabTypeContrat } from '../Models/MdmModel';
import { ContratsService } from '../services/contrats.service';
import { ToastService } from '../shared/toast/toast.service';

@Component({
  selector: 'app-contrats',
  templateUrl: './contrats.component.html',
})
export class ContratsComponent implements OnInit {
  affectations!: CollabTypeContrat[];
  @Input() collab!: Collaborator;

  constructor(
    private contratsService: ContratsService,
    private toastService: ToastService
  ) { }

  ngOnInit(): void {
    this.getAllAffectations();
  }

  getAllAffectations() {
    this.contratsService.getContratsOfCollab(this.collab.id).subscribe((contrats) => {
      this.affectations = contrats;
    });
  }

  deleteAffectation(idAffectation: number) {
    // todo : need a confirm modal 
    if (confirm("êtes-vous sûr de vouloir désaffecté ce contrat ?")) {
      this.contratsService.deleteAffectation(idAffectation).subscribe(() => {
        this.affectations = this.affectations.filter(aff => aff.id !== idAffectation);
        this.toastService.showToast("success", "Contrat supprimé avec succès.");
      })
    }
  }

  AddAffectation(collabTypeContrat: CollabTypeContrat) {
    this.affectations.push(collabTypeContrat);
  }
}
