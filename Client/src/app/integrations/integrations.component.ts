import { Component, OnInit } from '@angular/core';
import { Collaborator } from '../Models/Collaborator';
import { Pagination } from '../Models/pagination';
import { CollaboratorsService } from '../services/collaborators.service';
import { SpinnerService } from '../services/spinner.service';
import { ToastService } from '../shared/toast/toast.service';

@Component({
  selector: 'app-integrations',
  templateUrl: './integrations.component.html',
  styleUrls: ['./integrations.component.css']
})
export class IntegrationsComponent implements OnInit {
  demissionsArray: Collaborator[] = [];

  pageNumber = 1;
  pageSize = 10;
  pageYear = Date.now;
  //Initalize pagination to avert undefined error value in the child component
  pagination: Pagination = {
    pageSize: this.pageSize,
    currentPage: this.pageNumber,
  } as Pagination;

  //selected --> filter
  selected: string = '';

  //searchInput --> search
  searchInput: string = '';

  trierParNom: boolean = false;
  trierParPrenom: boolean = false;
  trierParPoste: boolean = false;
  trierParNiveau: boolean = false;
  trierParMatricule: boolean = false;
  trierParAnnee: boolean = false;

  constructor(private service: CollaboratorsService, private toastService: ToastService, private spinnerService: SpinnerService) { }


  ngOnInit(): void {
    this.loadIntegrations(this.pageSize, this.pageNumber, )
  }

  loadIntegrations(
    pageSize?: number,
    pageNumber?: number,
    filtrerPar?: string,
    search?: string,
    orderby?: string
  ) {
    if (search != undefined) {
      this.spinnerService.isSearch.next(true);
    } else {
      this.spinnerService.isSearch.next(false);
    }
    this.service.getDemissionsList(pageSize, pageNumber, filtrerPar, search, orderby)
      .subscribe({
        next: (resp) => {
          this.demissionsArray = resp.result;
          this.pagination = resp.pagination;
        },
        complete: () =>{
          console.log(this.demissionsArray);
        },
      });
  }

  calculateYears(year: any): number {
    const date = new Date(year);
    const now = new Date(Date.now());
    return Math.abs(now.getFullYear() - date.getFullYear());
  }

      // get pageSize value from header child component
  // update number of collab per page
  // update collab table
  changePageSize(pageSize: number) {
    this.pageSize = pageSize;

    this.loadIntegrations(
      this.pageSize,
      this.pageNumber,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput
    );
  }

  // get search value from header child component
  // update collab table
  search(value: string) {
    this.searchInput = value;

    this.loadIntegrations(
      this.pageSize,
      1,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : value
    );
  }

  getCurrentPage(page: number) {
    this.pageNumber = page;
    this.loadIntegrations(
      this.pageSize,
      this.pageNumber,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput
    );
  }

}
