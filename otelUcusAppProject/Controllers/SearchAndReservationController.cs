using otelUcusAppProject.DBModel;
using otelUcusAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otelUcusAppProject.Controllers
{
    public class SearchAndReservationController : Controller
    {
        otelucusEntities1 otelucus = new otelucusEntities1();
        // GET: SearchAndReservation
        public ActionResult searchHotelFlight()
        {
            List<locations> locationList = otelucus.locations.ToList();
            ViewBag.code = new SelectList(locationList, "code", "name");

            ViewData["code"] = new SelectList(locationList, "code", "name");

            hfsearch hfsearch = new hfsearch();
            return View(hfsearch);
        }

        [HttpPost]
        public ActionResult searchHotelFlight(hfsearch search, string code, string codeAr)
        {
            if (ModelState.IsValid)
            {
                List<locations> locationList = otelucus.locations.ToList();
                ViewBag.code = new SelectList(locationList, "code", "name");
                var firstlocation = Convert.ToInt16(code);
                ViewData["code"] = new SelectList(locationList, "code", "name");

                var resultA = string.Compare(search.services_type.ToString(), "Hotel");
                if (resultA == 0)
                {
                    hotels hotel = new DBModel.hotels();


                    var hotelname = otelucus.locations.First(model => model.code.Equals(firstlocation)).name;
                    List<locations> locationChoocen = (List<locations>)otelucus.locations.Where(m => m.name.Equals(hotelname) );





                    return View("searchlist",locationChoocen);
                }
                else
                {
                    var secondlocation = Convert.ToInt16(codeAr);
                  
                    return View("searchlistFlight",search);
                }

            }





            return View();
        }

        [HttpGet]
        public ActionResult searchlist(locations location)
        {
            
            return View(location);
        }

        [HttpGet]
        public ActionResult searchlistFlight(locations location)
        {
            
            return View(location);
        }

    }
}