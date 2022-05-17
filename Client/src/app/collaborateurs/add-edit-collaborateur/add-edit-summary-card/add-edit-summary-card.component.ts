import { HttpClient, HttpEventType } from '@angular/common/http';
import { AfterContentChecked, ChangeDetectorRef, Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { catchError, Subscription } from 'rxjs';
import { Collaborator } from 'src/app/Models/Collaborator';
import { ImagesService } from 'src/app/services/images.service';
import { SpinnerService } from 'src/app/services/spinner.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-add-edit-summary-card',
  templateUrl: './add-edit-summary-card.component.html',
  styleUrls: ['./add-edit-summary-card.component.css']
})
export class AddEditSummaryCardComponent implements OnInit, OnDestroy, OnChanges {
  @Input() collab!: Collaborator;

  selected: boolean = false;
  selectedImage!: File;
  progress: number = 0;
  errorMessage: string = "";
  imgPath: string = 'https://bootstrapious.com/i/snippets/sn-team/teacher-2.jpg';

  sub!: Subscription;
  subImage!: Subscription;

  constructor(private imagesService: ImagesService, private spinnerService: SpinnerService, private cdRef: ChangeDetectorRef) { }

  


  ngOnInit(): void {
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.collab.id !== 0)
      this.subImage = this.imagesService.checkImage(this.collab.id).subscribe({
        next: d=>{
          this.imgPath = d ? `${environment.URL}api/Image/${this.collab.id}` : 'https://bootstrapious.com/i/snippets/sn-team/teacher-2.jpg';
        },
        error: er=> console.log(er)
      });
  }

  uploadImage(image: any) {
    this.selected = true;
    this.selectedImage = <File>image.target.files[0];
  }
  onUpload() {
    this.spinnerService.isSearch.next(true);
    const fd = new FormData();
    fd.append('image', this.selectedImage, this.selectedImage.name);
    this.sub = this.imagesService.upload(fd, this.collab.id)
      .subscribe({
        next: event => {
          if (event.type === HttpEventType.UploadProgress) {
            this.progress = Math.round(event.loaded / (event.total || 1) * 100);
          }
        },
        error: err => {
          this.errorMessage = err;
          this.selected = false;
        },
        complete: () => {
          this.selected = false;
          this.errorMessage = "";
          this.imgPath = `${environment.URL}api/Image/${this.collab.id}?${new Date().getTime()}`;
          this.progress = 0
        }
      })
  }

  calculateYears(year: any): any {
    const date = new Date(year);
    const now = new Date(Date.now());
    return Math.abs(now.getFullYear() - date.getFullYear());
  }

  ngOnDestroy(): void {
    if (this.sub != undefined)
      this.sub.unsubscribe();

    this.subImage.unsubscribe();
  }
}
