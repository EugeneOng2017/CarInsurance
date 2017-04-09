using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarInsuranceApplication.Models
{
    public class CarInsuranceApplicationContext : DbContext
    {
        public DbSet<DrivingExperience> DrivingExperiences { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<PlanPriceFactor> PlanPriceFactors { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Policy> Policies { get; set; }


        public CarInsuranceApplicationContext()
            :base("name=DefaultConnection")
        {

        }
    }
}