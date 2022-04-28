import { Component, Input, OnInit } from '@angular/core';
import { Collaborator } from '../Models/Collaborator';

@Component({
  selector: 'app-diplomes',
  templateUrl: './diplomes.component.html',
})
export class DiplomesComponent implements OnInit {
  @Input() collab?: Collaborator;

  constructor() { }

  ngOnInit(): void {
  }

}
