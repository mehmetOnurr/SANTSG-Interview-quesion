using otelUcusAppProject.DBModel;
using otelUcusAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otelUcusAppProject.Controllers
{
    public class locationController : Controller
    {
        otelucusEntities1 otelucus = new otelucusEntities1();
        // GET: location
        public ActionResult location()
        {
            locationModel location = new locationModel();
            return View(location);
        }

        [HttpPost]
        public ActionResult location(locationModel location)
        {
            if (ModelState.IsValid)
            {

                locations farlocation = new DBModel.locations();

                farlocation.name = location.name;
                otelucus.locations.Add(farlocation);
                otelucus.SaveChanges();
                location = new locationModel();
                location.successMessage = "User is successfully added";
                return View(location);
            }


            return View();
        }
    }
}