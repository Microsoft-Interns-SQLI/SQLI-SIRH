import { Component, OnDestroy, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit, OnDestroy {


  forms!:FormGroup;
  isLoading:boolean = false;
  error!:string;
  subscription!: Subscription;

  constructor(private authService: AuthService, private router: Router, private toastrService: ToastrService) { }
  
  ngOnInit(): void {
    this.initForm();
  }
  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  onSubmit():void{
    const email:string = this.forms.controls['email'].value;
    const password:string = this.forms.controls['password'].value;

    this.isLoading = true;

    this.subscription = this.authService.login(email, password).subscribe({
      next:()=>{
        this.router.navigate(['home'])
        this.isLoading = false;
        this.toastrService.success("Operation is done successfully!","Sign-in success");
      },
      error:(err)=>{        
        this.isLoading = false
        this.error = err;
      }
    })
  }

  initForm():void{
    this.forms = new FormGroup({
      "email": new FormControl(null, [Validators.required, Validators.pattern("[A-Za-z0-9._-]+@[A-Za-z0-9._-]+\\.[a-z]{2,3}")]),
      "password": new FormControl(null, [Validators.required, Validators.minLength(6)])
    });
  } 
}
