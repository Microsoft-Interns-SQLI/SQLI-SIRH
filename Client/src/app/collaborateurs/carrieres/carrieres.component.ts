import { Component, Input, OnInit } from '@angular/core';
import { Carriere } from 'src/app/Models/Carriere';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CarrieresService } from 'src/app/services/carrieres.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';
import { ToastService } from 'src/app/shared/toast/toast.service';

@Component({
  selector: 'app-carrieres',
  templateUrl: './carrieres.component.html'
})
@AutoUnsubscribe()
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
