import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Collaborator, Demission } from 'src/app/Models/Collaborator';

@Component({
  selector: 'app-demission-tab',
  templateUrl: './demission-tab.component.html'
})
export class DemissionTabComponent implements OnInit {
  @Input() collab!: Collaborator;
  @Output() updateDemission = new EventEmitter<number>();

  constructor() { }

  ngOnInit(): void {
  }

  submitDemission(id: number) {
    this.updateDemission.emit(id);
  }

}
