import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { map, take } from 'rxjs';
import { User } from 'src/app/Models/user';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-header-bar',
  templateUrl: './header-bar.component.html',
  styleUrls: ['./header-bar.component.css']
})
export class HeaderBarComponent implements OnInit {

  constructor(private authService: AuthService, private router:Router) { }
  isLogin: boolean = false;
  ngOnInit(): void {
    this.authService.user.subscribe((data: User) => {
      this.isLogin = !!data.email;
    })
  }

  onSignOut(): void {
    this.authService.logout();
    this.router.navigate(['login']);
  }

}
