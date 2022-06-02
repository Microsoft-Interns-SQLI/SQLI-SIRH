import { Component, OnDestroy, OnInit } from '@angular/core';
import { delay, Observable, Subscription } from 'rxjs';
import { CertificationOrFormation } from '../Models/certification-formation';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { Collaborator } from '../Models/Collaborator';
import { Pagination } from '../Models/pagination';
import { CollaboratorsService } from '../services/collaborators.service';
import { FormationCertificationResponse, FormationCertificationsService } from '../services/formation-certifications.service';
import { SpinnerService } from '../services/spinner.service';

@Component({
  selector: 'app-formations',
  templateUrl: './formations.component.html',
  styleUrls: ['./formations.component.css']
})
export class FormationsComponent implements OnInit, OnDestroy {


  tab: CollabFormationCertif[] = [];
  cols: CertificationOrFormation[] = [];
  rows: Collaborator[] = [];
  annees: number[] = [];
  yearSelected: number = new Date(Date.now()).getFullYear();
  statusSelected: number = 0;

  selected: boolean = true;

  //Subscription
  subCollab!: Subscription;
  subCertif!: Subscription;
  subCollabCertif!: Subscription;
  subAnnees!: Subscription;

  //pagination params
  pageNumber = 1;
  pageSize = 15;
  pagination: Pagination = {
    pageSize: this.pageSize,
    currentPage: this.pageNumber,
  } as Pagination;

  constructor(private formationCertifService: FormationCertificationsService,
    private collaborateurService: CollaboratorsService,
    private spinnerService: SpinnerService) { }


  ngOnInit(): void {
    this.onSwitch();
  }

  onSwitch() {

    this.loadCollaborators(this.pageSize, this.pageNumber);

    if (this.selected) {
      this.subCertif = this.formationCertifService.getFormations().subscribe(
        (data: CertificationOrFormation[]) => {
          this.cols = data;
        }
      );

      this.subCollabCertif = this.formationCertifService.getCollabFormation().subscribe(
        (data: FormationCertificationResponse) => {
          this.tab = data.list;
        }
      );
      
      this.subAnnees = this.formationCertifService.getFormationYears().subscribe(data => this.annees = data);

    } else {
      this.subCertif = this.formationCertifService.getCertifications().subscribe(
        (data: CertificationOrFormation[]) => {
          this.cols = data;
        }
      );

      this.subCollabCertif = this.formationCertifService.getCollabCertif().subscribe(
        (data: FormationCertificationResponse) => {
          this.tab = data.list;
        }
      );

      this.subAnnees = this.formationCertifService.getCertificationYears().subscribe(data => this.annees = data);
    }
  }

  loadCollaborators(
    pageSize?: number,
    pageNumber?: number,
    search?: string,
    orderbyFormation?: string,
    orderbyCertification?: string,
    year?:number,
    status?:number
  ) {
    if (search != undefined) {
      this.spinnerService.isSearch.next(true);
    } else {
      this.spinnerService.isSearch.next(false);
    }
    this.subCollab = this.collaborateurService
      .getCollaboratorsList(pageSize, pageNumber, undefined, search, undefined, orderbyFormation, orderbyCertification,undefined,undefined, year,status)
      .subscribe(
        resp => {
          this.rows = resp.result;
          this.pagination = resp.pagination;
        }
      );
  }

  getCurrentPage(page: number) {
    this.pageNumber = page;
    this.loadCollaborators(
      this.pageSize,
      this.pageNumber
    );
  }

  sortData(libelle: string) {
    this.loadCollaborators(
      this.pageSize,
      this.pageNumber,
      undefined,
      this.selected ? libelle : undefined,
      !this.selected ? libelle : undefined,
      this.yearSelected,
      +this.statusSelected === 0 ? undefined : this.statusSelected
      );

      if (this.selected) {
  
        this.subCollabCertif = this.formationCertifService.getCollabFormation().subscribe(
          (data: FormationCertificationResponse) => {
            this.tab = data.list;
          }
        );
      }else{
        this.subCollabCertif = this.formationCertifService.getCollabCertif().subscribe(
          (data: FormationCertificationResponse) => {
            this.tab = data.list;
          }
        );
      }
  }
  
  onSearch(search: string):void{
      this.loadCollaborators(
        this.pageSize,
        1,
        search === '' ? undefined : search,
        undefined,
        undefined,
        undefined
      )
    
  }
  updateYears(year: number) {
    let yearExist: boolean = false;
    this.annees.forEach((value: number) => {
      if (value === year) yearExist = true;
    });

    this.annees = yearExist ? this.annees.sort((a, b) => a - b) : this.annees.concat(year).sort((a, b) => a - b);
  }

  filter(data: { status: number, year: number }) {
    this.filterTable(+data.status, data.year);
    this.yearSelected = data.year;
    this.statusSelected = data.status;
  }

  private filterTable(status?: number, annee?: number) {
    const s: number | undefined = status === 0 ? undefined : status;

    if (this.selected) {

      this.subCollabCertif = this.formationCertifService.getCollabFormation(s, annee).subscribe(
        (data: FormationCertificationResponse) => {
          this.tab = data.list;
        }
      )

    } else {
      this.subCollabCertif = this.formationCertifService.getCollabCertif(s, annee).subscribe(
        (data: FormationCertificationResponse) => {
          this.tab = data.list;
        }
      )
    }
  }

  ngOnDestroy(): void {
    this.subCertif.unsubscribe();
    this.subCollab.unsubscribe();
    this.subCollabCertif.unsubscribe();
    this.subAnnees.unsubscribe();
  }

}
