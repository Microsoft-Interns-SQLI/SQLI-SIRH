import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { CertificationOrFormation } from 'src/app/Models/certification-formation';
import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-popup-add-formations-or-certifications',
  templateUrl: './popup-add-formations-or-certifications.component.html',
  styleUrls: ['./popup-add-formations-or-certifications.component.css']
})
export class PopupAddFormationsOrCertificationsComponent implements OnInit {

  @Output() resultFormationEvent: EventEmitter<CollabFormationCertif[]> = new EventEmitter<CollabFormationCertif[]>();
  @Output() resultCertifEvent: EventEmitter<CollabFormationCertif[]> = new EventEmitter<CollabFormationCertif[]>();
  @Input() formationsOrCertification: CertificationOrFormation[] = [];
  @Input() type!: string;


  form!: FormGroup;

  statusTable = environment.status;

  error: string = "";

  constructor() { }


  ngOnInit(): void {
    this.form = new FormGroup({
      'fc': new FormArray([
        new FormGroup({
          'name': new FormControl(0, Validators.required),
          'status': new FormControl(1, Validators.required),
          'dateDebut': new FormControl(null, Validators.required),
          'dateFin': new FormControl(null, Validators.required)
        })
      ])
    })
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
        status: item.status,
        idFormationCertif: item.name,
        dateDebut: item.dateDebut,
        dateFin: item.dateFin
      } as CollabFormationCertif);
    });

    if (errorSelect) {
      this.error = "Please selecte a " + this.type;
      return;
    } else if (errorDate) {
      this.error = "The start date must be earlier than end date";
      return;
    }
    if (this.type === "formation")
      this.resultFormationEvent.emit(result);
    else this.resultCertifEvent.emit(result);
    this.formInit();
    // this.subAdd = this.formationCertifService.updateCollabFormations(this.collab.id, result).subscribe({
    //   complete: () => {
    //     result.forEach(x => {

    //       x.status = +x.status === 2 ? "FAIT" : "AFAIRE";

    //       const intersectionExist = this.intersections.find(i =>
    //         i.collaborateurId === x.collaborateurId
    //         && i.idFormationCertif === x.idFormationCertif
    //         && i.status === x.status
    //         && new Date(i.dateDebut).toDateString() === new Date(x.dateDebut).toDateString()
    //         && new Date(i.dateFin).toDateString() === new Date(x.dateFin).toDateString());


    //       if (intersectionExist == undefined) {
    //         this.intersections.push(x);
    //       }
    //     });
    //     this.prepareData();
    //     this.controls.clear();
    //   }
    // });
  }

  get controls() {
    return (this.form.get("fc") as FormArray);
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
      return;
    }

    this.controls.removeAt(index);
  }

  formInit() {
    this.controls.clear();
    this.form = new FormGroup({
      'fc': new FormArray([
        new FormGroup({
          'name': new FormControl(0, Validators.required),
          'status': new FormControl(1, Validators.required),
          'dateDebut': new FormControl(null, Validators.required),
          'dateFin': new FormControl(null, Validators.required)
        })
      ])
    })
  }


}
