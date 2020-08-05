using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adonet.Models;
namespace Adonet.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeDetail db = new EmployeeDetail();
        public ActionResult Index()
        {
            return View(db.getEmployeee());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel obj)
        {
            int i = db.SaveEmployeee(obj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
           EmployeeModel empobj= db.GetEmployeeById(id);
            return View(empobj);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel obj)
        {
            int i = db.UpdateEmployeee(obj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel empobj = db.GetEmployeeById(id);
            return View(empobj);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
    }
}