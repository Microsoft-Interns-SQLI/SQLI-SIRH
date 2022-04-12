import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-edit-form-table',
  templateUrl: './add-edit-form-table.component.html',
  styleUrls: ['./add-edit-form-table.component.css']
})
export class AddEditFormTableComponent implements OnInit {
  @Input()
  collab: any;

  constructor() { }

  ngOnInit(): void {
  }

}
