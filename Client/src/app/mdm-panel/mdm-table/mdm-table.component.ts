import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-mdm-table',
  templateUrl: './mdm-table.component.html',
  styleUrls: ['./mdm-table.component.css'],
})
export class MdmTableComponent implements OnInit {
  @Input() Data: any;
  @Input() title: any;
  @Output() itemToAdd = new EventEmitter();
  @Output() itemToDelete = new EventEmitter();
  itemToDeleteId?: number;
  item!: string;
  isAdding: boolean = false;
  constructor() {}

  ngOnInit(): void {}

  onDelete(site: any) {
    this.itemToDeleteId = site;
  }
  onConfirmDelete() {
    this.itemToDelete.emit(this.itemToDeleteId);
  }
  onAdd() {
    this.isAdding = true;
  }

  onConfirm() {
    if (this.item.trim().length !== 0) {
      this.itemToAdd.emit({ name: this.item });
      this.item = '';
      this.isAdding = false;
    }
  }

  onCancel() {
    this.item = '';
    this.isAdding = false;
  }
}
