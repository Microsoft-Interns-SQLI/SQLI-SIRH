import {
  Component,
  Input,
  OnChanges,
  OnDestroy,
  OnInit,
  SimpleChanges,
  ViewChild,
} from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Subscription, switchMap } from 'rxjs';
import { ContratsComponent } from 'src/app/contrats/contrats.component';
import { Collaborator, Demission } from 'src/app/Models/Collaborator';
import { ContratsService } from 'src/app/services/contrats.service';
import { DiplomesComponent } from 'src/app/diplomes/diplomes.component';
import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { Diplome } from 'src/app/Models/MdmModel';
import { FormationCertificationsService } from 'src/app/services/formation-certifications.service';
import { MdmService } from 'src/app/services/mdm.service';
import {
  SelectInputData,
  SelectInputObject,
} from './_form_inputs/select-input/select-input';
import { CollabTypeContrat } from 'src/app/Models/CollabTypeContrat';
import { CarrieresComponent } from 'src/app/carrieres/carrieres.component';
import { Carriere } from 'src/app/Models/Carriere';
import { DemissionService } from 'src/app/services/demission.service';

@Component({
  selector: 'app-add-edit-form-table',
  templateUrl: './add-edit-form-table.component.html',
})
export class AddEditFormTableComponent implements OnInit, OnChanges, OnDestroy {
  @ViewChild('carrieres') carrieres!: CarrieresComponent;
  @ViewChild('contrats') contrats!: ContratsComponent;
  @ViewChild('diplomes') diplomes!: DiplomesComponent;
  @Input() collab!: Collaborator;
  @Input() myFormGroup!: FormGroup;

  intersectionsFormations: CollabFormationCertif[] = [];
  intersectionsCertifications: CollabFormationCertif[] = [];

  subIntersectionF!: Subscription;
  subIntersectionC!: Subscription;

  civiliteData: any = new SelectInputData();
  recruteModeData: any = new SelectInputData();
  niveauxData: any = new SelectInputData();
  postesData: any = new SelectInputData();
  situationFamilialeData: any = new SelectInputData();
  demis?: Demission = undefined;
  demisTitle = '';
  constructor(
    private service: MdmService,
    private formationCertifService: FormationCertificationsService,
    private demissionService: DemissionService
  ) {}

  ngOnChanges(changes: SimpleChanges): void {
    if (this.collab.id != 0) {
      this.subIntersectionF = this.formationCertifService
        .getFormationByCollab(this.collab.id)
        .subscribe((data) => (this.intersectionsFormations = data.list));
      this.subIntersectionC = this.formationCertifService
        .getCertificationByCollab(this.collab.id)
        .subscribe((data) => (this.intersectionsCertifications = data.list));
    }
  }

  ngOnInit(): void {
    this.civiliteData.data = [
      new SelectInputObject('M', 'Mr.'),
      new SelectInputObject('F', 'Mme.'),
    ];
    this.service.getAll('modes').subscribe((res) => {
      this.recruteModeData.data = res.map(
        (obj) => new SelectInputObject(+obj.id, obj.name)
      );
    });
    this.service.getAll('niveaux').subscribe((res) => {
      this.niveauxData.data = res.map(
        (obj) => new SelectInputObject(obj.id, obj.name)
      );
    });
    this.service.getAll('postes').subscribe((res) => {
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

  refreshCarrieres(carriere: Carriere) {
    this.carrieres.addCarriere(carriere);
  }

  ngOnDestroy(): void {
    if (this.subIntersectionF != undefined) this.subIntersectionF.unsubscribe();
    if (this.subIntersectionC != undefined) this.subIntersectionC.unsubscribe();
  }

  addDemission(event: Demission) {
    let data: Demission;

    data = event;
    this.demis = undefined;
    if (data.id != 0) {
      this.collab.demissions.forEach((el) => {
        if (el.id == data.id) {
          el = data;
          el.reasonDemission = undefined;
          this.demissionService.updateDemission(el);
        }
      });
      return;
    }
    data.collaborateurId = this.collab?.id;
    this.demissionService.addDemission(data).subscribe(res => {
      this.collab.demissions = [...this.collab.demissions, res?.data];
      console.log(this.collab.demissions);
    });
  }

  updateDemissionDisplay(event: number) {
    if (event == 0) {
      this.demis = undefined;
      this.demisTitle = 'Ajouter Demission';
      return;
    }
    this.collab.demissions.forEach((el) => {
      if (el.id == event) {
        this.demis = el as Demission;
        this.demisTitle = 'Editer Demission';
        // this.myFormGroup.markAsDirty();
      }
    });
  }

  filesHandler(event: any) {
    this.collab.documents?.push(...event);
  }
}
