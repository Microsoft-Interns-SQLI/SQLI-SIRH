import { Component, Input, OnInit } from '@angular/core';
import { Carriere } from 'src/app/Models/Carriere';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CarrieresService } from 'src/app/services/carrieres.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';
import { ToastService } from 'src/app/shared/toast/toast.service';

@Component({
  selector: 'app-carrieres',
  templateUrl: './carrieres.component.html',
  styleUrls: ['./carrieres.component.css']
})
@AutoUnsubscribe()
export class CarrieresComponent implements OnInit {
  @Input() collab!: Collaborator;
  carriereToDelete?: Carriere;

  constructor(
    private toastService: ToastService,
  ) { }

  ngOnInit(): void { }

  // editCarriere(carriere: Carriere) {
  //   console.log(carriere);
  // }

  addCarriere(carriere: Carriere) {
    this.collab.carrieres.unshift(carriere);
    this.collab.carrieres = this.collab.carrieres.sort((a, b) => b.annee - a.annee);
    this.toastService.showToast("success", "Nouvelle carrière ajoutée.", 2);
  }

  deleteCarriere(idCarriere: number) {
    this.collab.carrieres = this.collab.carrieres.filter(carr => carr.id != idCarriere);
    this.toastService.showToast("success", "Carrière supprimée avec succès.", 2);
  }
}
