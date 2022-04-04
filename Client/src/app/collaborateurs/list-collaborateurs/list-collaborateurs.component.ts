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
  collabToDelete?: Collaborator = new Collaborator();
  elementsPerPage: number = 10;
  currentPagination: number = 0;
  numberOfPaginations: number[] = [];

  constructor(private service: CollaboratorsService) { }

  ngOnInit(): void {
    this.collaboratorsServiceMap();
  }

  collaboratorsServiceMap(): void {
    this.service.getCollaboratorsList(this.elementsPerPage, this.currentPagination + 1)
      .subscribe((data) => {
      this.collaboratorsArray = data.items;
      this.numberOfPaginations = Array(Math.ceil(data.total / this.elementsPerPage)).fill(0).map((x,i)=>i);
    });
  }
  changePagination(i: number) {
    if (i < 0 || i >= this.numberOfPaginations.length)
      return;
    this.currentPagination = i;
    this.collaboratorsServiceMap();
  }

  deleteCollab(id:any): void {
    // this.service.deleteCollaborator(id).subscribe(res => {
    //   console.log("deletion success!");
    //   this.collaboratorsServiceMap();
    // })
    this.collabToDelete = id;
  }
  confirmDelete(id:any): void {
    if (id) {
      this.service.deleteCollaborator(id).subscribe(res => {
        console.log("deletion success!");
        this.collaboratorsServiceMap();
      });
    }
  }
  
}
