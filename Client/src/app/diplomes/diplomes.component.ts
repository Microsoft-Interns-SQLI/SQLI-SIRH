import { Component, Input, OnInit } from '@angular/core';
import { Collaborator } from '../Models/Collaborator';
import { DiplomesService } from '../services/diplomes.service';

@Component({
  selector: 'app-diplomes',
  templateUrl: './diplomes.component.html',
})
export class DiplomesComponent implements OnInit {
  @Input() collab?: Collaborator;

  constructor(private diplomesService: DiplomesService) { }

  ngOnInit(): void {
  }

  deleteDiplome(idDiplome: number) {
    this.diplomesService.deleteDiplome(idDiplome).subscribe((result) => {
      console.log("delete success !!");
      this.diplomesService.getAllDiplomes();
    });
  }
}
