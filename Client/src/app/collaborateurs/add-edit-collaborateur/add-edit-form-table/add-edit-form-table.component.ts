import { Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges, ViewChild } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ContratsComponent } from 'src/app/contrats/contrats.component';
import { DiplomesComponent } from 'src/app/diplomes/diplomes.component';
import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollabTypeContrat, Diplome } from 'src/app/Models/MdmModel';
import { FormationCertificationsService } from 'src/app/services/formation-certifications.service';
import { MdmService } from 'src/app/services/mdm.service';
import {
  SelectInputData,
  SelectInputObject,
} from './_form_inputs/select-input/select-input';

@Component({
  selector: 'app-add-edit-form-table',
  templateUrl: './add-edit-form-table.component.html',
})
export class AddEditFormTableComponent implements OnInit, OnChanges, OnDestroy {
  @ViewChild('contrats') contrats!: ContratsComponent;
  @ViewChild('diplomes') diplomes!: DiplomesComponent;
  @Input() collab!: Collaborator;
  @Input() myFormGroup!: FormGroup;

  intersections!: CollabFormationCertif[];

  subIntersection!: Subscription;
  civiliteData: any = new SelectInputData();
  recruteModeData: any = new SelectInputData();
  niveauxData: any = new SelectInputData();
  postesData: any = new SelectInputData();
  situationFamilialeData: any = new SelectInputData();

  constructor(
    private service: MdmService,
    private formationCertifService: FormationCertificationsService
  ) { }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.collab.id != 0)
      this.subIntersection = this.formationCertifService.getFormationByCollab(this.collab.id)
        .subscribe(data => this.intersections = data.list);
  }

  ngOnInit(): void {
    this.civiliteData.data = [
      new SelectInputObject('M', 'Mr.'),
      new SelectInputObject('F', 'Mme.'),
    ];


    this.service.getRecrutementMode().subscribe((res) => {
      this.recruteModeData.data = res.map(
        (obj) => new SelectInputObject(obj.id, obj.name)
      );
    });
    this.service.getNiveaux().subscribe((res) => {
      this.niveauxData.data = res.map(
        (obj) => new SelectInputObject(obj.id, obj.name)
      );
    });
    this.service.getPostes().subscribe((res) => {
      this.postesData.data = res.map(
        (obj) => new SelectInputObject(obj.id, obj.name)
      );
    });
    this.situationFamilialeData.data = [
      new SelectInputObject('Célibataire', 'Célibataire'),
      new SelectInputObject('Marie', 'Marie'),
      new SelectInputObject('Divorce', 'Divorce'),
      new SelectInputObject('Veuf/Veuve', 'Veuf/Veuve'),
    ];
  }

  refreshAffectations(collabTypeContrat: CollabTypeContrat) {
    this.contrats.AddAffectation(collabTypeContrat);
  }

  refreshDiplomes(diplome: Diplome) {
    this.diplomes.addDiplome(diplome);
  }

  ngOnDestroy(): void {
    this.subIntersection.unsubscribe();
  }
}
