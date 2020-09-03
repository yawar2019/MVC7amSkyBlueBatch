import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
 
export class EmployeeComponent implements OnInit {

 

  ngOnInit() {
    this.resetForm();
  }
  constructor(private service:EmployeeService,private toastr:ToastrService){}

  resetForm(form?:NgForm){
    if(form!=null)
    form.resetForm();
    
    this.service.formData={
      EmpId:0,
      EmpName:'',
      EmpSalary:null
       
      
    }
  }
onSubmit(form:NgForm)
{
this.InsertRecord(form);
}
InsertRecord(form:NgForm){
this.service.postEmployee(form.value).subscribe(res=>{
  this.toastr.success('Inserted Record Successfully','Emp Register');
  this.resetForm(form)
});
}
}
