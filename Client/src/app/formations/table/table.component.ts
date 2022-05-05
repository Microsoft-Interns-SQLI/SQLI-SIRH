import { AfterContentChecked, AfterContentInit, AfterViewChecked, AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Certification } from 'src/app/Models/certification';
import { CollabFormationCertif } from 'src/app/Models/collaborationCertificationFormation';
import { Collaborator } from 'src/app/Models/Collaborator';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit, OnChanges {

  @Input() table!:CollabFormationCertif[];
  @Input() rows: Collaborator[] =[];
  @Input() cols: Certification[] = [];

  newRows: {collaborateur: Collaborator, certificates: CollabFormationCertif[]}[] = [];

  constructor() { }

  ngOnChanges(changes: SimpleChanges): void {
    this.newRows = [];
    this.rows.forEach(collab=>{
      let certificates:CollabFormationCertif[] = [];
      
      this.cols.forEach(certif=>{
        const collabFormCert = this.table.find(x=>x.collaborateurId === collab.id && x.certificationId === certif.id);
        if(collabFormCert != undefined){
          certificates.push(collabFormCert);
        }else{
          certificates.push({status:''} as CollabFormationCertif);
        }
      });

      this.newRows.push({collaborateur:collab, certificates: certificates})
    });
    console.log(this.newRows);
  }

  ngOnInit(): void {
    
  }

}