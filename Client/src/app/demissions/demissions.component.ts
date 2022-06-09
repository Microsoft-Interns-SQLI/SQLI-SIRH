import { Component, OnDestroy, OnInit } from '@angular/core';
import { Collaborator } from '../Models/Collaborator';
import { Pagination } from '../Models/pagination';
import { CollaboratorsService } from '../services/collaborators.service';
import { SpinnerService } from '../services/spinner.service';
import { SaveState } from '../services/stateSave.service';
import { ToastService } from '../shared/toast/toast.service';

@Component({
  selector: 'app-demissions',
  templateUrl: './demissions.component.html',
  styleUrls: ['./demissions.component.css'],
})
export class DemissionsComponent implements OnInit, OnDestroy {
  demissionsArray: Collaborator[] = [];

  pageNumber = 1;
  pageSize = 10;
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

  postesId: number[] = [];
  niveauxId: number[] = [];

  constructor(
    private service: CollaboratorsService,
    private spinnerService: SpinnerService,
    private saveState: SaveState
  ) {}

  ngOnInit(): void {
    let state = this.saveState.loadState('ListState');
    if (state && state?.caller == 'demissions') {
      this.pagination = state?.pagination;
      // this.displayTable = state?.displayTable;
      this.selected = state?.selected;
      this.searchInput = state?.searchInput;
      this.trierParNom = state?.trierParNom;
      this.trierParPrenom = state?.trierParPrenom;
      this.trierParPoste = state?.trierParPoste;
      this.trierParNiveau = state?.trierParNiveau;
      this.trierParMatricule = state?.trierParMatricule;
      this.trierParAnnee = state?.trierParAnnee;
      this.postesId = state?.postesId;
      this.niveauxId = state?.niveauxId;
      this.loadDemissions(
        this.pagination.pageSize,
        this.pagination.currentPage,
        this.selected,
        this.searchInput === '' ? undefined : this.searchInput,
        undefined,
        this.postesId.toString() == '' ? undefined : this.postesId,
        this.niveauxId.toString() == '' ? undefined : this.niveauxId
      );
    }
    else
      this.loadDemissions(
        this.pagination.pageSize,
        this.pagination.currentPage,
      );
  }

  ngOnDestroy(): void {
    let saveStateObj = {
      caller: 'demissions',
      pagination: this.pagination,
      // displayTable: this.displayTable,
      selected: this.selected,
      searchInput: this.searchInput,
      trierParNom: this.trierParNom,
      trierParPrenom: this.trierParPrenom,
      trierParPoste: this.trierParPoste,
      trierParNiveau: this.trierParNiveau,
      trierParMatricule: this.trierParMatricule,
      trierParAnnee: this.trierParAnnee,
      postesId: this.postesId,
      niveauxId: this.niveauxId,
    }
    this.saveState.saveState(saveStateObj, 'ListState');
    this.saveState.saveState({ url: 'demissions' }, 'fallback');
  }

  loadDemissions(
    pageSize?: number,
    pageNumber?: number,
    filtrerPar?: string,
    search?: string,
    orderby?: string,
    postesId?: number[],
    niveauxId?: number[]
  ) {
    if (search != undefined) {
      this.spinnerService.isSearch.next(true);
    } else {
      this.spinnerService.isSearch.next(false);
    }
    this.service
      .getDemissionsList(
        pageSize,
        pageNumber,
        filtrerPar,
        search,
        orderby,
        undefined,
        undefined,
        postesId,
        niveauxId
      )
      .subscribe({
        next: (resp) => {
          this.demissionsArray = resp.result;
          this.pagination = resp.pagination;
        },
        complete: () => {
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

    this.loadDemissions(
      this.pageSize,
      this.pageNumber,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesId.toString() == '' ? undefined : this.postesId,
      this.niveauxId.toString() == '' ? undefined : this.niveauxId
    );
  }

  onChangePostes(postes: number[]) {
    this.postesId = postes;

    this.loadDemissions(
      this.pageSize,
      1,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesId,
      this.niveauxId.toString() == '' ? undefined : this.niveauxId
    );
  }

  onChangeNiveaux(niveaux: number[]) {
    this.niveauxId = niveaux;
    //this.niveauxValue = this.niveauxId.toString().replace(',', '&niveauxId=')

    this.loadDemissions(
      this.pageSize,
      1,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesId.toString() == '' ? undefined : this.postesId,
      this.niveauxId
    );
  }

  // get search value from header child component
  // update collab table
  search(value: string) {
    this.searchInput = value;

    this.loadDemissions(
      this.pageSize,
      1,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : value,
      undefined,
      this.postesId.toString() == '' ? undefined : this.postesId,
      this.niveauxId.toString() == '' ? undefined : this.niveauxId
    );
  }

  getCurrentPage(page: number) {
    this.pageNumber = page;
    this.loadDemissions(
      this.pageSize,
      this.pageNumber,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesId.toString() == '' ? undefined : this.postesId,
      this.niveauxId.toString() == '' ? undefined : this.niveauxId
    );
  }
}
