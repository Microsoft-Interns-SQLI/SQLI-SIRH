import { AfterContentInit, AfterViewInit, Component, DoCheck, Input, OnInit } from '@angular/core';
import { CertificationOrFormation } from '../Models/certification-formation';
import { CollabFormationCertif } from '../Models/collaborationCertificationFormation';
import { Collaborator } from '../Models/Collaborator';
import { FormationCertificationResponse, FormationCertificationsService } from '../services/formation-certifications.service';

@Component({
  selector: 'app-formations-collab',
  templateUrl: './formations-collab.component.html',
  styleUrls: ['./formations-collab.component.css']
})
export class FormationsCollabComponent implements OnInit, DoCheck {

  @Input() collab: Collaborator = {} as Collaborator;
  formations!: CertificationOrFormation[];
  intersections!: CollabFormationCertif[];

  table: { formation: CertificationOrFormation, intersection: CollabFormationCertif }[] = [];
  ok:boolean = false;

  year: number = new Date(Date.now()).getFullYear();

  constructor(private formationCertifService: FormationCertificationsService) { }

  ngDoCheck(): void {
    if (this.formations != undefined && this.intersections != undefined && !this.ok)
      this.prepareTable();
  }

  ngOnInit(): void {
    this.formationCertifService.getFormationByCollab(this.collab.id).subscribe(data => this.intersections = data.list);
    this.formationCertifService.getFormations().subscribe({
      next: data => this.formations = data
    });
  }

  prepareTable() {
      this.intersections.forEach(item => {
        const value = this.formations.find(x => x.id === item.id);

        if (value != undefined) {
          this.table = this.table.concat({ formation: value, intersection: item });
        }
      });
      this.ok = true;
  }

}
