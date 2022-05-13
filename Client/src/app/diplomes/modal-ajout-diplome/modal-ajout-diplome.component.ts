import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { mergeMap } from 'rxjs';
import { Collaborator } from 'src/app/Models/Collaborator';
import { DiplomesService } from 'src/app/services/diplomes.service';

@Component({
  selector: 'app-modal-ajout-diplome',
  templateUrl: './modal-ajout-diplome.component.html',
})
export class ModalAjoutDiplomeComponent implements OnInit {
  form!: FormGroup;
  @Input() collaborateur?: Collaborator;

  constructor(private diplomesService: DiplomesService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      annee: ["", Validators.required],
      label: [""],
      detail: ["", Validators.required],
      description: [""],
      collaborateurId: this.collaborateur?.id
    });
  }

  addDiplome(formGroup: FormGroup) {
    if (formGroup.valid) {
      this.diplomesService.addDiplome(formGroup.value).pipe(
        mergeMap(() => this.diplomesService.getCollabDiplomes(this.collaborateur!.id))
      ).subscribe((diplomes) => {
        this.collaborateur!.diplomes = diplomes;
      })
    }
    else
      alert("form invalid !");
  }
}
