import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Poste } from 'src/app/Models/MdmModel';

@Component({
  selector: 'app-poste',
  templateUrl: './poste.component.html',
  styleUrls: ['./poste.component.css'],
})
export class PosteComponent implements OnInit {
  @Input() postes!: Poste[];
  @Output() posteToDelete = new EventEmitter<number>();
  @Output() posteToAdd = new EventEmitter<Poste>();
  posteToDeleteId?: number;
  poste!: string;
  isAdding: boolean = false;
  constructor() {}

  ngOnInit(): void {}

  onDelete(poste: any) {
    this.posteToDeleteId = poste;
  }
  onConfirmDelete() {
    this.posteToDelete.emit(this.posteToDeleteId);
  }
  onAdd() {
    this.isAdding = true;
  }

  onConfirm() {
    if (this.poste.trim().length !== 0) {
      this.posteToAdd.emit({ name: this.poste } as Poste);
      this.poste = '';
      this.isAdding = false;
    }
  }

  onCancel() {
    this.poste = '';
    this.isAdding = false;
  }
}
