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
export class FormationsCollabComponent implements OnInit {

  @Input() collab: Collaborator = {} as Collaborator;
  intersections!: CollabFormationCertif[];


  year: number = new Date(Date.now()).getFullYear();

  constructor(private formationCertifService: FormationCertificationsService) { }



  ngOnInit(): void {
    this.formationCertifService.getFormationByCollab(this.collab.id).subscribe(data => {this.intersections = data.list});
  }


}
