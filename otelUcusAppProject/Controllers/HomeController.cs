using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otelUcusAppProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult userPage()
        {
            return View();
        }

        public ActionResult admin()
        {
            return View();
        }

    }
}