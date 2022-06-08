import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { AutoUnsubscribe } from '../decorators/AutoUnsubscribe';
import { Toaster, ToastService } from './toast.service';

@Component({
  selector: 'app-toast',
  templateUrl: './toast.component.html',
  styleUrls: ['./toast.component.css']
})
@AutoUnsubscribe()
export class ToastComponent implements OnInit {

  constructor(private toastService: ToastService) { }

  title?: string;

  typeMessage?: string;

  message?: string;

  toastDuration?: number;

  sub!: Subscription;
  
  ngOnInit(): void {
    this.sub = this.toastService.toast.subscribe((data: Toaster) => {
      this.typeMessage = data.typeMessage;
      this.message = data.message;
      this.toastDuration = data.duration * 1000
      this.typeMessage == 'danger' ? this.title = "Danger" :
        this.typeMessage == 'warning' ? this.title = "Warning" :
          this.typeMessage == 'success' ? this.title = "Success" : this.title = "Information";
    });
  }

  close() {
    this.toastService.closeToast();
  }


}
