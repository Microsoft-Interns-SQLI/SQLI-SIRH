import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Collaborator } from 'src/app/Models/Collaborator';

@Component({
  selector: 'app-add-edit-form-table',
  templateUrl: './add-edit-form-table.component.html',
  styleUrls: ['./add-edit-form-table.component.css']
})
export class AddEditFormTableComponent implements OnInit {
  @Input() collab!: Collaborator;
  @Input() formGroup!: FormGroup;

  constructor() {

  }

  ngOnInit(): void {
  }

}
