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
      this.initForm();
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
      nationnalite: [this.collab.nationnalite],
      numCin: [this.collab.numCin],
      adresse: [this.collab.adresse],
      dateEntreeSqli: [this.datepipe.transform(this.collab.dateEntreeSqli, 'yyyy-MM-dd')],
      dateSortieSqli: [this.datepipe.transform(this.collab.dateSortieSqli, 'yyyy-MM-dd')],
      modeRecrutement: [this.collab.modeRecrutement],
      niveauName: [this.collab.niveauName],
      poste: [this.collab.poste],
      situationFamiliale: [this.collab.situationFamiliale],
      dateDebutStage: [this.datepipe.transform(this.collab.dateDebutStage, 'yyyy-MM-dd')],
      datePremiereExperience: [this.datepipe.transform(this.collab.datePremiereExperience, 'yyyy-MM-dd')],
      diplomes: [this.collab.diplomes]
    })
  }

  saveCollaborator(): void {
    if (!this.formGroup.valid) {
      this.formGroup.markAllAsTouched();
      return ;
    }
    this.updateCollab();
    if (this.collab_id) {
      this.sevice
        .updateCollaborator(this.collab_id, this.collab)
        .subscribe((res) => {
        });
    } else {
      this.sevice.addCollaborator(this.collab).subscribe((res) => {
        let collaborator: any = res;
        window.location.href = `/addEditcollaborateur/${collaborator.id}`;
      });
    }
  }

  updateCollab() {
    // Object.keys(this.formGroup.value)
    // .forEach(obj => {
    //   this.collab[obj as keyof Collaborator] = this.formGroup.value[obj];
    // })
    this.collab.civilite = this.formGroup.value.civilite;
    this.collab.nom = this.formGroup.value.nom;
    this.collab.prenom = this.formGroup.value.prenom;
    // this.collab.username = this.formGroup.value.username;
    this.collab.matricule = this.formGroup.value.matricule;
    this.collab.emailPersonnel = this.formGroup.value.emailPersonnel;
    this.collab.email = this.formGroup.value.email;
    this.collab.phonePersonnel = this.formGroup.value.phonePersonnel;
    this.collab.phoneProfesionnel = this.formGroup.value.phoneProfesionnel;
    this.collab.dateNaissance = this.formGroup.value.dateNaissance;
    this.collab.lieuNaissance = this.formGroup.value.lieuNaissance;
    this.collab.nationnalite = this.formGroup.value.nationnalite;
    this.collab.numCin = this.formGroup.value.numCin;
    this.collab.adresse = this.formGroup.value.adresse;
    this.collab.dateEntreeSqli = this.formGroup.value.dateEntreeSqli;
    this.collab.dateSortieSqli = this.formGroup.value.dateSortieSqli;
    this.collab.modeRecrutement = this.formGroup.value.modeRecrutement;
    this.collab.niveauName = this.formGroup.value.niveauName;
    this.collab.poste = this.formGroup.value.poste;
    this.collab.situationFamiliale = this.formGroup.value.situationFamiliale;
    this.collab.dateDebutStage = this.formGroup.value.dateDebutStage;
    this.collab.datePremiereExperience = this.formGroup.value.datePremiereExperience;
    this.collab.diplomes = this.formGroup.value.diplomes;
  }

  calculateYears(year: any): any {
    const date = new Date(year);
    const now = new Date(Date.now());
    return Math.abs(now.getFullYear() - date.getFullYear());
  }
}
