import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollabTypeContrat } from 'src/app/Models/CollabTypeContrat';
import { Contrat } from 'src/app/Models/MdmModel';
import { ContratsService } from 'src/app/services/contrats.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';
import { ToastService } from 'src/app/shared/toast/toast.service';

@Component({
  selector: 'app-contrats',
  templateUrl: './contrats.component.html',
})
@AutoUnsubscribe()
export class ContratsComponent implements OnInit {
  affectations!: CollabTypeContrat[];
  @Input() collab!: Collaborator;
  contratToDelete?: CollabTypeContrat;

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
    this.affectations = this.affectations.filter(aff => aff.id !== idAffectation);
    this.toastService.showToast("success", "Contrat supprimé avec succès.", 2);
  }

  AddAffectation(collabTypeContrat: CollabTypeContrat) {
    this.affectations.push(collabTypeContrat);
    this.toastService.showToast("success", "Nouveau contrat affecté.", 2);
  }
}
