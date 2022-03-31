import { Component, OnInit } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-list-collaborateurs',
  templateUrl: './list-collaborateurs.component.html',
  styleUrls: ['./list-collaborateurs.component.css']
})
export class ListCollaborateursComponent implements OnInit {
  collaboratorsArray: Collaborator[][] = [];
  elementsPerPage: number = 10;
  currentPagination: number = 0;
  numberOfPaginations: number[] = [];

  constructor(private service: CollaboratorsService) { }

  ngOnInit(): void {
    this.collaboratorsServiceMap();
  }

  collaboratorsServiceMap(): void {
    this.service.getCollaboratorsList().subscribe((data) => {
      for (let i = 0; i < data.length; i += this.elementsPerPage) {
        const chunk = data.slice(i, i + this.elementsPerPage);
        this.collaboratorsArray.push(chunk);
      }
      this.numberOfPaginations = Array(Math.ceil(data.length / this.elementsPerPage)).fill(0).map((x,i)=>i);
    });
  }
  changePagination(i: number) {
    if (i < 0 || i >= this.collaboratorsArray.length)
      return;
    this.currentPagination = i;
  }
}
