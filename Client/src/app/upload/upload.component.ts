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
  validComboDrag!: boolean;
  accept = '.pdf,.doc,.docx';
  progress: number = 0;
  formData: FormData = new FormData();
  path: string = '';
  constructor(
    private filesService: FilesService,
    private collabService: CollaboratorsService,
    private router: ActivatedRoute
  ) {}
  ngOnDestroy(): void {
    this.SubscriptionArray = [
      this.subscription2,
      this.subscription3,
      this.subscription,
    ];
    this.SubscriptionArray.map((sub) => sub.unsubscribe());
  }

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
      this.subscription = this.filesService.upload(this.formData).subscribe({
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
        },
        complete: () => {
          this.isDone = true;
        },
      });

      this.subscription2 = this.router.params
        .pipe(
          concatMap(({ id }) =>
            this.collabService.getCollaboratorByMatricule(id)
          )
        )
        .subscribe((collab) => {
          collab.files = collab.files.concat(this.path);
          console.log(collab);
          this.subscription3 = this.collabService
            .updateCollaborator(collab.id, collab)
            .subscribe();
        });

      // this.collabService.getCollaboratorByMatricule(87).subscribe((res) => {
      //   console.log(res);
      //   res.files = res.files.concat(this.path);
      //   this.collabService.updateCollaborator(87, res).subscribe();
      // });
    }
  }
}
