using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceExample.ServiceReference1;
namespace WebServiceExample.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ServiceReference1.WebService1SoapClient obj = new WebService1SoapClient();
            ViewBag.Add= obj.Add(10, 20);

            return View();
        }
    }
}