import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit {


  forms!:FormGroup;

  constructor() { }
  
  ngOnInit(): void {
    this.initForm();
   }

  onSubmit():void{
    console.log(this.forms.controls);
  }

  initForm():void{
    this.forms = new FormGroup({
      "email": new FormControl(null, [Validators.required, Validators.pattern("[A-Za-z0-9._-]+@[A-Za-z0-9._-]+\\.[a-z]{2,3}")]),
      "password": new FormControl(null, [Validators.required, Validators.min(6)])
    });
  }
}
