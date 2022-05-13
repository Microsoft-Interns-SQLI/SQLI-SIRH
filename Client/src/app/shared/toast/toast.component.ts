import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Toaster, ToastService } from './toast.service';

@Component({
  selector: 'app-toast',
  templateUrl: './toast.component.html',
  styleUrls: ['./toast.component.css']
})
export class ToastComponent implements OnInit {

  constructor(private toastService: ToastService) { }

  title?: string;

  typeMessage?: string;

  message?: string;

  durationInSec!:number;

  sub!: Subscription;
  ngOnInit(): void {
    this.sub = this.toastService.toast.subscribe((data: Toaster) => {
      this.typeMessage = data.typeMessage;
      this.message = data.message;
      this.typeMessage == 'danger' ? this.title = "Danger" :
        this.typeMessage == 'warning' ? this.title = "Warning" :
          this.typeMessage == 'success' ? this.title = "Success" : this.title = "Information";
      setTimeout(() => {
        this.close();
      }, this.durationInSec*1000);
    });
  }

  close() {
    this.toastService.closeToast();
  }
}
