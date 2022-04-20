import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Collaborator } from 'src/app/Models/Collaborator';

@Component({
  selector: 'app-add-edit-summary-card',
  templateUrl: './add-edit-summary-card.component.html',
  styleUrls: ['./add-edit-summary-card.component.css']
})
export class AddEditSummaryCardComponent implements OnInit {
  @Input() collab!: Collaborator;

  constructor() { }

  ngOnInit(): void {
  }

  calculateYears(year: any): any {
    const date = new Date(year);
    const now = new Date(Date.now());
    return Math.abs(now.getFullYear() - date.getFullYear());
  }
}
