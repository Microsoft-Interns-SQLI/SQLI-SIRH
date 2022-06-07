import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Collaborator } from 'src/app/Models/Collaborator';
import { Diplome } from 'src/app/Models/MdmModel';
import { DiplomesService } from 'src/app/services/diplomes.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';
import { ToastService } from 'src/app/shared/toast/toast.service';

@Component({
  selector: 'app-modal-ajout-diplome',
  templateUrl: './modal-ajout-diplome.component.html',
})
@AutoUnsubscribe()
export class ModalAjoutDiplomeComponent implements OnInit {
  form!: FormGroup;
  @Output() refreshDiplomes = new EventEmitter<Diplome>();
  @Input() collaborateur?: Collaborator;


  constructor(
    private diplomesService: DiplomesService,
    private formBuilder: FormBuilder,
    private toastService: ToastService
  ) { }

  ngOnInit(): void {
    this.initForm();
  }

  initForm() {
    this.form = this.formBuilder.group({
      annee: ["", Validators.required],
      label: ["", Validators.required],
      detail: [""],
      description: [""],
      collaborateurId: this.collaborateur?.id
    });
  }

  addDiplome(formGroup: FormGroup) {
    this.form.markAllAsTouched();
    if (formGroup.valid) {
      // trick : to close the modal
      document.getElementById('btn-close-modal-diplome')?.click();

      this.diplomesService.addDiplome(formGroup.value).subscribe(
        {
          next: (addedDiplome) => {
            this.refreshDiplomes.emit(addedDiplome as Diplome);
            this.initForm();
          },
          error: (erreur) => {
            console.log(erreur);
            this.toastService.showToast("danger", "diplome non affecté ! une erreur est survenue au sein du serveur distant.. Veuillez réessayer plus tard.", 10);
          }
        }
      );
    }
  }
}
