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
  collab: Collaborator = new Collaborator();

  constructor(private actRoute: ActivatedRoute, private sevice: CollaboratorsService) {
    this.collab_id = this.actRoute.snapshot.params['id'];
  }

  ngOnInit(): void {
    if (this.collab_id) {
      this.sevice.getCollaboratorByMatricule(this.collab_id).subscribe(res => {
        this.collab = res;
        console.log(
          res
        );
      });
    } else {
      this.collab = new Collaborator();
    }
  }

  saveCollaborator(): void {
    console.log(this.collab);
    if (this.collab_id) {
      this.sevice.updateCollaborator(this.collab_id, this.collab).subscribe((res) => {
        console.log('Update Success');
      })
    } else {
      this.sevice.addCollaborator(this.collab).subscribe(res => {
        let collaborator: any = res;
        console.log('Add success');
        window.location.href = `/addEditcollaborateur/${collaborator.id}`;
      })
    }
  }
  calculateYears(year: any): any {
    const date = new Date(year)
    const now = new Date(Date.now())
    return Math.abs(now.getFullYear() - date.getFullYear())
  }
}
