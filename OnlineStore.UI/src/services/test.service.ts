import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Test } from "../models/test";
import { Injectable } from "@angular/core";

@Injectable({ providedIn : "root"})
export class TestService{
    constructor(private client: HttpClient) {}

    getAll() : Observable<Test[]> {
        return this.client.get<Test[]>("/api/test")
    }

    add(testData : Test) : Observable<any> {
        return this.client.post("/api/test", testData);
    }
}