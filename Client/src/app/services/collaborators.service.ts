import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Collaborator } from '../Models/Collaborator';

@Injectable({
    providedIn: 'root'
})
export class CollaboratorsService {
    readonly myUrl: string = "https://sqli-sirh-backend.herokuapp.com/api/Collaborateurs";
    url:string = environment.URL;
    constructor(private http: HttpClient) {}

    getCollaboratorsList(limit: number, page: number): Observable<any> {
        return this.http.get<any>(this.url + `?Page=${page}&Limit=${limit}`);
    }

    getCollaboratorByMatricule(id:number|string): Observable<Collaborator> {
        return this.http.get<any>(this.url + "/" + id, {responseType: 'json'});
    }

    addCollaborator(collabToAdd: any) {
        return this.http.post(this.url, collabToAdd);
    }

    updateCollaborator(id: number|string, data: any) {
        return this.http.put(this.url + `/${id}`, data);
    }

    deleteCollaborator(id: number|string) {
        return this.http.delete(this.url + `/${id}`);
    }

    importCollaborateurs(file:FormData){
        return this.http.post<FormData>(this.url+"api/Collaborateurs/import", file,
            {reportProgress: true, observe:'events'})
    }
}