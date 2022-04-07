import { Component, OnInit } from '@angular/core';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-import-collabs',
  templateUrl: './import-collabs.component.html',
  styleUrls: ['./import-collabs.component.css']
})
export class ImportCollabsComponent implements OnInit {

  error:string = "";
  files:File[] = [];
  isValid:boolean = true;
  validComboDrag!:boolean;
  accept = '.csv,application/vnd.openxmlformats-officedocument.spreadsheetml.sheet,application/vnd.ms-excel';
  progress:number = 0;
  formData:FormData = new FormData();

  constructor(private collabService:CollaboratorsService) { }

  ngOnInit(): void {
  }


  fileChange(files:File[]) {
    this.formData.append('file',files[0]);
    console.log();
  }

  uploadFile(){
    this.collabService.importCollaborateurs(this.formData).subscribe(data=>console.log(data))
  }

}
