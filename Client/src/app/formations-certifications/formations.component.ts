import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { CertificationOrFormation } from '../Models/certification-formation';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { Collaborator } from '../Models/Collaborator';
import { Pagination } from '../Models/pagination';
import { CollaboratorsService } from '../services/collaborators.service';
import { FormationCertificationsService } from '../services/formation-certifications.service';

@Component({
  selector: 'app-formations',
  templateUrl: './formations.component.html',
  styleUrls: ['./formations.component.css']
})
export class FormationsComponent implements OnInit, OnDestroy {

  selected: boolean = true;
  tab: CollabFormationCertif[] = [];
  cols: CertificationOrFormation[] = [];
  rows: Collaborator[] = [];

  //Subscription
  subCollab!: Subscription;
  subCertif!: Subscription;
  subCollabCertif!: Subscription;  

  //pagination params
  pageNumber = 1;
  pageSize = 15;
  pagination: Pagination = {
    pageSize: this.pageSize,
    currentPage: this.pageNumber,
  } as Pagination;

  constructor(private formationCertifService: FormationCertificationsService, private collaborateurService: CollaboratorsService) { }


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
        (data: CollabFormationCertif[])=>{
          this.tab = data;
        }
      )

    } else {
      this.subCertif = this.formationCertifService.getCertifications().subscribe(
        (data: CertificationOrFormation[]) => {
          this.cols = data;
        }
      );

      this.subCollabCertif = this.formationCertifService.getCollabCertif().subscribe(
        (data: CollabFormationCertif[])=>{
          this.tab = data;
        }
      )
    }
  }

  loadCollaborators(
    pageSize?: number,
    pageNumber?: number,
    filtrerPar?: string,
    search?: string,
    orderby?: string,
    orderbyFormation?:string,
    orderbyCertification?:string
  ) {
    this.subCollab = this.collaborateurService
      .getCollaboratorsList(pageSize, pageNumber, filtrerPar, search, orderby,orderbyFormation, orderbyCertification)
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

  sortData(libelle:string){
    this.loadCollaborators(
      this.pageSize, 
      this.pageNumber,
      undefined, 
      undefined, 
      undefined, 
      this.selected ? libelle : undefined,
      !this.selected ? libelle : undefined);
  }

  ngOnDestroy(): void {
    this.subCertif.unsubscribe();
    this.subCollab.unsubscribe();
    this.subCollabCertif.unsubscribe();
  }

}