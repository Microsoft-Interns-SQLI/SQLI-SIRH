import { Component, Input, OnInit } from '@angular/core';
import { BehaviorSubject, delay, Observable, of, switchMap } from 'rxjs';

@Component({
  selector: 'app-spinner',
  templateUrl: './spinner.component.html',
  styleUrls: ['./spinner.component.css']
})
export class SpinnerComponent implements OnInit {

  private _isLoading = new BehaviorSubject(false);
  isLoading : Observable<boolean> = this._isLoading.pipe(
    switchMap(loading =>{
      if(!loading)
      {
        return of(false);
      }
      return of(true).pipe(delay(1000));
    })
  );
  constructor() { }

  ngOnInit(): void {
  }

  start(){/*
    this.timeout = setTimeout(()=>{
      this.isLoading=true;
    },Infinity);
    console.log("this is start");*/
    this._isLoading.next(true);
  }

  finish(){/*
    this.isLoading=false;
    clearTimeout(this.timeout);
    console.log("this is end");*/
    this._isLoading.next(false);
  }

}
