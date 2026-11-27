import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export  class StudentService{
    constructor(private http:HttpClient){

    }
    getStudents():any{
        return this.http.get("http://localhost:6050/api/Student");
    }
}