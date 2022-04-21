import { HttpClient, HttpEventType } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FilesService } from '../services/files.service';
import { concatMap, last, map, Subscription, switchMap } from 'rxjs';
import { CollaboratorsService } from '../services/collaborators.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css'],
})
export class UploadComponent implements OnInit, OnDestroy {
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
  path: string = '';
  constructor(
    private filesService: FilesService,
    private collabService: CollaboratorsService,
    private route: ActivatedRoute
  ) {}
  ngOnDestroy(): void {}

  ngOnInit(): void {
    this.route.params.subscribe(({ id }) => (this.collabId = id));
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
        this.formData.append('file', fileToUpload, fileToUpload.name);
      }
      this.subscription = this.filesService
        .upload(this.formData, this.collabId)
        .subscribe({
          next: (event) => {
            if (event.type === HttpEventType.UploadProgress) {
              let total = event.total || 1;
              this.progress = Math.round(event.loaded / total) * 100;
            } else if (event.type === HttpEventType.Response) {
              if (event.ok) {
                this.error = '';
              }
              this.path = event.body[0];
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
