import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { delay, Subscription } from 'rxjs';
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
      }, 5000);
    });
  }
  close() {
    var myToast: HTMLElement = document.getElementById("toast-div") as HTMLElement;
    myToast.setAttribute("class", "toast fade hide");
  }
}
