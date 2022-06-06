import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs";
import { environment } from "src/environments/environment";
import { Collaborator } from "../Models/Collaborator";
import { PaginatedResults } from "../Models/pagination";
import { ImagesService } from "./images.service";

@Injectable({
 providedIn: 'root'
})
export class DemissionService {
  readonly myUrl: string = `${environment.URL}api/Demission`;
  paginatedResult: PaginatedResults<Collaborator[]> = new PaginatedResults<Collaborator[]>();

  constructor (private http: HttpClient, private imageService: ImagesService) {}

  getDemissionsList(
    itemsPerPage?: number,
    page?: number,
    filtrerPar?: string,
    search?: string,
    orderby?: string,
    orderbyFormation?: string,
    orderbyCertification?: string,
    postesId?: number[],
    niveauxId?: number[]
  ) {
    //delay(50000);
    let params = new HttpParams();
    if (page != undefined && itemsPerPage != undefined) {
      params = params.append('pageNumber', page.toString());
      params = params.append('pageSize', itemsPerPage.toString());
    }
    if (filtrerPar != undefined) {
      params = params.append('Site', filtrerPar);
    }
    if (orderby != undefined)
      params = params.append('OrderBy', orderby.toString());

    if (search != undefined) {
      params = params.append('Search', search);
    }
    if (orderbyFormation != undefined) {
      params = params.append('OrderByFormation', orderbyFormation);
    }

    if (orderbyCertification != undefined) {
      params = params.append('OrderByCertification', orderbyCertification);
    }

    if (postesId != undefined && postesId.toString() != '') {
      params = params.appendAll({ postesId: postesId });
    }
    if (niveauxId != undefined && niveauxId.toString() != '') {
      console.log(niveauxId.length);
      params = params.appendAll({ niveauxId: niveauxId });
    }
    return this.http
      .get<any>(this.myUrl + '/demission', { observe: 'response', params })
      .pipe(
        map((response) => {
          this.paginatedResult.result = <Collaborator[]>response.body.map(
            (collab: Collaborator) => {
              let currentCarriere = collab.carrieres
                ?.sort((a, b) => a.annee - b.annee)
                .pop();
              collab.niveau = currentCarriere?.niveau;
              collab.poste = currentCarriere?.poste;
              return collab;
            }
          );
          if (response.headers.get('Pagination') != null) {
            this.paginatedResult.pagination = JSON.parse(
              response.headers.get('Pagination') || ''
            );
          }
          return this.paginatedResult;
        })
      );
  }
}
