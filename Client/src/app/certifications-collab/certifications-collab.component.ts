import { Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PopupService } from '../formations-certifications/popup/popup.service';
import { CertificationOrFormation } from '../Models/certification-formation';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { Collaborator } from '../Models/Collaborator';
import { FormationCertificationsService } from '../services/formation-certifications.service';

@Component({
  selector: 'app-certifications-collab',
  templateUrl: './certifications-collab.component.html',
  styleUrls: ['./certifications-collab.component.css']
})
export class CertificationsCollabComponent implements OnInit, OnChanges, OnDestroy {


  @Input() collab: Collaborator = {} as Collaborator;
  @Input() intersections: CollabFormationCertif[] = [];

  year: number = new Date(Date.now()).getFullYear();
  years: number[] = [];

  displayed: boolean = false;
  certifications: CertificationOrFormation[] = [];

  table: { name: string, intersection: CollabFormationCertif }[] = [];

  sub!: Subscription;
  subAdd!: Subscription;
  subPopup!: Subscription;
  subYear!: Subscription;
  subIntersection!: Subscription;

  statusTable = environment.status;

  error: string = "";

  constructor(private formationCertifService: FormationCertificationsService, private popupService: PopupService) { }
  
  ngOnChanges(changes: SimpleChanges): void {

    this.subYear = this.formationCertifService.getCertificationYearsByCollab(this.collab.id).subscribe({
      next: data => {
        this.years = data.sort((a, b) => b - a);
        if (data.length > 0) {
          this.year = data[0];
        }
      },
      complete: () => {
        if (+this.year !== new Date(Date.now()).getFullYear())
          this.fetchIntersection();
      }
    });

    if (this.intersections.length > 0) {

      this.sub = this.formationCertifService.getCertifications().subscribe({
        next: data => this.certifications = data,
        complete: ()=> this.prepareData()
      });

    } else {
      this.sub = this.formationCertifService.getCertifications().subscribe({
        next: data => this.certifications = data
      });
    }
  }



  ngOnInit(): void {
    this.subPopup = this.popupService.isShow.subscribe(data => this.displayed = data);
  }

  selectYear() {
    this.fetchIntersection();
  }

  onEdit(item: CollabFormationCertif) {
    this.popupService.show(item);
  }

  boxUpdated(value: CollabFormationCertif) {
    const index = this.table.findIndex(x => x.intersection.id === value.id);
    const intersection = this.table[index];
    if (index !== -1) {
      if (new Date(value.dateDebut).getFullYear() === new Date(intersection.intersection.dateDebut).getFullYear())
        this.table.splice(index, 1, { name: intersection.name, intersection: value });
      else {
        this.changeYearsDropDown(value);
        this.table.splice(index, 1);
      }
    }
  }

  addCertifications(result:CollabFormationCertif[]){
    result = result.map(item=> {
      item.collaborateurId = this.collab.id;
      return item;
    })

    this.subAdd = this.formationCertifService.updateCollabCertifs(this.collab.id, result).subscribe({
      complete: () => {
        result.forEach(x => {

          x.status = +x.status === 2 ? "FAIT" : "AFAIRE";

          const intersectionExist = this.intersections.find(i =>
            i.collaborateurId === x.collaborateurId
            && i.idFormationCertif === x.idFormationCertif
            && i.status === x.status
            && new Date(i.dateDebut).toDateString() === new Date(x.dateDebut).toDateString()
            && new Date(i.dateFin).toDateString() === new Date(x.dateFin).toDateString());


          if (intersectionExist == undefined) {
            this.intersections.push(x);
          }
        });
        this.prepareData();
      }
    });
  }
  // onSubmit() {
  //   this.subAdd = this.formationCertifService.updateCollabCertifs(this.collab.id, result).subscribe({
  //     complete: () => {
  //       result.forEach(x => {

  //         x.status = +x.status === 2 ? "FAIT" : "AFAIRE";

  //         const intersectionExist = this.intersections.find(i =>
  //           i.collaborateurId === x.collaborateurId
  //           && i.id === x.id
  //           && i.status === x.status
  //           && new Date(i.dateDebut).toDateString() === new Date(x.dateDebut).toDateString()
  //           && new Date(i.dateFin).toDateString() === new Date(x.dateFin).toDateString());


  //         if (intersectionExist == undefined) {
  //             this.intersections.push(x);
  //         }
  //       });
  //       this.prepareData();
  //     }
  //   });
  // }


  private changeYearsDropDown(value: CollabFormationCertif){
    if (this.years.findIndex(x => x === new Date(value.dateDebut).getFullYear()) === -1) {
      if(this.years.length === 0)
        this.year = new Date(value.dateDebut).getFullYear();
      this.years.push(new Date(value.dateDebut).getFullYear());
      this.years.sort((a, b) => b - a);
    }
  }

  private fetchIntersection() {
    this.subIntersection = this.formationCertifService.getCertificationByCollab(this.collab.id, undefined, this.year).subscribe({
      next: data => this.intersections = data.list,
      complete: () => this.prepareData()
    })
  }

  private prepareData() {
    this.table = [];
    this.intersections.forEach(item => {
      
      this.changeYearsDropDown(item);
      
      const certification = this.certifications.find(x => x.id === item.idFormationCertif);
      if (certification != undefined && new Date(item.dateDebut).getFullYear() === +this.year) {
        this.table = this.table.concat({ name: certification.libelle, intersection: item });
      }
    });

  }
  ngOnDestroy(): void {
    if (this.sub != undefined)
      this.sub.unsubscribe();
    this.subPopup.unsubscribe();
    if (this.subYear != undefined)
      this.subYear.unsubscribe();
    if (this.subAdd != undefined)
      this.subAdd.unsubscribe();
    if (this.subIntersection != undefined)
      this.subIntersection.unsubscribe();
  }
}
