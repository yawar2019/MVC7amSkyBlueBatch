using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC7amSkyBlueBatch.Models
{
    public class Employee
    {
        [Display(Name = "Employee Number")]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    public class empDepart {

        public Employee emp { get; set; }
        public Department dept { get; set; }
    }
    public class empDepartList
    {

        public List<Employee> emp { get; set; }
        public List<Department> dept { get; set; }
    }
}