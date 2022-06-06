import { Component, Input, OnInit } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';
import { Diplome } from 'src/app/Models/MdmModel';
import { DiplomesService } from 'src/app/services/diplomes.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';
import { ToastService } from 'src/app/shared/toast/toast.service';

@Component({
  selector: 'app-diplomes',
  templateUrl: './diplomes.component.html',
})

@AutoUnsubscribe()
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
