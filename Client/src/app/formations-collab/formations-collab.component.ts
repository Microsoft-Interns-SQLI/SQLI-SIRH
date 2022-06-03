import { Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges, ViewChild } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { Subscription } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PopupService } from '../formations-certifications/popup/popup.service';
import { CertificationOrFormation } from '../Models/certification-formation';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { Collaborator } from '../Models/Collaborator';
import { FormationCertificationsService } from '../services/formation-certifications.service';
import { ToastService } from '../shared/toast/toast.service';

@Component({
  selector: 'app-formations-collab',
  templateUrl: './formations-collab.component.html',
  styleUrls: ['./formations-collab.component.css']
})
export class FormationsCollabComponent implements OnInit, OnChanges, OnDestroy {


  @Input() collab: Collaborator = {} as Collaborator;
  @Input() intersections: CollabFormationCertif[] = [];


  year: number = new Date(Date.now()).getFullYear();
  years: number[] = [];

  displayed: boolean = false;
  formations: CertificationOrFormation[] = [];

  table: { name: string, intersection: CollabFormationCertif }[] = [];

  sub!: Subscription;
  subAdd!: Subscription;
  subPopup!: Subscription;
  subYear!: Subscription;
  subIntersection!: Subscription;
  subRemove!: Subscription;


  error: string = "";

  constructor(
    private formationCertifService: FormationCertificationsService,
    private popupService: PopupService,
    private toastService: ToastService) { }

  ngOnChanges(changes: SimpleChanges): void {

    this.subYear = this.formationCertifService.getFormationYearsByCollab(this.collab.id).subscribe({
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
      this.sub = this.formationCertifService.getFormations().subscribe({
        next: data => this.formations = data,
        complete: () => this.prepareData()
      });
    }
    else {
      this.sub = this.formationCertifService.getFormations().subscribe({
        next: data => this.formations = data
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

  addFormations(result: CollabFormationCertif[]) {
    result = result.map(item => {
      item.collaborateurId = this.collab.id;
      return item;
    })

    this.subAdd = this.formationCertifService.updateCollabFormations(this.collab.id, result).subscribe({
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
  //   let errorSelect: boolean = false;
  //   let errorDate: boolean = false;
  //   this.error = "";
  //   let result: CollabFormationCertif[] = [];

  //   this.controls.value.forEach((item: any) => {
  //     if (+item.name === 0) {
  //       errorSelect = true;
  //       return;
  //     }
  //     if (new Date(item.dateDebut).getTime() > new Date(item.dateFin).getTime()) {
  //       errorDate = true;
  //       return;
  //     }
  //     result.push({
  //       collaborateurId: this.collab.id,
  //       status: item.status,
  //       idFormationCertif: item.name,
  //       dateDebut: item.dateDebut,
  //       dateFin: item.dateFin
  //     } as CollabFormationCertif);
  //   });

  //   if (errorSelect) {
  //     this.error = "Please selecte the formation";
  //     return;
  //   } else if (errorDate) {
  //     this.error = "The start date must be earlier than end date";
  //     return;
  //   }


  // }
  onDelete(id: number) {
    if (confirm("Are you sure you want to remove this formation?"))
      this.subRemove = this.formationCertifService.removeCollabFormation(id).subscribe({
        next: () => {
          const index = this.table.findIndex(x => x.intersection.id === id);
          if (index !== -1)
            this.table.splice(index, 1);
        },
        error: (err) => this.error = err.error,
        complete: () => {
          this.error = "";
          this.toastService.showToast("success", "Formation deleted successfully!", 2);
        }
      });
  }


  private changeYearsDropDown(value: CollabFormationCertif) {
    if (this.years.findIndex(x => x === new Date(value.dateDebut).getFullYear()) === -1) {
      if (this.years.length === 0)
        this.year = new Date(value.dateDebut).getFullYear();
      this.years.push(new Date(value.dateDebut).getFullYear());
      this.years.sort((a, b) => b - a);
    }
  }
  private fetchIntersection() {
    this.subIntersection = this.formationCertifService.getFormationByCollab(this.collab.id, undefined, this.year).subscribe({
      next: data => this.intersections = data.list,
      complete: () => this.prepareData()
    })
  }
  private prepareData() {

    this.table = [];
    this.intersections.forEach(item => {

      this.changeYearsDropDown(item);

      const formation = this.formations.find(x => x.id === item.idFormationCertif);
      if (formation != undefined && new Date(item.dateDebut).getFullYear() === +this.year) {
        this.table = this.table.concat({ name: formation.libelle, intersection: item });
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
    if (this.subRemove != undefined)
      this.subRemove.unsubscribe();
  }

}
