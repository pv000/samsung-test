import { HttpClient } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { User } from "../models/user.model";

@Injectable({
    providedIn: 'root'
})
export class UsersService {
    private httpClient = inject(HttpClient);

    public getUsers(): Observable<User[]> {
        return this.httpClient.get<User[]>('users');
    }
}