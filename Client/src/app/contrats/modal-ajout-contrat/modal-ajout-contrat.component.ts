import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {
  SelectInputData,
  SelectInputObject,
} from 'src/app/collaborateurs/add-edit-collaborateur/add-edit-form-table/_form_inputs/select-input/select-input';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollabTypeContrat } from 'src/app/Models/CollabTypeContrat';
import { ContratsService } from 'src/app/services/contrats.service';
import { MdmService } from 'src/app/services/mdm.service';
import { minDateValidator } from 'src/app/shared/custom-validators/min-date.validator';
import { ToastService } from 'src/app/shared/toast/toast.service';

@Component({
  selector: 'app-modal-ajout-contrat',
  templateUrl: './modal-ajout-contrat.component.html',
})
export class ModalAjoutContratComponent implements OnInit {
  form!: FormGroup;
  typesContratData: any = new SelectInputData();
  @Output() refreshAffectations = new EventEmitter<CollabTypeContrat>();
  @Input() collaborateur?: Collaborator;

  constructor(
    private contratService: ContratsService,
    private formBuilder: FormBuilder,
    private mdmService: MdmService,
    private toastService: ToastService
  ) { }

  ngOnInit(): void {
    this.initForm();
    this.loadTypesContrat();
  }

  initForm() {
    this.form = this.formBuilder.group({
      dateDebut: ['', Validators.required],
      dateFin: [''],
      isInSQLI: true,
      typeContratId: ['', Validators.required],
      collaborateurId: this.collaborateur?.id,
    });
  }

  loadTypesContrat() {
    this.mdmService.getAll('contrats').subscribe((typesContrats) => {
      this.typesContratData.data = typesContrats.map(
        (obj) => new SelectInputObject(obj.id, obj.name)
      );
    });
  }

  affecteContrat(formGroup: FormGroup) {
    this.form.markAllAsTouched();
    if (formGroup.valid) {
      // trick : to close the modal
      document.getElementById('btn-close-modal-contrat')?.click();

      this.contratService.affecteContrat(formGroup.value).subscribe({
        next: (addedContrat) => {
          this.refreshAffectations.emit(addedContrat as CollabTypeContrat);
          this.initForm();
        },
        error: (erreur) => {
          console.error(erreur);
          this.toastService.showToast(
            'danger',
            'contrat non affecté ! une erreur est survenue au sein du serveur distant.. Veuillez réessayer plus tard.',
            10
          );
        },
      });
    }
  }

  validateDateGap(event: Event) {
    const minDate = (event.target as HTMLInputElement).value;
    this.form
      .get('dateFin')
      ?.setValidators(minDateValidator(new Date(minDate)));
    this.form.get('dateFin')?.updateValueAndValidity({ onlySelf: true });
  }
}
