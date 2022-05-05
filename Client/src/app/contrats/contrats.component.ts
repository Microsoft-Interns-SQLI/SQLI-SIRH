import { Component, Input, OnInit } from '@angular/core';
import { Collaborator } from '../Models/Collaborator';
import { ContratsService } from '../services/contrats.service';

@Component({
  selector: 'app-contrats',
  templateUrl: './contrats.component.html',
})
export class ContratsComponent implements OnInit {
  @Input() collab?: Collaborator;
  constructor(
    private contratsService: ContratsService
  ) { }

  ngOnInit(): void {
  }

}
