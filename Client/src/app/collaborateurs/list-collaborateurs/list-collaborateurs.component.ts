import { Component, OnInit } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';
import { Pagination } from 'src/app/Models/pagination';
import { CollaboratorsService } from 'src/app/services/collaborators.service';
import { SpinnerComponent } from 'src/app/shared/spinner/spinner.component';

@Component({
  selector: 'app-list-collaborateurs',
  templateUrl: './list-collaborateurs.component.html',
  styleUrls: ['./list-collaborateurs.component.css'],
})
export class ListCollaborateursComponent implements OnInit {
  collaboratorsArray: Collaborator[] = [];
  displayTable: boolean = true;
  collabToDelete?: Collaborator = new Collaborator();
  pagination!: Pagination;
  pageNumber = 1;
  pageSize = 10;
  isLoading?: boolean;

  constructor(private service: CollaboratorsService) {}

  ngOnInit(): void {
    this.loadCollaborators();
  }

  loadCollaborators() {
    this.isLoading = true;
    this.service
      .getCollaboratorsList(this.pageSize, this.pageNumber)
      .subscribe({
        next: (resp) => {
          this.collaboratorsArray = resp.result;
          this.pagination = resp.pagination;
        },
        complete: () => {
          this.isLoading = false;
        },
      });
  }

  deleteCollab(id: any): void {
    this.collabToDelete = id;
  }
  confirmDelete(id: any): void {
    if (id) {
      this.service.deleteCollaborator(id).subscribe((res) => {
        console.log('deletion success!');
        this.loadCollaborators();
      });
    }
  }
  pageChanged(even: any) {
    this.pageNumber = even.page;
    this.loadCollaborators();
  }
  changeDisplay(event: any): void {
    if (event == 'table') {
      this.displayTable = true;
    }
    if (event == 'card') {
      this.displayTable = false;
    }
  }
  calculateYears(year: any): any {
    const date = new Date(year);
    const now = new Date(Date.now());
    return Math.abs(now.getFullYear() - date.getFullYear());
  }
}
