using MVC7amSkyBlueBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amSkyBlueBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult Index3(Employee objshrey)
        {
            ViewBag.Empinfo = objshrey;
            return View();
        }
    }
}