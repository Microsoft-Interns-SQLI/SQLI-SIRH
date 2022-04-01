import { Injectable } from "@angular/core";
import { ActivatedRoute, ActivatedRouteSnapshot, CanActivate, CanActivateChild, Router, RouterStateSnapshot, UrlTree } from "@angular/router";
import { map, Observable, take } from "rxjs";
import { User } from "../Models/user";
import { AuthService } from "../services/auth.service";

@Injectable({
    providedIn:'root'
})
export class CanActivateGuardService implements CanActivate,CanActivateChild{

    constructor(private authService:AuthService, private router:Router){}

    canActivateChild(childRoute: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
        return this.canActivate(childRoute,state);
    }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
        return this.authService.user.pipe(
            take(1),
            map((value:User)=>{
                const isAuth:boolean = !!value.email;
                return isAuth ? isAuth: this.router.createUrlTree(['login']);
            })
        );
    }

}