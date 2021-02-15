import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
  })

export class GeographicDataService {

    private readonly rootURL: string = 'https://localhost:44330/api/geographiccoordinates/';

    constructor(private http: HttpClient) { }

    public requestHeaderContentType = new HttpHeaders({
        'Content-Type': 'application/x-www-form-urlencoded',
        'Access-Control-Allow-Origin': '*',
        'Access-Control-Allow-Methods': '*',
        'Access-Control-Allow-Headers': 'Access-Control-Allow-Headers: Origin, Content-Type, X-Auth-Token',
      });

    getData() : Observable<object> {
        return this.http.get(this.rootURL + 'all', { headers: this.requestHeaderContentType });
    }
}