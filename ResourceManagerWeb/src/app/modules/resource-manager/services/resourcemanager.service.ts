import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

const localUrl = 'http://localhost:52304/api/resource/fetchdata';
@Injectable({
  providedIn: 'root'
})
export class ResourcemanagerService {

  constructor(private http: HttpClient) { }
  getData() {
    return this.http.get(localUrl);
  }
}
