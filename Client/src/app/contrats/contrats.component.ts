import { Component, Input, OnInit } from '@angular/core';
import { Collaborator } from '../Models/Collaborator';

@Component({
  selector: 'app-contrats',
  templateUrl: './contrats.component.html',
})
export class ContratsComponent implements OnInit {
  @Input() collab?: Collaborator;
  constructor() { }

  ngOnInit(): void {
  }

}
