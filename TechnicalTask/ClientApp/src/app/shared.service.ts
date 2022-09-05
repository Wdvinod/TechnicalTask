import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
@Injectable({
    providedIn: 'root'
})

export class SharedService {
    baseUrl = "https://localhost:44338";
    constructor(private http: HttpClient) { }
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    }
    getFinanceRates() {
        return this.http.get(this.baseUrl + '/api/Finance/Finances');
    }
    getFinanceTypes() {
        return this.http.get(this.baseUrl + '/api/FinanceRateType/FinanceRateTypes');
    }
}