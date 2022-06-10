import {
  Component,
  DoCheck,
  Input,
  KeyValueDiffers,
  OnChanges,
  OnDestroy,
  OnInit,
  SimpleChanges,
} from '@angular/core';
import { Subscription } from 'rxjs';
import { CollabFile } from '../Models/collabFile';
import { FilesService } from '../services/files.service';

@Component({
  selector: 'app-cv-reader',
  templateUrl: './cv-reader.component.html',
  styleUrls: ['./cv-reader.component.css'],
})
export class CvReaderComponent implements OnInit, OnDestroy, DoCheck {
  subscription?: Subscription;
  files?: CollabFile[];
  fileUrl?: string;
  @Input() docs?: any;
  fileSrc!: Blob;
  differ: any;
  constructor(
    private fileService: FilesService,
    private differs: KeyValueDiffers
  ) {
    this.differ = differs.find({}).create();
  }
  ngDoCheck(): void {
    let changes = this.differ.diff(this.docs);
    if (changes) {
      this.getLatestCv();
    }
  }

  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
  }

  ngOnInit(): void {
    this.getLatestCv();
  }

  getLatestCv() {
    this.files = this.docs?.filter(
      (d: any) => d.type === 'CV' && d.fileName.endsWith('.pdf')
    );
    if (this.files !== undefined && this.files?.length > 0) {
      this.fileUrl = this.files.reduce((a: any, b: any) =>
        a.creationDate > b.creationDate ? a : b
      ).url;
      this.subscription = this.fileService
        .download(this.fileUrl)
        .subscribe((res) => {
          this.fileSrc = res.body;
        });
    }
  }
}
