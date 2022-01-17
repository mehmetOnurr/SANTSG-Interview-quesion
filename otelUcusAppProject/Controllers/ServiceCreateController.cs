using otelUcusAppProject.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using otelUcusAppProject.Models;

namespace otelUcusAppProject.Controllers
{
    public class ServiceCreateController : Controller
    {

        otelucusEntities1 otelucus = new otelucusEntities1();
        // GET: ServiceCreate
        public ActionResult servicesCreate()
        {
            List<locations> locationList = otelucus.locations.ToList();
            ViewBag.code = new SelectList(locationList,"code","name");

            ViewData["code"] = new SelectList(locationList, "code", "name");

            servicesModel services = new servicesModel();
            return View(services);
        }

        [HttpPost]
        public ActionResult servicesCreate(servicesModel services,string code,string codeAr)
        {
            if (ModelState.IsValid)
            {
                List<locations> locationList = otelucus.locations.ToList();
                ViewBag.code = new SelectList(locationList, "code", "name");
                var firstlocation = Convert.ToInt16(code);
                ViewData["code"] = new SelectList(locationList, "code", "name");
                
                var resultA = string.Compare(services.services_type.ToString(),"Hotel");
                if (resultA == 0) 
                { 
                    hotels hotel = new DBModel.hotels();
                    hotel.name = services.services_name;

                    //hotel.location = otelucus.locations.First(model => model.name.Equals(services.location)).code;
                    //hotel.location = services.location;
                    hotel.location = firstlocation;
                    hotel.capacity = services.capacity;
                    hotel.priceperadult = ((decimal)services.pricePerAdult);
                    hotel.priceperchild = ((decimal)services.pricePerChild);

                    otelucus.hotels.Add(hotel);
                    otelucus.SaveChanges();
                    services = new servicesModel();
                    services.successMessage = "User is successfully added";
                    return View(services);
                }
                else
                {
                    var secondlocation = Convert.ToInt16(codeAr);
                    flights flight = new DBModel.flights();
                    flight.code = services.services_name;
                    //flight.departure = otelucus.locations.First(model => model.name.Equals(services.location)).code;
                    //flight.arrival = otelucus.locations.First(model => model.name.Equals(services.location)).code;
                    //flight.departure = services.location;
                    //flight.arrival = services.location;
                    flight.departure = firstlocation;
                    flight.arrival = secondlocation;
                    flight.priceperadult = ((decimal)services.pricePerAdult);
                    flight.priceperchild = ((decimal)services.pricePerChild);
                    otelucus.flights.Add(flight);
                    otelucus.SaveChanges();
                    services = new servicesModel();
                    services.successMessage = "User is successfully added";
                    return View(services);
                }
              
            }



           

            return View();
        }
    }
}