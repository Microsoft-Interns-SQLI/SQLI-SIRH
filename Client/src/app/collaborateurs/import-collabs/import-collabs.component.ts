import { HttpClient, HttpEvent, HttpEventType, HttpRequest, HttpResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-import-collabs',
  templateUrl: './import-collabs.component.html',
  styleUrls: ['./import-collabs.component.css']
})
export class ImportCollabsComponent implements OnInit {

  error: string = "";
  files: File[] = [];
  isValid: boolean = true;
  isDone: boolean = false;
  validComboDrag!: boolean;
  accept = '.csv,application/vnd.openxmlformats-officedocument.spreadsheetml.sheet,application/vnd.ms-excel';
  progress: number = 0;
  formData: FormData = new FormData();


  constructor(private collabService: CollaboratorsService, private http:HttpClient) { }

  ngOnInit(): void {
  }


  fileChange(files: File[]) {
    this.formData.append('file', files[0]);
    console.log();
  }

  uploadFile() {
    this.collabService.importCollaborateurs(this.formData)
      .subscribe({
        next: event => {
          if (event.type === HttpEventType.UploadProgress){
            let total = event.total || 1;
            this.progress = Math.round(event.loaded/total) * 100;
            console.log(total);
            console.log(event);
          }
          else if (event.type === HttpEventType.Response){
            if(event.ok){
              this.error = "";
            }
          }
        },
        error: err => {
          this.error = err;this.isDone = true
        },
        complete: ()=>this.isDone = true
      })
  }

}
