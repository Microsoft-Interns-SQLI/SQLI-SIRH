import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, catchError, Observable, tap, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../Models/user';
import { UserResponse } from '../Models/userResponse';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  user:BehaviorSubject<User> = new BehaviorSubject({} as User);

  url:string = environment.URL;
  constructor(private http: HttpClient) { }

  login(email:string, password:string):Observable<UserResponse>{
    return this.http.post<UserResponse>(this.url+"login",{
      email: email,
      password: password
    }).pipe(
      tap((data:UserResponse)=>this.handleAuthentication(data)),
      catchError(this.handleError)
    );
  }

  private handleAuthentication(userResponse: UserResponse):void{
    this.user.next(userResponse.user);
    localStorage.setItem("token", userResponse.accessToken);
    localStorage.setItem("expiration", userResponse.expiration);
    localStorage.setItem("user", JSON.stringify(userResponse.user));
  }

  autoLogin():void{
    const user: User = JSON.parse(localStorage.getItem('user') || "{}");

    this.user.next(user);
  }

  logout():void{
    localStorage.clear();
    this.user.next({} as User);
  }


  isExpired(exp:number):boolean{
    return Date.now() > exp;
  }

  private handleError(error:HttpErrorResponse):Observable<never>{

    return throwError(()=> error.error);
  }
}
