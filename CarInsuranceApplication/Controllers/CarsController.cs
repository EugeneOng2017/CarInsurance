using CarInsuranceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceApplication.Controllers
{
    public class CarsController : Controller
    {
        CarInsuranceApplicationContext _context;

        //Constructors
        public CarsController()
        {
            _context = new CarInsuranceApplicationContext();
        }

        // GET: Cars
        [HttpPost]
        public ActionResult LoadCarModels(string CarMake)
        {
            var carModels = _context.CarModels.Where(c => c.Make == CarMake).ToList();

            if (carModels == null)
                return Json(null);

            return Json(carModels);
        }
    }
}