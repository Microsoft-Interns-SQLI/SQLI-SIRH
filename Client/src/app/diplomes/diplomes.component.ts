import { Component, Input, OnInit } from '@angular/core';
import { mergeMap } from 'rxjs';
import { Collaborator } from '../Models/Collaborator';
import { Diplome } from '../Models/MdmModel';
import { DiplomesService } from '../services/diplomes.service';
import { ToastService } from '../shared/toast/toast.service';

@Component({
  selector: 'app-diplomes',
  templateUrl: './diplomes.component.html',
})
export class DiplomesComponent implements OnInit {
  @Input() collab!: Collaborator;

  constructor(
    private toastService: ToastService,
    private diplomesService: DiplomesService
  ) { }

  ngOnInit(): void { }

  deleteDiplome(idDiplome: number) {
    // todo : need a confirm modal 
    if (confirm("êtes-vous sûr de vouloir supprimer ce diplôme ?")) {
      this.diplomesService.deleteDiplome(idDiplome).subscribe(() => {
        this.collab.diplomes = this.collab.diplomes.filter(diplm => diplm.id !== idDiplome);
        this.toastService.showToast("success", "Diplôme supprimé avec succès.", 2);
      })
    }
  }

  addDiplome(diplome: Diplome) {
    this.collab.diplomes.push(diplome);
    this.toastService.showToast("success", "Nouveau diplôme ajouté.", 2);
  }
}
