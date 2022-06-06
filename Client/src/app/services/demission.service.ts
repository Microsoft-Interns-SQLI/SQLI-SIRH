import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map, Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { Collaborator, Demission } from "../Models/Collaborator";
import { PaginatedResults } from "../Models/pagination";
import { ImagesService } from "./images.service";

@Injectable({
 providedIn: 'root'
})
export class DemissionService {
  readonly myUrl: string = `${environment.URL}api/demission`;
  paginatedResult: PaginatedResults<Collaborator[]> = new PaginatedResults<Collaborator[]>();

  constructor (private http: HttpClient, private imageService: ImagesService) {}

  addDemission(obj: Demission) : Observable<any> {
    return this.http.post(this.myUrl, obj);
  }

  updateDemission(obj: Demission) : Observable<Demission> {
    return this.http.put<Demission>(this.myUrl + `${obj.id}`, obj);
  }

  deleteDemission(id: string|number) : Observable<Demission> {
    return this.http.delete<Demission>(this.myUrl + `${id}`);
  }

}
