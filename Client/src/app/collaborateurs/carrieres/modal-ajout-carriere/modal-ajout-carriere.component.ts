import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SelectInputData, SelectInputObject } from 'src/app/collaborateurs/add-edit-collaborateur/add-edit-form-table/_form_inputs/select-input/select-input';
import { Carriere } from 'src/app/Models/Carriere';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CarrieresService } from 'src/app/services/carrieres.service';
import { MdmService } from 'src/app/services/mdm.service';
import { AutoUnsubscribe } from 'src/app/shared/decorators/AutoUnsubscribe';
import { ToastService } from 'src/app/shared/toast/toast.service';

@Component({
  selector: 'app-modal-ajout-carriere',
  templateUrl: './modal-ajout-carriere.component.html'
})
@AutoUnsubscribe()
export class ModalAjoutCarriereComponent implements OnInit {
  form!: FormGroup;
  @Output() refreshCarrieres = new EventEmitter<Carriere>();
  @Input() collaborateur?: Collaborator;

  postes: any = new SelectInputData();
  niveaux: any = new SelectInputData();


  constructor(
    private mdmService: MdmService,
    private carriereService: CarrieresService,
    private formBuilder: FormBuilder,
    private toastService: ToastService
  ) { }

  ngOnInit(): void {

    this.mdmService.getAll('postes').subscribe((postes) => {
      this.postes.data = postes.map(
        (obj) => new SelectInputObject(obj.id, obj.name)
      );
    });

    this.mdmService.getAll('niveaux').subscribe((niveaux) => {
      this.niveaux.data = niveaux.map(
        (obj) => new SelectInputObject(obj.id, obj.name)
      );
    });

    this.initForm();
  }

  initForm() {
    this.form = this.formBuilder.group({
      collaborateurId: this.collaborateur?.id,
      annee: ["", Validators.required],
      niveauId: ["", Validators.required],
      posteId: ["", Validators.required],
      profilDeCout: ["", Validators.required],
      salaireNet: ["", Validators.required],
      variableNet: ["", Validators.required],
      salaireBrut: ["", Validators.required],
      variableBrut: ["", Validators.required],
      tlrh: [""],
    });
  }

  addCarriere(formGroup: FormGroup) {
    this.form.markAllAsTouched();
    if (formGroup.valid) {
      // trick : to close the modal
      document.getElementById('btn-close-modal-carriere')?.click();

      this.carriereService.addCarriere(formGroup.value).subscribe(
        {
          next: (addedCarriere) => {
            this.refreshCarrieres.emit(addedCarriere as Carriere);
            this.initForm();
          },
          error: (erreur) => {
            console.log(erreur);
            // this.toastService.showToast("danger", "Carrière non ajoutée ! une erreur est survenue au sein du serveur distant.. Veuillez réessayer plus tard.", 10);
          }
        }
      );
    }
  }

}
