import { DatePipe } from '@angular/common';
import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Collaborator, Demission } from 'src/app/Models/Collaborator';
import { MdmService } from 'src/app/services/mdm.service';
import { SelectInputData, SelectInputObject } from '../../_form_inputs/select-input/select-input';

@Component({
  selector: 'app-modal-ajout-demission',
  templateUrl: './modal-ajout-demission.component.html'
})
export class ModalAjoutDemissionComponent implements OnInit, OnChanges {
  @Output() addDemmision = new EventEmitter<Demission>();
  @Input() demission?: any = undefined;
  datepipe: DatePipe = new DatePipe('en-US');

  form!: FormGroup;
  data: any = new SelectInputData();

  constructor(private service: MdmService, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.constructForm();
    console.log('dd', this.demission);
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log('changes');
  }

  constructForm() {
    this.form = this.fb.group({
      dateSortieSqli: [this.datepipe.transform(this.demission?.dateSortieSqli, 'yyyy-MM-dd'), Validators.required],
      dateDemission: [this.datepipe.transform(this.demission?.dateDemission, 'yyyy-MM-dd'), Validators.required],
      comment: [this.demission?.comment],
      reasonDemission: [this.demission?.reasonDemissionId]
    });
    this.service.getReasonDemissions().subscribe((res) => {
      this.data.data = res.map((obj) => new SelectInputObject(obj.id, obj.name))
    })
  }

  submitDemission() {
    if (this.form.valid) {
      if (this.demission) {
        this.demission.dateSortieSqli = this.form.value.dateSortieSqli;
        this.demission.dateDemission = this.form.value.dateDemission;
        this.demission.comment = this.form.value.comment;
        this.demission.reasonDemissionId = this.form.value.reasonDemission;
        this.addDemmision.emit(this.demission);
      }
      else {
        let resp: Demission = new Demission();
        resp.dateSortieSqli = this.form.value.dateSortieSqli;
        resp.dateDemission = this.form.value.dateDemission;
        resp.comment = this.form.value.comment;
        resp.reasonDemissionId = this.form.value.reasonDemission;
        this.addDemmision.emit(resp);
      }
      this.demission = undefined;
      this.constructForm();
    }
  }

  resetFrom() {
    this.demission = undefined;
    this.constructForm();
  }
}
