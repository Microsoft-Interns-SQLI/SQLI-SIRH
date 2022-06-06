import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { FilesService } from '../services/files.service';

@Component({
  selector: 'app-cv-reader',
  templateUrl: './cv-reader.component.html',
  styleUrls: ['./cv-reader.component.css'],
})
export class CvReaderComponent implements OnInit, OnDestroy {
  subscription?: Subscription;
  fileUrl?: string;
  @Input() docs?: any;
  fileSrc!: Blob;
  constructor(private fileService: FilesService) {}
  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
  }

  ngOnInit(): void {
    this.fileUrl = this.docs
      ?.filter((d: any) => d.type === 'CV' && d.fileName.endsWith('.pdf'))
      .reduce((a: any, b: any) =>
        a.creationDate > b.creationDate ? a : b
      ).url;
    console.log(this.fileUrl);
    this.fileService.download(this.fileUrl).subscribe((res) => {
      this.fileSrc = res.body;
      console.log(res);
    });
  }
}
