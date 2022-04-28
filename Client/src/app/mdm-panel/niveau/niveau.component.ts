import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Niveau } from 'src/app/Models/MdmModel';

@Component({
  selector: 'app-niveau',
  templateUrl: './niveau.component.html',
  styleUrls: ['./niveau.component.css'],
})
export class NiveauComponent implements OnInit {
  @Input() niveaux!: Niveau[];
  @Output() niveauToDelete = new EventEmitter<number>();
  @Output() niveauToAdd = new EventEmitter<Niveau>();
  niveauToDeleteId?: number;
  niveau!: string;
  isAdding: boolean = false;
  constructor() {}

  ngOnInit(): void {}

  onDelete(site: any) {
    this.niveauToDeleteId = site;
  }
  onConfirmDelete() {
    this.niveauToDelete.emit(this.niveauToDeleteId);
  }
  onAdd() {
    this.isAdding = true;
  }

  onConfirm() {
    if (this.niveau.trim().length !== 0) {
      this.niveauToAdd.emit({ name: this.niveau } as Niveau);
      this.niveau = '';
      this.isAdding = false;
    }
  }

  onCancel() {
    this.niveau = '';
    this.isAdding = false;
  }
}
