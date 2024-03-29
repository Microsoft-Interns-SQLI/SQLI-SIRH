import {
  Component,
  Input,
  OnChanges,
  OnDestroy,
  OnInit,
  SimpleChanges,
} from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Subscription, switchMap } from 'rxjs';
import { Collaborator, Demission } from 'src/app/Models/Collaborator';
import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { FormationCertificationsService } from 'src/app/services/formation-certifications.service';
import { MdmService } from 'src/app/services/mdm.service';
import {
  SelectInputData,
  SelectInputObject,
} from './_form_inputs/select-input/select-input';
import { DemissionService } from 'src/app/services/demission.service';
import { ToastService } from 'src/app/shared/toast/toast.service';
import { CollabFile } from 'src/app/Models/collabFile';

@Component({
  selector: 'app-add-edit-form-table',
  templateUrl: './add-edit-form-table.component.html',
})
export class AddEditFormTableComponent implements OnInit, OnChanges, OnDestroy {
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
    private demissionService: DemissionService,
    private toastService: ToastService
  ) { }

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

  ngOnDestroy(): void {
    if (this.subIntersectionF != undefined) this.subIntersectionF.unsubscribe();
    if (this.subIntersectionC != undefined) this.subIntersectionC.unsubscribe();
  }

  addDemission(event: Demission) {
    let data: Demission;

    data = event;
    this.demis = undefined;
    data.collaborateurId = this.collab?.id;
    data.reasonDemission = undefined;
    if (data.id != 0) {
      for (let i = 0; i < this.collab.demissions.length; i++) {
        if (this.collab.demissions[i].id == data.id) {
          this.demissionService.updateDemission(data).subscribe({
            next: (res) => (this.collab.demissions[i] = res),
            error: (err) =>
              this.toastService.showToast(
                'danger',
                "demission n'a pas modifer",
                2
              ),
            complete: () =>
              this.toastService.showToast(
                'success',
                'demission a ete modifier',
                2
              ),
          });
          break;
        }
      }
      return;
    }
    this.demissionService.addDemission(data).subscribe({
      next: (res) =>
        (this.collab.demissions = [...this.collab.demissions, res?.data]),
      error: (err) =>
        this.toastService.showToast(
          'danger',
          "demission n'a ete pas ajouter",
          2
        ),
      complete: () =>
        this.toastService.showToast('success', 'demission a ete ajouter', 2),
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

  hasCv(documents: CollabFile[] | undefined): boolean {
    if (
      documents !== undefined &&
      documents.filter(
        (d: any) => d.type === 'CV' && d.fileName.endsWith('.pdf')
      ).length > 0
    )
      return false;
    else return true;
  }
}
