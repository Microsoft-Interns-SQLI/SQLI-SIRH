import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class CollaboratorsService {
    readonly myUrl: string = 'assets/mock_data.json';

    constructor(private http: HttpClient) {}

    getCollaboratorsList(): Observable<any[]> {
        return this.http.get<any>(this.myUrl, {responseType: 'json'});
    }
}