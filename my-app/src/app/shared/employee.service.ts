import { Injectable } from "@angular/core";
import { Employee } from "./employee.model";
import { HttpClient } from "@angular/common/http";
@Injectable({
  providedIn: "root",
})
export class EmployeeService {
  formData: Employee;
  list: Employee[];
  readonly rootUrl = "http://localhost:57925/api";
  constructor(private http: HttpClient) {}

  postEmployee(formData: Employee) {
    return this.http.post(this.rootUrl + "/employeeDetails", formData);
  }
  refreshList() {
    this.http
      .get(this.rootUrl + "/employeeDetails")
      .toPromise()
      .then((res) => (this.list = res as Employee[]));
  }
  deleteEmployee(id: number) {
    return this.http.delete(this.rootUrl + "/employeeDetails/" + id);
  }
}
