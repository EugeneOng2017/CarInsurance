using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsuranceApplication.ViewModel;
using CarInsuranceApplication.Models;

namespace CarInsuranceApplication.Controllers
{
    public class PoliciesController : Controller
    {

        CarInsuranceApplicationContext _context;

        //Constructors
        public PoliciesController()
        {
            _context = new CarInsuranceApplicationContext();
        }

        // GET: Policies
        //public ActionResult Step1()
        //{
        //    List<DrivingExperience> drivingExperiences = 
        //        _context.DrivingExperiences.ToList();

        //    List<string> carMake = 
        //        _context.CarModels.Select(Car => Car.Make).Distinct().ToList();

        //    PolicyFormViewModel viewModel = new PolicyFormViewModel
        //    {
        //        DrivingExperiences = drivingExperiences,
        //        CarMake = carMake
        //    };

        //    return View(viewModel);
        //}

        public ActionResult Step1(PolicyFormViewModel viewModel)
        {
            List<DrivingExperience> drivingExperiences;

            List<string> carMake;

            if (viewModel.Policy == null)
            {
                drivingExperiences = _context.DrivingExperiences.ToList();

                carMake = _context.CarModels.Select(Car => Car.Make).Distinct().ToList();

                PolicyFormViewModel newViewModel = new PolicyFormViewModel
                {
                    DrivingExperiences = drivingExperiences,
                    CarMake = carMake
                };

                return View(newViewModel);
            }

            drivingExperiences = _context.DrivingExperiences.ToList();

            carMake = _context.CarModels.Select(Car => Car.Make).Distinct().ToList();

            viewModel.DrivingExperiences = drivingExperiences;
            viewModel.CarMake = carMake;

            return View(viewModel);
        }

        // GET: Policies
        public ActionResult Step2(PolicyFormViewModel viewModel)
        {
            if (viewModel.Policy == null)
            {
                return RedirectToAction("Step1", "Policies");
            }

            viewModel.BasePrice = _context.CarModels.Where(c => c.Id == viewModel.CarId).Select(Car => Car.BasePrice).Single();
            viewModel.Policy.Model = _context.CarModels.Where(c => c.Id == viewModel.CarId).Select(Car => Car.Model).Single();

            viewModel.Plan1Price = GetPlanAmount(viewModel.BasePrice, viewModel.Policy.Driver.Demerit, 1);
            viewModel.Plan2Price = GetPlanAmount(viewModel.BasePrice, viewModel.Policy.Driver.Demerit, .7);
            viewModel.Plan3Price = GetPlanAmount(viewModel.BasePrice, viewModel.Policy.Driver.Demerit, .5);

            return View(viewModel);
        }

        public ActionResult ApplicationComplete(PolicyFormViewModel viewModel)
        {
            if (viewModel.Policy == null)
            {
                return RedirectToAction("Step1", "Policies");
            }

            double factor;

            if(viewModel.Policy.PlanName == "Plan 1")
            {
                factor = 1;
            }
            else if (viewModel.Policy.PlanName == "Plan 2")
            {
                factor = .7;
            }
            else
            {
                factor = .5;
            }


            viewModel.Policy.Amount = GetPlanAmount(viewModel.BasePrice, viewModel.Policy.Driver.Demerit, factor);

            Driver driver = new Driver
            {
                Name = viewModel.Policy.Driver.Name,
                Gender = viewModel.Policy.Driver.Gender,
                Occupation = viewModel.Policy.Driver.Occupation,
                Birthdate = viewModel.Policy.Driver.Birthdate,
                DrivingExperienceId = viewModel.Policy.Driver.DrivingExperienceId,
                Demerit = viewModel.Policy.Driver.Demerit,
                IsDemeritFree = viewModel.Policy.Driver.IsDemeritFree
            };

            _context.Drivers.Add(driver);
            _context.SaveChanges();

            Policy policy = new Policy
            {
                DriverId = driver.Id,
                Make = viewModel.Policy.Make,
                Model = viewModel.Policy.Model,
                StartDate = viewModel.Policy.StartDate,
                EndDate = viewModel.Policy.EndDate,
                PlanName = viewModel.Policy.PlanName,
                Amount = viewModel.Policy.Amount
            };

            _context.Policies.Add(policy);
            _context.SaveChanges();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult LoadCarModels(string CarMake)
        {
            var carModels = _context.CarModels.Where(c => c.Make == CarMake).ToList();

            if (carModels == null)
                return Json(null);

            return Json(carModels);
        }

        public double GetPlanAmount(double BasePrice, byte? Demerit, double Factor)
        {
            return (double)(BasePrice * ((Demerit != null) ? Demerit / 10.0 : 1) * Factor);
        }
    }
}