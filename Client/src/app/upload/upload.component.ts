import { HttpClient, HttpEventType } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { UploadService } from '../services/upload.service';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css'],
})
export class UploadComponent implements OnInit {
  error: string = '';
  files: File[] = [];
  isValid: boolean = true;
  isDone: boolean = false;
  validComboDrag!: boolean;
  accept = '.pdf,.doc,.docx';
  progress: number = 0;
  formData: FormData = new FormData();
  constructor(private uploadService: UploadService, private http: HttpClient) {}

  ngOnInit(): void {}
  public readFiles(files: any) {
    this.files = files;
  }
  public uploadFile() {
    if (this.files) {
      if (this.files.length === 0) {
        return;
      }

      for (let fileToUpload of this.files) {
        this.formData.append('file', fileToUpload, fileToUpload.name);
      }
      this.uploadService.upload(this.formData).subscribe({
        next: (event) => {
          if (event.type === HttpEventType.UploadProgress) {
            let total = event.total || 1;
            this.progress = Math.round(event.loaded / total) * 100;
          } else if (event.type === HttpEventType.Response) {
            if (event.ok) {
              this.error = '';
            }
          }
        },
        error: (err) => {
          this.error = err;
          this.isDone = true;
        },
        complete: () => (this.isDone = true),
      });
    }
  }
}
