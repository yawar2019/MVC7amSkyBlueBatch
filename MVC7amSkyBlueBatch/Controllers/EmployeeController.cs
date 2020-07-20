using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC7amSkyBlueBatch.Models;

namespace MVC7amSkyBlueBatch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string GetName()
        {
            return "Hello Manavi";
        }

        public int GetLuckyNumber()
        {
            return 1;
        }

        public ActionResult GetData()
        {
            return View();
        }



        public string GetmeData(string id) {
        
            return id+","+Request.QueryString["Ename"]+","+Request.QueryString["ESalary"] + "," + Request.QueryString["Department"];
        }
        public ActionResult GetmeView()
        {
            return View("GetmeView1211");
        }

        public ActionResult sendData()
        {
           

            List<Employee> listobj = new List<Employee>();

            Employee objshrey = new Employee();
            objshrey.EmpId = 1211;
            objshrey.EmpName = "shrey";
            objshrey.EmpSalary = 289000;

            Employee objmanavi = new Employee();
            objmanavi.EmpId = 1212;
            objmanavi.EmpName = "Manavi";
            objmanavi.EmpSalary = 389000;

            Employee objPrasana = new Employee();
            objPrasana.EmpId = 1213;
            objPrasana.EmpName = "Prasana";
            objPrasana.EmpSalary = 489000;

            listobj.Add(objshrey);
            listobj.Add(objmanavi);
            listobj.Add(objPrasana);


            ViewBag.Empdetail = listobj;


             
            return View();
        }

    }
}