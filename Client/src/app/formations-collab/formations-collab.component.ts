import { Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { PopupService } from '../formations-certifications/popup/popup.service';
import { CertificationOrFormation } from '../Models/certification-formation';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { Collaborator } from '../Models/Collaborator';
import { FormationCertificationsService } from '../services/formation-certifications.service';

@Component({
  selector: 'app-formations-collab',
  templateUrl: './formations-collab.component.html',
  styleUrls: ['./formations-collab.component.css']
})
export class FormationsCollabComponent implements OnInit, OnChanges, OnDestroy {

  form!: FormGroup;

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


  error: string = "";

  constructor(private formationCertifService: FormationCertificationsService, private popupService: PopupService) { }

  ngOnChanges(changes: SimpleChanges): void {
    
    if (this.intersections.length > 0) {
      this.sub = this.formationCertifService.getFormations().subscribe({
        next: data => this.formations = data,
        complete: ()=> this.prepareData()
      });
      
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
    }
    else{
      this.sub = this.formationCertifService.getFormations().subscribe({
        next: data => this.formations = data
      });
    }
  }

  ngOnInit(): void {
    this.subPopup = this.popupService.isShow.subscribe(data => this.displayed = data);

    this.form = new FormGroup({
      'formations': new FormArray([])
    })


  }

  private fetchIntersection() {
    this.subIntersection = this.formationCertifService.getFormationByCollab(this.collab.id, undefined, this.year).subscribe({
      next: data => this.intersections = data.list,
      complete: () => this.prepareData()
    })
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

  addFormation() {
    this.controls.push(new FormGroup({
      'name': new FormControl(0, Validators.required),
      'status': new FormControl(1, Validators.required),
      'dateDebut': new FormControl(null, Validators.required),
      'dateFin': new FormControl(null, Validators.required)
    }))
  }

  deleteFormation(index: number) {
    if (this.controls.length === 1) {
      this.error = "";
    }
    this.controls.removeAt(index);
  }
  onSubmit() {
    let errorSelect: boolean = false;
    let errorDate: boolean = false;
    this.error = "";
    let result: CollabFormationCertif[] = [];

    this.controls.value.forEach((item: any) => {
      if (+item.name === 0) {
        errorSelect = true;
        return;
      }
      if (new Date(item.dateDebut).getTime() > new Date(item.dateFin).getTime()) {
        errorDate = true;
        return;
      }
      result.push({
        collaborateurId: this.collab.id,
        status: item.status,
        idFormationCertif: item.name,
        dateDebut: item.dateDebut,
        dateFin: item.dateFin
      } as CollabFormationCertif);
    });

    if (errorSelect) {
      this.error = "Please selecte the formation";
      return;
    } else if (errorDate) {
      this.error = "The start date must be earlier than end date";
      return;
    }

    this.subAdd = this.formationCertifService.updateCollabFormations(this.collab.id, result).subscribe({
      complete: () => {
        result.forEach(x => {

          x.status = +x.status === 2 ? "FAIT" : "AFAIRE";

          const intersectionExist = this.intersections.find(i =>
            i.collaborateurId === x.collaborateurId
            && i.id === x.id
            && i.status === (+x.status === 1 ? "AFAIRE" : "FAIT")
            && new Date(i.dateDebut).toDateString() === new Date(x.dateDebut).toDateString()
            && new Date(i.dateFin).toDateString() === new Date(x.dateFin).toDateString());


          if (intersectionExist == undefined) {
            const intersectionUpdate = this.intersections.findIndex(i => i.collaborateurId === x.collaborateurId && i.id === x.id);
            if (intersectionUpdate !== -1)
              this.intersections.splice(intersectionUpdate, 1, x);
            else
              this.intersections.push(x);
          }
        });
        this.prepareData();
        this.controls.clear();
      }
    });
  }
  get controls() {
    return (this.form.get("formations") as FormArray);
  }

  private changeYearsDropDown(value: CollabFormationCertif){
    if (this.years.findIndex(x => x === new Date(value.dateDebut).getFullYear()) === -1) {
      this.years.push(new Date(value.dateDebut).getFullYear());
      this.years.sort((a, b) => b - a);
    }
  }

  private prepareData() {
    
    this.table = [];
    this.intersections.forEach(item => {
      const formation = this.formations.find(x => x.id === item.idFormationCertif);
      if (formation != undefined && new Date(item.dateDebut).getFullYear() === +this.year) {
        this.table = this.table.concat({ name: formation.libelle, intersection: item });
      }
      this.changeYearsDropDown(item);
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
