import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Collaborator, Demission } from 'src/app/Models/Collaborator';

@Component({
  selector: 'app-modal-ajout-demission',
  templateUrl: './modal-ajout-demission.component.html'
})
export class ModalAjoutDemissionComponent implements OnInit {
  @Input() collab?: Collaborator;
  @Output() addDemmision = new EventEmitter<Demission>();

  demission: Demission = new Demission();

  constructor() { }

  ngOnInit(): void {
  }

  submitDemission() {
    this.addDemmision.emit(this.demission);
    this.demission = new Demission();
  }

}
