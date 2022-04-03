import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, CanActivateChild, Router, RouterStateSnapshot, UrlTree } from "@angular/router";
import { ToastrService } from "ngx-toastr";
import { map, Observable, take } from "rxjs";

import { User } from "../Models/user";
import { AuthService } from "../services/auth.service";

@Injectable({
    providedIn:'root'
})
export class CanActivateGuardService implements CanActivate,CanActivateChild{

    constructor(private authService:AuthService, private router:Router, private toastrService:ToastrService){}

    canActivateChild(childRoute: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
        return this.canActivate(childRoute,state);
    }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
        
        const exp:number = +JSON.parse(localStorage.getItem("expiration") || '-1');

        if(exp === -1){
            this.toastrService.warning("You must be logged in before accessing to the page!","Login required");
            return this.router.createUrlTree(['login']);
        }
        if(this.authService.isExpired(exp)){
            this.authService.logout();
            this.toastrService.error('Token expired! try to reconnect','Expiration Problem');
            return this.router.createUrlTree(['login']);
        }
        return this.authService.user.pipe(
            take(1),
            map((value:User)=>{
                const isAuth:boolean = !!value.email;
                if(!isAuth){
                    this.toastrService.warning("You must be logged in before accessing to the page!","Login required");
                    return this.router.createUrlTree(['login']);
                }
                return isAuth;
            })
        );
        
    }

}