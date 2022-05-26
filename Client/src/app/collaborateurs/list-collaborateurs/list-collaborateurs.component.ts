import { HttpEventType, HttpResponse } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import * as FileSaver from 'file-saver';
import { Subscription } from 'rxjs';

import { Collaborator } from 'src/app/Models/Collaborator';
import { Pagination } from 'src/app/Models/pagination';
import { CollaboratorsService } from 'src/app/services/collaborators.service';
import { FilesService } from 'src/app/services/files.service';
import { ImagesService } from 'src/app/services/images.service';
import { SpinnerService } from 'src/app/services/spinner.service';
import { ToastService } from 'src/app/shared/toast/toast.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-list-collaborateurs',
  templateUrl: './list-collaborateurs.component.html',
  styleUrls: ['./list-collaborateurs.component.css'],
})
export class ListCollaborateursComponent implements OnInit, OnDestroy {
  collaboratorsArray: Collaborator[] = [];
  displayTable: boolean = true;
  collabToDelete?: Collaborator = new Collaborator();

  //subscription
  exportSubscription!: Subscription;
  loadCollabSubscription!: Subscription;
  imageSubscription!: Subscription;

  pageNumber = 1;
  pageSize = 10;
  //Initalize pagination to avert undefined error value in the child component
  pagination: Pagination = {
    pageSize: this.pageSize,
    currentPage: this.pageNumber,
  } as Pagination;

  isLoading?: boolean;

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
  postesValue: string = '';
  niveauxId: number[] = [];
  niveauxValue: string = '';


  constructor(
    private service: CollaboratorsService,
    private imageService: ImagesService,
    private fileService: FilesService,
    private toastService: ToastService,
    private spinnerService: SpinnerService
  ) { }

  ngOnInit(): void {
    this.loadCollaborators(this.pageSize, this.pageNumber);
  }

  loadCollaborators(
    pageSize?: number,
    pageNumber?: number,
    filtrerPar?: string,
    search?: string,
    orderby?: string,
    postesId?: string,
    niveauxId?: string
  ) {
    if (search != undefined) {
      this.spinnerService.isSearch.next(true);
    } else {
      this.spinnerService.isSearch.next(false);
    }
    this.loadCollabSubscription = this.service
      .getCollaboratorsList(pageSize, pageNumber, filtrerPar, search, orderby, undefined, undefined, postesId, niveauxId)
      .subscribe({
        next: (resp) => {
          console.log(resp);
          this.collaboratorsArray = resp.result;
          this.pagination = resp.pagination;
        },
        complete: () => {
          this.collaboratorsArray = this.collaboratorsArray.map(
            (collab: Collaborator) => {
              this.imageSubscription = this.imageService
                .checkImage(collab.id)
                .subscribe({
                  next: (d) => {
                    collab.imgPath = d
                      ? `${environment.URL}api/Image/${collab.id}`
                      : 'https://www.pngfind.com/pngs/m/676-6764065_default-profile-picture-transparent-hd-png-download.png';
                  },
                  error: (er) => console.log(er),
                });
              return collab;
            }
          );
        },
      });
  }

  //Executed when filter select change
  onSelect() {
    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesValue == '' ? undefined : this.postesValue,
      this.niveauxValue == '' ? undefined : this.niveauxValue
    );
  }

  // get pageSize value from header child component
  // update number of collab per page
  // update collab table
  changePageSize(pageSize: number) {
    this.pageSize = pageSize;

    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesValue == '' ? undefined : this.postesValue,
      this.niveauxValue == '' ? undefined : this.niveauxValue
    );
  }

  onChangePostes(postes: number[]) {
    this.postesId = postes;
    this.postesValue = this.postesId.toString().replace(',', '&postesId=')

    console.log("poste = " + this.postesId.toString());
    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesValue,
      this.niveauxValue == '' ? undefined : this.niveauxValue
    )
  }

  onChangeNiveaux(niveaux: number[]) {
    this.niveauxId = niveaux;
    this.niveauxValue = this.niveauxId.toString().replace(',', '&niveauxId=')

    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesValue == '' ? undefined : this.postesValue,
      this.niveauxValue
    )
  }

  // get search value from header child component
  // update collab table
  search(value: string) {
    this.searchInput = value;

    this.loadCollaborators(
      this.pageSize,
      1,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : value,
      undefined,
      this.postesValue == '' ? undefined : this.postesValue,
      this.niveauxValue == '' ? undefined : this.niveauxValue
    );
  }

  // get current page value from footer child component
  // update current page number(pageNumber)
  // update collab table
  getCurrentPage(page: number) {
    this.pageNumber = page;
    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      this.selected === '' ? undefined : this.selected,
      this.searchInput === '' ? undefined : this.searchInput,
      undefined,
      this.postesValue == '' ? undefined : this.postesValue,
      this.niveauxValue == '' ? undefined : this.niveauxValue
    );
  }

  deleteCollab(id: any): void {
    this.collabToDelete = id;
  }

  confirmDelete(id: any): void {
    let message =
      'Collaborateur ' +
      this.collabToDelete?.prenom +
      ' ' +
      this.collabToDelete?.nom +
      ' a été supprimer avec success';
    if (id) {
      this.service.deleteCollaborator(id).subscribe((res) => {
        console.log('deletion success!');
        this.loadCollaborators();
      });
    }
    this.toastService.showToast('success', message, 2);
  }
  changeDisplay(event: any): void {
    if (event == 'table') {
      this.displayTable = true;
    }
    if (event == 'card') {
      this.displayTable = false;
    }
  }

  export() {
    this.exportSubscription = this.service
      .exportCollaborateurs()
      .subscribe((data) => {
        const buffer = new Blob([data], { type: data.type });
        FileSaver.saveAs(buffer, 'Collaborateurs.xlsx');
      });
  }

  download(documents: any) {
    let fileUrl = documents
      .filter((d: any) => d.type === 'CV' && d.fileName.endsWith('.pdf'))
      .reduce((a: any, b: any) =>
        a.creationDate > b.creationDate ? a : b
      ).url;

    this.fileService.download(fileUrl).subscribe((event) => {
      this.downloadFile(event, fileUrl);
    });
  }

  private downloadFile(data: HttpResponse<Blob>, docURL: any) {
    const downloadedFile = new Blob([data.body!], { type: data.body!.type });
    const a = document.createElement('a');
    a.setAttribute('style', 'display:none;');
    document.body.appendChild(a);
    a.download = docURL ? docURL : '';
    a.href = URL.createObjectURL(downloadedFile);
    a.target = '_blank';
    a.click();
    document.body.removeChild(a);
  }

  calculateYears(year: any): number {
    const date = new Date(year);
    const now = new Date(Date.now());
    return Math.abs(now.getFullYear() - date.getFullYear());
  }

  ngOnDestroy(): void {
    this.exportSubscription.unsubscribe();
    this.loadCollabSubscription.unsubscribe();
    this.imageSubscription.unsubscribe();
  }
  trier(value: string) {
    switch (value) {
      case 'matricule': {
        if (this.trierParMatricule) {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'matricule_asc'
          );
        } else {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'matricule_desc'
          );
        }
        this.trierParMatricule = !this.trierParMatricule;
        break;
      }
      case 'nom': {
        if (this.trierParNom) {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            undefined
          ); // undefined because there is basically a sorted by name asc
        } else {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'nom_desc'
          );
        }
        this.trierParNom = !this.trierParNom;
        break;
      }
      case 'prenom': {
        if (this.trierParPrenom) {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'prenom_asc'
          );
        } else {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'prenom_desc'
          );
        }
        this.trierParPrenom = !this.trierParPrenom;
        break;
      }
      case 'exp': {
        if (this.trierParAnnee) {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'exp_asc'
          );
        } else {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'exp_desc'
          );
        }
        this.trierParAnnee = !this.trierParAnnee;
        break;
      }
      case 'poste': {
        if (this.trierParPoste) {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'poste_asc'
          );
        } else {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'poste_desc'
          );
        }
        this.trierParPoste = !this.trierParPoste;
        break;
      }
      case 'niveau': {
        if (this.trierParNiveau) {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'niveau_asc'
          );
        } else {
          this.loadCollaborators(
            this.pageSize,
            this.pageNumber,
            this.selected === '' ? undefined : this.selected,
            this.searchInput === '' ? undefined : this.searchInput,
            'niveau_desc'
          );
        }
        this.trierParNiveau = !this.trierParNiveau;
        break;
      }
    }
  }
}
