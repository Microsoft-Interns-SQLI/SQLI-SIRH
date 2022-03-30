import { Component, OnInit } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-list-collaborateurs',
  templateUrl: './list-collaborateurs.component.html',
  styleUrls: ['./list-collaborateurs.component.css']
})
export class ListCollaborateursComponent implements OnInit {
  collaboratorsArray: Collaborator[] = [];

  constructor(private service: CollaboratorsService) { }

  ngOnInit(): void {
    this.collaboratorsServiceMap();
  }

  collaboratorsServiceMap(): void {
    this.service.getCollaboratorsList().subscribe((data) => {
      this.collaboratorsArray = data;
    });
  }

}
