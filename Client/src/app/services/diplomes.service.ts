import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DiplomesService {
  private DeleteDiplome_URL: string = `${environment.URL}api/Diplomes`;


  constructor(private httpClient: HttpClient) { }

  deleteDiplome(idDiplome: number) {
    return this.httpClient.delete(`${this.DeleteDiplome_URL}/${idDiplome}`);
  }

  updateDiplome() {
    console.log("update diplomes");
  }

  addDiplome() {
    console.log("add diplomes");
  }

  getAllDiplomes() {
    console.log("all diplomes");
  }
}
