import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Carriere } from 'src/app/Models/Carriere';
import { Collaborator } from 'src/app/Models/Collaborator';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';

@Component({
  selector: 'app-modal-edit-carriere',
  templateUrl: './modal-edit-carriere.component.html'
})

@AutoUnsubscribe()
export class ModalEditCarriereComponent implements OnInit {
  form!: FormGroup;
  // @Output() refreshCarrieres = new EventEmitter<Carriere>();
  // @Input() collaborateur?: Collaborator;


  constructor() { }

  ngOnInit(): void {
  }

  // initForm() {
  //   this.form = this.formBuilder.group({
  //     collaborateurId: this.collaborateur?.id,
  //     annee: ["", Validators.required],
  //     niveauId: ["", Validators.required],
  //     posteId: ["", Validators.required],
  //     profilDeCout: ["", Validators.required],
  //     salaireNet: ["", Validators.required],
  //     variableNet: ["", Validators.required],
  //     salaireBrut: ["", Validators.required],
  //     variableBrut: ["", Validators.required],
  //     tlrh: [""],
  //   });
  // }

}
