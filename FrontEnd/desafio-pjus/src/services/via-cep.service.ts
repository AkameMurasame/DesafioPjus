import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";

@Injectable()
export class ViaCepService {
    constructor(private http: HttpClient) { }

    public get<Cep>(cep: String): Observable<Cep> {
        return this.http.get<Cep>(`${environment.ApiEndpoint}/consulta/${cep}`);
    }
}
