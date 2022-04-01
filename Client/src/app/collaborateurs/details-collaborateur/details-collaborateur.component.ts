import { Component, Input, OnInit } from '@angular/core';
import { Collaborator } from 'src/app/Models/Collaborator';
import { ActivatedRoute } from '@angular/router';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-details-collaborateur',
  templateUrl: './details-collaborateur.component.html',
  styleUrls: ['./details-collaborateur.component.css']
})
export class DetailsCollaborateurComponent implements OnInit {

  collab_id: string;
  collab: any;
  age?: number;

  constructor(private actRoute: ActivatedRoute, private service: CollaboratorsService) {
    this.collab_id = this.actRoute.snapshot.params['id'];
    console.log(this.collab_id)
  }

  ngOnInit(): void {
    this.service.getCollaboratorByMatricule(this.collab_id).subscribe(res => {
      this.collab=res;
      console.log(this.collab);
    });
  }

  // collaboratorsServiceMap(): void {
  //   this.collab = this.service.getCollaboratorByMatricule(this.collab_id);
  // }

}
