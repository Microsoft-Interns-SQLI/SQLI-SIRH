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
  displayTable: boolean = true;
  collabToDelete?: Collaborator = new Collaborator();

  pageNumber = 1;
  pageSize = 10;

  //Initalize pagination to avert undefined error value in the child component
  pagination: Pagination = {
    pageSize: this.pageSize,
    currentPage: this.pageNumber
  } as Pagination;

  isLoading?: boolean;

  //selected --> filter
  selected: string = "";

  //searchInput --> search
  searchInput: string = "";

  trierParNom: boolean = false;
  trierParPrenom: boolean = false;
  trierParPoste: boolean = false;
  trierParNiveau: boolean = false;
  trierParMatricule: boolean = false;
  trierParAnnee: boolean = false;

  constructor(private service: CollaboratorsService) { }


  ngOnInit(): void {
    this.loadCollaborators(this.pageSize, this.pageNumber);
  }

  loadCollaborators(pageSize?: number, pageNumber?: number, filtrerPar?: string, search?: string, orderby?: string) {
    this.isLoading = true;
    this.service.getCollaboratorsList(pageSize, pageNumber, filtrerPar, search, orderby).subscribe(
      {
        next: resp => {
          this.collaboratorsArray = resp.result;
          this.pagination = resp.pagination;
        },
        complete: () => {
          this.isLoading = false;
        }
      })
  }

  //Executed when filter select change 
  onSelect() {
    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      this.selected,
      this.searchInput === "" ? undefined : this.searchInput);
  }

  // get pageSize value from header child component
  // update number of collab per page
  // update collab table 
  changePageSize(pageSize: number) {
    this.pageSize = pageSize;

    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      this.selected === "" ? undefined : this.selected,
      this.searchInput === "" ? undefined : this.searchInput);
  }

  // get search value from header child component
  // update collab table 
  search(value: string) {
    this.searchInput = value;

    this.loadCollaborators(
      this.pageSize,
      1,
      this.selected === "" ? undefined : this.selected,
      this.searchInput === "" ? undefined : value);
  }

  // get current page value from footer child component
  // update current page number(pageNumber)
  // update collab table 
  getCurrentPage(page: number) {
    this.pageNumber = page;
    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      this.selected === "" ? undefined : this.selected,
      this.searchInput === "" ? undefined : this.searchInput);
  }
  
  deleteCollab(id: any): void {
    this.collabToDelete = id;
  }
  confirmDelete(id: any): void {
    if (id) {
      this.service.deleteCollaborator(id).subscribe(res => {
        console.log("deletion success!");
        this.loadCollaborators();
      });
    }
  }
  changeDisplay(event: any): void {
    if (event == 'table') {
      this.displayTable = true;
    }
    if (event == 'card') {
      this.displayTable = false;
    }
  }
  
  calculateYears(year: any): number {
    const date = new Date(year)
    const now = new Date(Date.now())
    return Math.abs(now.getFullYear() - date.getFullYear())
  }

  trier(value: string) {
    switch (value) {
      case 'matricule': {
        this.sort(value, this.trierParMatricule);
        this.trierParMatricule = !this.trierParMatricule;
        break;
      }
      case 'nom': {
        this.sort(value, this.trierParNom);
        this.trierParNom = !this.trierParNom;
        break;
      }
      case 'prenom': {
        this.sort(value, this.trierParPrenom);
        this.trierParPrenom = !this.trierParPrenom;
        break;
      }
      case 'exp': {
        this.sort(value, this.trierParAnnee);
        this.trierParAnnee = !this.trierParAnnee;
        break;
      }
      case 'poste': {
        this.sort(value, this.trierParPoste);
        this.trierParPoste = !this.trierParPoste;
        break;
      }
      case 'niveau': {
        this.sort(value, this.trierParNiveau);
        this.trierParNiveau = !this.trierParNiveau;
        break;
      }
    }
  }

  private sort(attr: string, asc: boolean) {
    switch (attr) {
      case "matricule":
        if (asc) {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return +x.matricule - +y.matricule;
          }).slice();
        } else {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return +y.matricule - +x.matricule;
          }).slice();
        }
        break;

      case "nom":
        if (asc) {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return x.nom.toUpperCase() > y.nom.toUpperCase() ? 1 : x.nom.toUpperCase() < y.nom.toUpperCase() ? -1 : 0;
          }).slice();
        } else {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return x.nom.toUpperCase() > y.nom.toUpperCase() ? -1 : x.nom.toUpperCase() < y.nom.toUpperCase() ? 1 : 0;
          }).slice();
        }
        break;

      case "prenom":
        if (asc) {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return x.prenom.toUpperCase() > y.prenom.toUpperCase() ? 1 : x.prenom.toUpperCase() < y.prenom.toUpperCase() ? -1 : 0;
          }).slice();
        } else {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return x.prenom.toUpperCase() > y.prenom.toUpperCase() ? -1 : x.prenom.toUpperCase() < y.prenom.toUpperCase() ? 1 : 0;
          }).slice();
        }
        break;

      case "exp":
        if (asc) {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return this.calculateYears(x.dateEntreeSqli) - this.calculateYears(y.dateEntreeSqli)
          }).slice();
        } else {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return this.calculateYears(y.dateEntreeSqli) - this.calculateYears(x.dateEntreeSqli)
          }).slice();
        }
        break;

      case "poste":
        if (asc) {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return x.poste.toUpperCase() > y.poste.toUpperCase() ? 1 : x.poste.toUpperCase() < y.poste.toUpperCase() ? -1 : 0;
          }).slice();
        } else {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return x.poste.toUpperCase() > y.poste.toUpperCase() ? -1 : x.poste.toUpperCase() < y.poste.toUpperCase() ? 1 : 0;
          }).slice();
        }
        break;

      case "niveau":
        if (asc) {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return x.niveau.toUpperCase() > y.niveau.toUpperCase() ? 1 : x.niveau.toUpperCase() < y.niveau.toUpperCase() ? -1 : 0;
          }).slice();
        } else {
          this.collaboratorsArray = this.collaboratorsArray.sort((x, y) => {
            return x.niveau.toUpperCase() > y.niveau.toUpperCase() ? -1 : x.niveau.toUpperCase() < y.niveau.toUpperCase() ? 1 : 0;
          }).slice();
        }
        break;
    }
  }
}
