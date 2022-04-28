import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Certification } from '../Models/certification';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { Collaborator } from '../Models/Collaborator';
import { Pagination } from '../Models/pagination';
import { CollaboratorsService } from '../services/collaborators.service';
import { FormationCertificationsService } from '../services/formation-certifications.service';
import { PopupService } from './popup/popup.service';

@Component({
  selector: 'app-formations',
  templateUrl: './formations.component.html',
  styleUrls: ['./formations.component.css']
})
export class FormationsComponent implements OnInit, OnDestroy {

  selected: boolean = true;
  displayed: boolean = true;
  tab: CollabFormationCertif[] = [];
  cols: Certification[] = [];
  rows: Collaborator[] = [];

  //Subscription
  subCollab!: Subscription;
  subCertif!: Subscription;
  subCollabCertif!: Subscription;  
  subPopup!:Subscription;

  //pagination params
  pageNumber = 1;
  pageSize = 15;
  pagination: Pagination = {
    pageSize: this.pageSize,
    currentPage: this.pageNumber,
  } as Pagination;

  constructor(private popupService: PopupService,private formationCertifService: FormationCertificationsService, private collaborateurService: CollaboratorsService) { }


  ngOnInit(): void {
    this.subPopup = this.popupService.isShow.subscribe(data=> this.displayed = data);
  }

  onChange() {
    if (this.selected) {
      //fetch formation table
    } else {
      this.loadCollaborators(this.pageSize, this.pageNumber);

      this.subCertif = this.formationCertifService.getCertifications().subscribe(
        (data: Certification[]) => {
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
    orderby?: string
  ) {
    this.subCollab = this.collaborateurService
      .getCollaboratorsList(pageSize, pageNumber, filtrerPar, search, orderby)
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



  ngOnDestroy(): void {
    this.subCertif.unsubscribe();
    this.subCollab.unsubscribe();
    this.subCollabCertif.unsubscribe();
    this.subPopup.unsubscribe();
  }

}
