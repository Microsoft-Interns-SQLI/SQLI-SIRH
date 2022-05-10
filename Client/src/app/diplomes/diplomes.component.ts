import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { mergeMap } from 'rxjs';
import { Collaborator } from '../Models/Collaborator';
import { DiplomesService } from '../services/diplomes.service';

@Component({
  selector: 'app-diplomes',
  templateUrl: './diplomes.component.html',
})
export class DiplomesComponent implements OnInit {
  @Input() collab!: Collaborator;

  constructor(private diplomesService: DiplomesService) { }

  ngOnInit(): void { }

  deleteDiplome(idDiplome: number) {
    this.diplomesService.deleteDiplome(idDiplome).pipe(
      mergeMap(() => this.diplomesService.getCollabDiplomes(this.collab.id))
    ).subscribe((diplomes) => {
      this.collab!.diplomes = diplomes;
    })
  }


}
