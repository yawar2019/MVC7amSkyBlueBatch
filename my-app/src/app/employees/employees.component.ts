import { Component, OnInit } from '@angular/core';

import { EmployeeService } from '../shared/employee.service';
import { EmployeeShowService } from '../shared/employee-show.service';
@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  constructor(private test:EmployeeShowService) { }

  ngOnInit() {
    this.test.getShowEmployee()
  }

  
}
