import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ContratsComponent } from 'src/app/contrats/contrats.component';
import { Collaborator, Demission } from 'src/app/Models/Collaborator';
import { ContratsService } from 'src/app/services/contrats.service';
import { MdmService } from 'src/app/services/mdm.service';
import { ModalAjoutDemissionComponent } from './_demission_tab/modal-ajout-demission/modal-ajout-demission.component';
import {
  SelectInputData,
  SelectInputObject,
} from './_form_inputs/select-input/select-input';

@Component({
  selector: 'app-add-edit-form-table',
  templateUrl: './add-edit-form-table.component.html',
})
export class AddEditFormTableComponent implements OnInit {
  @ViewChild('contrats') contrats!: ContratsComponent;
  @ViewChild(ModalAjoutDemissionComponent) demissionUpdate!: ModalAjoutDemissionComponent;
  @Input() collab!: Collaborator;
  @Input() myFormGroup!: FormGroup;

  civiliteData: any = new SelectInputData();
  recruteModeData: any = new SelectInputData();
  niveauxData: any = new SelectInputData();
  postesData: any = new SelectInputData();
  situationFamilialeData: any = new SelectInputData();

  demission?: Demission = undefined;

  constructor(private service: MdmService, private contratService: ContratsService) { }

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

  updateAffectations() {
    this.contratService.getContratsOfCollab(this.collab.id).subscribe((contrats) => {
      this.contrats.affectations = contrats;
    })
  }

  addDemission(event: Demission) {
    let data: Demission;

    data = event;
    if (data.id != 0) {
      this.collab.demissions.forEach((el) => {
        if (el.id == data.id) {
          el = data;
        }
      })
      return ;
    }
    this.collab.demissions = [...this.collab.demissions, data]
  }

  updateDemission(event: number) {
    this.collab.demissions.forEach((el) => {
      if (el.id == event) {
        this.demission = el as Demission;
        this.demissionUpdate.demission = el as Demission;
        this.demissionUpdate.constructForm();
        console.log(this.demissionUpdate.demission);
      }
    })
  }

}
