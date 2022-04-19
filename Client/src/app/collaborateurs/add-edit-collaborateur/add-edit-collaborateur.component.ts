import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-add-edit-collaborateur',
  templateUrl: './add-edit-collaborateur.component.html',
  styleUrls: ['./add-edit-collaborateur.component.css'],
})
export class AddEditCollaborateurComponent implements OnInit {
  readonly collab_id: string;
  datepipe: DatePipe = new DatePipe('en-US');
  collab: Collaborator = new Collaborator();
  formGroup!: FormGroup;

  constructor(
    private actRoute: ActivatedRoute,
    private sevice: CollaboratorsService,
    private fb: FormBuilder
  ) {
    this.collab_id = this.actRoute.snapshot.params['id'];
  }

  ngOnInit(): void {
    if (this.collab_id) {
      this.sevice
        .getCollaboratorByMatricule(this.collab_id)
        .subscribe((res) => {
          this.collab = res;
          this.initForm();
        });
    } else {
      this.collab = new Collaborator();
    }
  }

  initForm(): void {
    this.formGroup = this.fb.group({
      civilite: [this.collab.civilite, [Validators.required, Validators.minLength(1), Validators.maxLength(1)]],
      nom: [this.collab.nom, Validators.required],
      prenom: [this.collab.prenom, Validators.required],
      username: [''],
      matricule: [this.collab.matricule, [Validators.required, Validators.minLength(5), Validators.maxLength(8)]],
      emailPersonnel: [this.collab.emailPersonnel, Validators.email],
      email: [this.collab.email, Validators.email],
      phonePersonnel: [this.collab.phonePersonnel],
      phoneProfesionnel: [this.collab.phoneProfesionnel],
      dateNaissance: [this.datepipe.transform(this.collab.dateNaissance, 'yyyy-MM-dd') , Validators.required],
      lieuNaissance: [this.collab.lieuNaissance],
      nationalite: [this.collab.nationnalite],
      numCin: [this.collab.numCin],
      adresse: [this.collab.adresse],
      dateEntreeSqli: [this.datepipe.transform(this.collab.dateEntreeSqli, 'yyyy-MM-dd')],
      dateSortieSqli: [this.datepipe.transform(this.collab.dateSortieSqli, 'yyyy-MM-dd')],
      modeRecrutement: [this.collab.modeRecrutement],
      niveau: [this.collab.niveauName],
      poste: [this.collab.poste],
      situationFamiliale: [this.collab.situationFamiliale],
      dateDebutStage: [this.datepipe.transform(this.collab.dateDebutStage, 'yyyy-MM-dd')],
      datePremiereExperience: [this.datepipe.transform(this.collab.datePremiereExperience, 'yyyy-MM-dd')],
      diplomes: [this.collab.diplomes]
    })
  }

  saveCollaborator(): void {
    // if (this.collab_id) {
    //   this.sevice
    //     .updateCollaborator(this.collab_id, this.collab)
    //     .subscribe((res) => {
    //       console.log('Update Success');
    //     });
    // } else {
    //   this.sevice.addCollaborator(this.collab).subscribe((res) => {
    //     let collaborator: any = res;
    //     window.location.href = `/addEditcollaborateur/${collaborator.id}`;
    //   });
    // }
    console.log(this.formGroup.value);
    console.log(this.collab);
  }

  calculateYears(year: any): any {
    const date = new Date(year);
    const now = new Date(Date.now());
    return Math.abs(now.getFullYear() - date.getFullYear());
  }
}
