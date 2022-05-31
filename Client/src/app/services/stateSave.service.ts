import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class SaveState {

  private readonly _states = new Map<string, BehaviorSubject<any>>();

  constructor () {}

  saveState(state: any, caller: string) {
    if (state) {
      let val = this._states.get(caller);
      if (val)
        val.next(state);
      else
        this._states.set(caller, new BehaviorSubject<any>(state));
    }
  }

  loadState(caller:string) : any {
    
    return this._states.get(caller)?.getValue();
  }
}
