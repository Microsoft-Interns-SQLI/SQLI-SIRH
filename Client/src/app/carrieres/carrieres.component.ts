import { Component, Input, OnInit } from '@angular/core';
import { Carriere } from '../Models/Carriere';
import { Collaborator } from '../Models/Collaborator';
import { CarrieresService } from '../services/carrieres.service';
import { ToastService } from '../shared/toast/toast.service';

@Component({
  selector: 'app-carrieres',
  templateUrl: './carrieres.component.html'
})
export class CarrieresComponent implements OnInit {
  carrieres!: Carriere[];
  @Input() collab!: Collaborator;

  constructor(
    private toastService: ToastService,
    private carrieresService: CarrieresService
  ) { }

  ngOnInit(): void {
    this.getAllAffectations();
  }

  getAllAffectations() {
    this.carrieresService.getCarrieresOfCollab(this.collab.id).subscribe((carrieres) => {
      this.carrieres = carrieres;
    });
  }

  deleteCarriere(idCarriere: number) {
    // todo or not ??
  }

  addCarriere(carriere: Carriere) {
    this.carrieres.unshift(carriere);
    this.toastService.showToast("success", "Nouvelle carrière ajoutée.", 2);
  }

}
