import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const headerOption = {
  headers: new HttpHeaders({
    'Content-Type': 'Application/json'
  })
}

@Injectable()
export class BlogReportService {
  baseUrl: string = "http://localhost:60496/api/blogReport";
  constructor(private _httpClient: HttpClient) {
  }
  get(data: any): Observable<any[]> {
    return this._httpClient.post<any[]>(this.baseUrl, data, headerOption);
  }
}
