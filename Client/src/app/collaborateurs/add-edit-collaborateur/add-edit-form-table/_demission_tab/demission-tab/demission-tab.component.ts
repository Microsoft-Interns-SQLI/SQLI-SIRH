import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';
import { DemissionService } from 'src/app/services/demission.service';

@Component({
  selector: 'app-demission-tab',
  templateUrl: './demission-tab.component.html'
})
export class DemissionTabComponent implements OnInit {
  @Input() collab!: Collaborator;
  @Output() updateDemission = new EventEmitter<number>();

  constructor(private demissionService: DemissionService) { }

  ngOnInit(): void {
  }

  submitDemission(id: number) {
    this.updateDemission.emit(id);
  }

  confirmDelete(id: number|string) {
    if (confirm("This Action Is Irreversible!")) {
      this.demissionService.deleteDemission(id).subscribe();
    }
  }

}
