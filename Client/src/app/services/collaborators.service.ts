import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Collaborator } from '../Models/Collaborator';

@Injectable({
    providedIn: 'root'
})
export class CollaboratorsService {
    readonly myUrl: string = "https://localhost:7019/api/Collaborateurs";

    constructor(private http: HttpClient) {}

    getCollaboratorsList(): Observable<any> {
        return this.http.get<any>(this.myUrl, {responseType: 'json'});
    }

    getCollaboratorByMatricule(id:number|string): Observable<Collaborator> {
        return this.http.get<any>(this.myUrl + "/"+ id, {responseType: 'json'});
    }

    addCollaborator(collabToAdd: any) {
        return this.http.post(this.myUrl, collabToAdd);
    }

    updateCollaborator(id: number|string, data: any) {
        return this.http.put(this.myUrl + `${id}`, data);
    }

    deleteCollaborator(id: number|string) {
        return this.http.delete(this.myUrl + `${id}`);
    }
}