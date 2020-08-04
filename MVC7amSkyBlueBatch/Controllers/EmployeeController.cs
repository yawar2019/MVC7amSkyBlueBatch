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



        public string GetmeData(string id)
        {

            return id + "," + Request.QueryString["Ename"] + "," + Request.QueryString["ESalary"] + "," + Request.QueryString["Department"];
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


        public ActionResult GetDataViewModel()
        {
            empDepart objdept = new Models.empDepart();
            Employee objshrey = new Employee();
            objshrey.EmpId = 1211;
            objshrey.EmpName = "shrey";
            objshrey.EmpSalary = 289000;

            Department dt = new Department();
            dt.DeptId = 1211;
            dt.DeptName = "IT";

            objdept.emp = objshrey;
            objdept.dept = dt;
            //object model=objshrey;
            return View(objdept);//ViewModel

        }
        public ActionResult GetmultipleDataViewModel()
        {
            empDepartList objdept = new Models.empDepartList();

            Employee objshrey = new Employee();
            objshrey.EmpId = 1211;
            objshrey.EmpName = "shrey";
            objshrey.EmpSalary = 289000;

            Employee objprasana = new Employee();
            objprasana.EmpId = 1212;
            objprasana.EmpName = "prasana";
            objprasana.EmpSalary = 389000;

            Department dt = new Department();
            dt.DeptId = 1211;
            dt.DeptName = "IT";

            Department dt1 = new Department();
            dt1.DeptId = 1212;
            dt1.DeptName = "Network";

            List<Employee> listempobj = new List<Employee>();
            List<Department> listdepobj = new List<Department>();

            listempobj.Add(objshrey);
            listempobj.Add(objprasana);


            listdepobj.Add(dt);
            listdepobj.Add(dt1);

            objdept.emp = listempobj;
            objdept.dept = listdepobj;
            //object model=objshrey;
            return View(objdept);//ViewModel

        }

        public ViewResult getmyViewExample()
        {
            return View("~/Views/Default/Index.cshtml");
        }

        public ViewResult getmyViewExample1()
        {
            Employee objshrey = new Employee();
            objshrey.EmpId = 1211;
            objshrey.EmpName = "shrey";
            objshrey.EmpSalary = 289000;

            return View("~/Views/Default/Index.cshtml", objshrey);
        }

        //A view whcih can be called inside another View is called as partial view

        public PartialViewResult getPartialView()
        {
            Employee objshrey = new Employee();
            objshrey.EmpId = 1211;
            objshrey.EmpName = "shrey";
            objshrey.EmpSalary = 289000;

            return PartialView("_MyPartialView", objshrey);
        }

        public RedirectResult gotourl()
        {
            return Redirect("http://www.facebook.com");
        }
        public RedirectResult gotoMvcurl()
        {
            return Redirect("~/Employee/getPartialView");
        }

        public RedirectToRouteResult RedirectMyRoute()
        {
            return RedirectToRoute("spiderman");
        }
        public RedirectToRouteResult RedirectToMethod()
        {
            Employee objshrey = new Employee();
            objshrey.EmpId = 1211;
            objshrey.EmpName = "shrey";
            objshrey.EmpSalary = 289000;

            return RedirectToAction("Index3", "Default", objshrey);//new {id=1 },objshrey
        }
        public FileResult getMeFile()
        {
            return File("~/Web.config", "text");
        }
        public FileResult getMeFile2()
        {
            return File("~/Web.config", "application/xml");
        }
        public FileResult downloadMeFile2()
        {
            return File("~/Web.config", "application/xml", "myfile");
        }
        public ContentResult getContent(int? id)
        {
            if (id == 1)
            {
                return Content("Hello World");
            }
            else if (id == 2)
            {
                return Content("<p style=color:red>Hello World</p>");

            }
            else
            {
                return Content("<script>alert('Hello world')</script>");
            }
        }
        public JsonResult getjsonData()
        {
            Employee objshrey = new Employee();
            objshrey.EmpId = 1211;
            objshrey.EmpName = "shrey";
            objshrey.EmpSalary = 289000;

            return Json(objshrey, JsonRequestBehavior.AllowGet);
        }
    }
}