using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testRegister.ServiceReference1;
namespace testRegister.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ServiceReference1.Service2Client obj = new ServiceReference1.Service2Client();
           var c= obj.Add(12, 15);
            return Content(c.ToString());
        }
    }
}