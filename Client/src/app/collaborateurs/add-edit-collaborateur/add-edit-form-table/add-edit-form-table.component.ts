import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Collaborator } from 'src/app/Models/Collaborator';
import { Niveaux } from 'src/app/Models/nivaux';
import { MdmService } from 'src/app/services/mdm.service';
import { SelectInputData, SelectInputObject } from './_form_inputs/select-input/select-input';

@Component({
  selector: 'app-add-edit-form-table',
  templateUrl: './add-edit-form-table.component.html',
  styleUrls: ['./add-edit-form-table.component.css']
})
export class AddEditFormTableComponent implements OnInit {
  @Input() collab!: Collaborator;
  @Input() formGroup!: FormGroup;

  civiliteData: any = new SelectInputData();
  niveauxData: any = new SelectInputData();
  postesData: any = new SelectInputData();

  constructor(private service: MdmService) {

  }

  ngOnInit(): void {
    this.civiliteData.data = [
      new SelectInputObject('M', 'Mr.'),
      new SelectInputObject('F', 'Mme.')
    ]
    this.service.getNiveaux().subscribe(res => {
      this.niveauxData.data = res.map(obj => new SelectInputObject(obj.id, obj.name));
    })
    this.service.getPostes().subscribe(res => {
      this.postesData.data = res.map(obj => new SelectInputObject(obj.id, obj.name));
    })
  }

}
