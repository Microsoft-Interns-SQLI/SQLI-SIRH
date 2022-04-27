import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { SkillCenter } from 'src/app/Models/MdmModel';

@Component({
  selector: 'app-skill-center',
  templateUrl: './skill-center.component.html',
  styleUrls: ['./skill-center.component.css'],
})
export class SkillCenterComponent implements OnInit {
  @Input() skillCenters!: SkillCenter[];
  @Output() skillCenterToDelete = new EventEmitter<number>();
  @Output() skillCenterToAdd = new EventEmitter<SkillCenter>();
  skillCenterToDeleteId?: number;
  skillCenter!: string;
  isAdding: boolean = false;
  constructor() {}

  ngOnInit(): void {}

  onDelete(SkillCenter: any) {
    this.skillCenterToDeleteId = SkillCenter;
  }
  onConfirmDelete() {
    this.skillCenterToDelete.emit(this.skillCenterToDeleteId);
  }
  onAdd() {
    this.isAdding = true;
  }

  onConfirm() {
    if (this.skillCenter.trim().length !== 0) {
      this.skillCenterToAdd.emit({ name: this.skillCenter } as SkillCenter);
      this.skillCenter = '';
      this.isAdding = false;
    }
  }

  onCancel() {
    this.skillCenter = '';
    this.isAdding = false;
  }
}
