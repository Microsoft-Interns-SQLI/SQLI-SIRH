import { Component, Input, OnInit } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';

@Component({
  selector: 'app-demission-tab',
  templateUrl: './demission-tab.component.html'
})
export class DemissionTabComponent implements OnInit {
  @Input() collab!: Collaborator;
  constructor() { }

  ngOnInit(): void {
  }

}
