import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { mergeMap } from 'rxjs';
import { SelectInputData, SelectInputObject } from 'src/app/collaborateurs/add-edit-collaborateur/add-edit-form-table/_form_inputs/select-input/select-input';
import { Collaborator } from 'src/app/Models/Collaborator';
import { ContratsService } from 'src/app/services/contrats.service';
import { MdmService } from 'src/app/services/mdm.service';

@Component({
  selector: 'app-modal-ajout-contrat',
  templateUrl: './modal-ajout-contrat.component.html',
})
export class ModalAjoutContratComponent implements OnInit {
  form!: FormGroup;
  typesContratData: any = new SelectInputData();
  @Input() collaborateur?: Collaborator;

  constructor(private contratService: ContratsService, private formBuilder: FormBuilder, private mdmService: MdmService) { }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      "dateDebut": ["", Validators.required],
      "dateFin": [""],
      "isInSQLI": false,
      "typeContratId": 0,
      "collaborateurId": this.collaborateur?.id,
    });

    this.mdmService.getContrats().subscribe((typesContrats) => {
      this.typesContratData.data = typesContrats.map(
        (obj) => new SelectInputObject(obj.id, obj.name)
      )
    })
  }

  affecteContrat(formGroup: FormGroup) {
    console.table(formGroup.value);
    if (formGroup.valid) {
      this.contratService.affecteContrat(formGroup.value).pipe(
        mergeMap(() => this.contratService.getContratsOfCollab(this.collaborateur!.id))
      ).subscribe((contrats) => {

      })
    }
    else
      alert("form invalid !");
  }
}
