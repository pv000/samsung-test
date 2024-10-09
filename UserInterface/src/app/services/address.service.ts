import { HttpClient } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { Address } from "../models/address.model";
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})
export class AddressService {
    private httpClient = inject(HttpClient);

    public getAddressByUserId(userId: number): Observable<Address> {
        return this.httpClient.get<Address>(`address?userId=${userId}`);
    }
}