import { HttpClient, HttpEvent, HttpEventType, HttpRequest, HttpResponse } from '@angular/common/http';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { CollaboratorsService } from 'src/app/services/collaborators.service';

@Component({
  selector: 'app-import-collabs',
  templateUrl: './import-collabs.component.html',
  styleUrls: ['./import-collabs.component.css']
})
export class ImportCollabsComponent implements OnInit {

  messages: string[] = [];
  error: string = "";
  files: File[] =[];
  isValid: boolean = true;
  isDone: boolean = false;
  isLoading: boolean = false;
  validComboDrag!: boolean;
  accept = '.csv,application/vnd.openxmlformats-officedocument.spreadsheetml.sheet,application/vnd.ms-excel';
  progress: number = 0;
  formData: FormData = new FormData();


  constructor(private collabService: CollaboratorsService) { }

  ngOnInit(): void {
  }


  fileChange(files: File[]) {
    if(files.length > 1){
      this.init();
    }
    this.formData.append('file', files[0]);
  }
  clear(){
    this.init();
  }
  uploadFile() {
    this.isLoading = true;
    this.collabService.importCollaborateurs(this.formData)
      .subscribe({
        next: event => {
          if (event.type === HttpEventType.UploadProgress) {
            let total = event.total || 1;
            this.progress = Math.round((event.loaded / total) * 100);
          }
          else if (event.type === HttpEventType.Response) {
            if (event.ok) {
              this.messages.push(`${event.body.ExistsCollab} Collaborateurs existaient déjà dans la BD !`);
              this.messages.push(`${event.body.AddingCollab} Collaborateurs ajoutés à la bd!`);
              this.error = "";
            }
          }
        },
        error: err => {
          this.error = err;this.isLoading = false;
        },
        complete: () => {
          this.isDone = true; 
          this.isLoading = false;
          }
      })
  }
  close(){
    if(this.isDone){
      this.init();
    }
  }


  init(){
    this.files.splice(0,1);
    this.formData.delete('file');
    this.progress = 0;
    this.isDone = false;
    this.error = "";
    this.messages = [];
  }

}
