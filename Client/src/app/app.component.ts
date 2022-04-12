import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AuthService } from './services/auth.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers:[
   // {provide:HTTP_INTERCEPTORS,useClass:LoadingInterceptor,multi:true}
  ]
})
export class AppComponent implements OnInit {

  title = 'Client';

  constructor(private authService:AuthService){}

  ngOnInit(): void {
    this.authService.autoLogin();
  }


}


