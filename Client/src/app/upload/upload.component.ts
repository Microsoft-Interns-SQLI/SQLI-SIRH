import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { UploadService } from '../services/upload.service';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css'],
})
export class UploadComponent implements OnInit {
  files: any;
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
      let formData = new FormData();
      for (let fileToUpload of this.files) {
        formData.append('file', fileToUpload, fileToUpload.name);
      }
      this.uploadService.upload(formData).subscribe((res) => console.log(res));
    }
  }
}
