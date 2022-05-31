import { HttpEventType } from '@angular/common/http';
import {
  Component,
  EventEmitter,
  OnDestroy,
  OnInit,
  Output,
} from '@angular/core';
import { FilesService } from '../services/files.service';
import { Subscription } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { CollabFile } from '../Models/collabFile';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css'],
})
export class UploadComponent implements OnInit, OnDestroy {
  @Output() filesEmitter = new EventEmitter();

  SubscriptionArray?: Subscription[];
  subscription!: Subscription;
  subscription2!: Subscription;
  subscription3!: Subscription;
  error: string = '';
  files: File[] = [];
  isValid: boolean = true;
  isDone: boolean = false;
  isLoading: boolean = false;
  validComboDrag!: boolean;
  accept = '.pdf,.doc,.docx';
  collabId: number = 0;
  progress: number = 0;
  formData: FormData = new FormData();
  path: CollabFile[] = [];
  docType: string = 'CV';
  constructor(
    private filesService: FilesService,
    private route: ActivatedRoute
  ) {}
  ngOnDestroy(): void {}

  ngOnInit(): void {
    this.route.params.subscribe(({ id }) => (this.collabId = id));
  }
  onChange(value: any) {
    this.docType = value.target.value;
  }
  public readFiles(files: any) {
    this.files = files;
  }
  public uploadFile() {
    this.isLoading = true;
    if (this.files) {
      if (this.files.length === 0) {
        return;
      }

      for (let fileToUpload of this.files) {
        this.formData.set('file', fileToUpload, fileToUpload.name);
        this.subscription = this.filesService
          .upload(this.formData, this.docType, this.collabId)
          .subscribe({
            next: (event) => {
              if (event.type === HttpEventType.UploadProgress) {
                let total = event.total || 1;
                this.progress = Math.round(event.loaded / total) * 100;
              } else if (event.type === HttpEventType.Response) {
                if (event.ok) {
                  this.error = '';
                }
                this.path.push(event.body[0]);
              }
            },
            error: (err) => {
              this.error = err;
              this.isDone = true;
              this.isLoading = false;
            },
            complete: () => {
              this.isDone = true;
              this.isLoading = false;
            },
          });
      }
    }
  }

  onModalClose() {
    if (this.error === '') {
      this.filesEmitter.emit(this.path);
    }
    this.path.splice(0, this.path.length);
    this.files.splice(0, this.files.length);
    this.isDone = false;
    this.progress = 0;
    this.error = '';
  }
}
