import { Component, OnInit } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';
import { Pagination } from 'src/app/Models/pagination';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-list-collaborateurs',
  templateUrl: './list-collaborateurs.component.html',
  styleUrls: ['./list-collaborateurs.component.css']
})
export class ListCollaborateursComponent implements OnInit {
  collaboratorsArray: Collaborator[] = [];
  collabToDelete?: Collaborator = new Collaborator();
  pagination!: Pagination;
  pageNumber = 1;
  pageSize = 10;

  constructor(private service: CollaboratorsService) { }

  ngOnInit(): void {
    this.loadCollaborators();
  }

  loadCollaborators() {
    this.service.getCollaboratorsList(this.pageSize, this.pageNumber).subscribe(resp => {
      this.collaboratorsArray = resp.result;
      this.pagination = resp.pagination;
    })
  }

  deleteCollab(id:any): void {
    this.collabToDelete = id;
  }
  confirmDelete(id:any): void {
    if (id) {
      this.service.deleteCollaborator(id).subscribe(res => {
        console.log("deletion success!");
        this.loadCollaborators();
      });
    }
  }
  pageChanged(even: any) {
    this.pageNumber = even.page;
    this.loadCollaborators();
  }
  
}
