import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-add-edit-collaborateur',
  templateUrl: './add-edit-collaborateur.component.html',
  styleUrls: ['./add-edit-collaborateur.component.css']
})
export class AddEditCollaborateurComponent implements OnInit {
  readonly collab_id: string;
  collab?: Collaborator;

  constructor(private actRoute: ActivatedRoute, private sevice: CollaboratorsService) {
    this.collab_id = this.actRoute.snapshot.params['id'];
    console.log(this.collab_id);
  }

  ngOnInit(): void {
    this.sevice.getCollaboratorByMatricule(this.collab_id).subscribe(res => {
      this.collab = res;
      console.log(this.collab);
    })
  }

}
