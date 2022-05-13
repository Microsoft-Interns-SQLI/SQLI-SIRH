import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { mergeMap } from 'rxjs';
import { Collaborator } from '../Models/Collaborator';
import { CollabTypeContrat } from '../Models/MdmModel';
import { ContratsService } from '../services/contrats.service';

@Component({
  selector: 'app-contrats',
  templateUrl: './contrats.component.html',
})
export class ContratsComponent implements OnInit {
  @ViewChild("affectations") affectations!: CollabTypeContrat[];
  @Input() collab!: Collaborator;

  constructor(private contratsService: ContratsService) { }

  ngOnInit(): void {
    this.contratsService.getContratsOfCollab(this.collab.id).subscribe((contrats) => {
      this.affectations = contrats;
    });
  }

  deleteAffectation(idAffectation: number) {
    this.contratsService.deleteAffectation(idAffectation).pipe(
      mergeMap(() => this.contratsService.getContratsOfCollab(this.collab.id))
    ).subscribe((contrats) => {
      this.affectations = contrats;
    })
  }
}
