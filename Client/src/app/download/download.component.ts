import { HttpEventType, HttpResponse } from '@angular/common/http';
import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Collaborator } from '../Models/Collaborator';
import { FilesService } from '../services/files.service';

@Component({
  selector: 'app-download',
  templateUrl: './download.component.html',
  styleUrls: ['./download.component.css'],
})
export class DownloadComponent implements OnInit, OnDestroy {
  @Input() collab?: Collaborator;
  subscription?: Subscription;
  message: string = '';
  progress: number = 0;
  constructor(private filesService: FilesService) {}
  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
  }

  ngOnInit(): void {}
  download() {
    this.subscription = this.filesService
      .download(this.collab?.files)
      .subscribe((event) => {
        if (event.type === HttpEventType.UploadProgress)
          this.progress = Math.round((100 * event.loaded) / event.total);
        else if (event.type === HttpEventType.Response) {
          this.message = 'Download success.';
          this.downloadFile(event);
        }
      });
  }
  private downloadFile(data: HttpResponse<Blob>) {
    const downloadedFile = new Blob([data.body!], { type: data.body!.type });
    const a = document.createElement('a');
    a.setAttribute('style', 'display:none;');
    document.body.appendChild(a);
    a.download = this.collab?.files ? this.collab?.files : '';
    a.href = URL.createObjectURL(downloadedFile);
    a.target = '_blank';
    a.click();
    document.body.removeChild(a);
  }
}
