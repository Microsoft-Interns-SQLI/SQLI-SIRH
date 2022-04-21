import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { delay } from 'rxjs';
import { Collaborator } from 'src/app/Models/Collaborator';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-add-edit-collaborateur',
  templateUrl: './add-edit-collaborateur.component.html',
  styleUrls: ['./add-edit-collaborateur.component.css'],
})
export class AddEditCollaborateurComponent implements OnInit {
  readonly collab_id: string;
  collab: Collaborator = new Collaborator();

  constructor(
    private actRoute: ActivatedRoute,
    private sevice: CollaboratorsService
  ) {
    this.collab_id = this.actRoute.snapshot.params['id'];
  }

  ngOnInit(): void {
    
    if (this.collab_id) {
      this.sevice
        .getCollaboratorByMatricule(this.collab_id)
        .subscribe((res) => {
          this.collab = res;
          console.log(res);
        });
    } else {
      this.collab = new Collaborator();
    }
  }

  saveCollaborator(): void {
    console.log(this.collab);
    let message="";
    if (this.collab_id) {
      this.sevice
        .updateCollaborator(this.collab_id, this.collab)
        .subscribe((res) => {
          console.log('Update Success');
        });
        message=this.collab.prenom+" "+this.collab.nom+" a été modifier avec success";
    } else {
      this.sevice.addCollaborator(this.collab).subscribe((res) => {
        let collaborator: any = res;
        message=this.collab.prenom+" "+this.collab.nom+" a été modifier avec success";
        delay(3000);
        window.location.href = `/addEditcollaborateur/${collaborator.id}`;
      });
    }
  }
  calculateYears(year: any): any {
    const date = new Date(year);
    const now = new Date(Date.now());
    return Math.abs(now.getFullYear() - date.getFullYear());
  }
}
