import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs";
import { environment } from "src/environments/environment";
import { Collaborator } from "../Models/Collaborator";
import { PaginatedResults } from "../Models/pagination";

@Injectable({
  providedIn: 'root'
})
export class DemissionService {
  readonly myUrl: string = `${environment.URL}api/demission`;
  paginatedResult: PaginatedResults<Collaborator[]> = new PaginatedResults<Collaborator[]>();

  constructor(private http: HttpClient) {}

  getDemissionsList(itemsPerPage?: number, page?: number, filtrerPar?: string, search?: string, orderby?: string,orderbyFormation?:string, orderbyCertification?:string) {
    let params = new HttpParams();
    if (page != undefined && itemsPerPage != undefined) {
      params = params.append('pageNumber', page.toString());
      params = params.append('pageSize', itemsPerPage.toString());
    }
    if (filtrerPar != undefined) {
      params = params.append("Site", filtrerPar)
    }
    if (orderby != undefined)
      params = params.append('OrderBy', orderby.toString());

    if (search != undefined) {
      params = params.append("Search", search);
    }
    if(orderbyFormation !=undefined){
      params = params.append("OrderByFormation", orderbyFormation);
    }

    if(orderbyCertification !=undefined){
      params = params.append("OrderByCertification", orderbyCertification);
    }

    return this.http.get<any>(this.myUrl, {observe: 'response', params}).pipe(
      map((response) => {
        this.paginatedResult.result = response.body;
        if (response.headers.get('Pagination') != null) {
          this.paginatedResult.pagination = JSON.parse(
            response.headers.get('Pagination') || ''
          );
        }
        return this.paginatedResult;
      })
    )
  }
}
