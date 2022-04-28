import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Contrat } from 'src/app/Models/MdmModel';

@Component({
  selector: 'app-type-contrat',
  templateUrl: './type-contrat.component.html',
  styleUrls: ['./type-contrat.component.css'],
})
export class TypeContratComponent implements OnInit {
  @Input() contrats!: Contrat[];
  @Output() contratToDelete = new EventEmitter<number>();
  @Output() contratToAdd = new EventEmitter<Contrat>();
  contratToDeleteId?: number;
  contrat!: string;
  isAdding: boolean = false;
  constructor() {}

  ngOnInit(): void {}

  onDelete(contrat: any) {
    this.contratToDeleteId = contrat;
  }
  onConfirmDelete() {
    this.contratToDelete.emit(this.contratToDeleteId);
  }
  onAdd() {
    this.isAdding = true;
  }

  onConfirm() {
    if (this.contrat.trim().length !== 0) {
      this.contratToAdd.emit({ name: this.contrat } as Contrat);
      this.contrat = '';
      this.isAdding = false;
    }
  }

  onCancel() {
    this.contrat = '';
    this.isAdding = false;
  }
}
