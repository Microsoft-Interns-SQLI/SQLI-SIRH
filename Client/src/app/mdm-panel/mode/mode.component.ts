import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { RecruteMode } from 'src/app/Models/MdmModel';

@Component({
  selector: 'app-mode',
  templateUrl: './mode.component.html',
  styleUrls: ['./mode.component.css'],
})
export class ModeComponent implements OnInit {
  @Input() modes!: RecruteMode[];
  @Output() modeToDelete = new EventEmitter<number>();
  @Output() modeToAdd = new EventEmitter<RecruteMode>();
  modeDeleteId?: number;
  mode!: string;
  isAdding: boolean = false;
  constructor() {}

  ngOnInit(): void {}

  onDelete(SkillCenter: any) {
    this.modeDeleteId = SkillCenter;
  }
  onConfirmDelete() {
    this.modeToDelete.emit(this.modeDeleteId);
  }
  onAdd() {
    this.isAdding = true;
  }

  onConfirm() {
    if (this.mode.trim().length !== 0) {
      this.modeToAdd.emit({ mode: this.mode } as RecruteMode);
      this.mode = '';
      this.isAdding = false;
    }
  }

  onCancel() {
    this.mode = '';
    this.isAdding = false;
  }
}
