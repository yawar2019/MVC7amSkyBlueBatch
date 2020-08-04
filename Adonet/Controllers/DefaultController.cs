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

        []
    }
}