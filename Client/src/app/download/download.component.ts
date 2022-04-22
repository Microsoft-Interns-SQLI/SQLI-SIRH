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
  download(document: any) {
    console.log(document);
    this.subscription = this.filesService
      .download(document.url)
      .subscribe((event) => {
        if (event.type === HttpEventType.UploadProgress)
          this.progress = Math.round((100 * event.loaded) / event.total);
        else if (event.type === HttpEventType.Response) {
          this.message = 'Download success.';
          this.downloadFile(event, document.url);
        }
      });
  }
  private downloadFile(data: HttpResponse<Blob>, docURL: any) {
    const downloadedFile = new Blob([data.body!], { type: data.body!.type });
    const a = document.createElement('a');
    a.setAttribute('style', 'display:none;');
    document.body.appendChild(a);
    a.download = docURL ? docURL : '';
    a.href = URL.createObjectURL(downloadedFile);
    a.target = '_blank';
    a.click();
    document.body.removeChild(a);
  }
}
