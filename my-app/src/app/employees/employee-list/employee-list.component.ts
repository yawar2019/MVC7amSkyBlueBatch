import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { Employee } from 'src/app/shared/employee.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  constructor(private service:EmployeeService,private toastr:ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }


populateForm(emp:Employee){
  
this.service.formData=emp ;
} 

OnDelete(id:number){
if(confirm('Are You Sure to Delete this Record?')){
this.service.deleteEmployee(id).subscribe(res=>{
this.service.refreshList();
this.toastr.success('Deleted Record Successfully','Emp Register');
});
}
}}

