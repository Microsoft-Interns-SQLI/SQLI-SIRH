import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { Collaborator, Demission } from 'src/app/Models/Collaborator';
import { ModalAjoutDemissionComponent } from '../modal-ajout-demission/modal-ajout-demission.component';

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
