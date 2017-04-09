using CarInsuranceApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsuranceApplication.ViewModel
{
    public class PolicyFormViewModel
    {
        public Policy Policy { get; set; }

        public List<DrivingExperience> DrivingExperiences { get; set; }

        [Required]
        public List<string> CarMake { get; set; }

        [Required]
        public List<CarModel> CarModels { get; set; }


        public DateTime? ReadOnlyEndDate { get; set; }

        public int CarId { get; set; }

        [Required]
        public double BasePrice { get; set; }

        public double Plan1Price { get; set; }

        public double Plan2Price { get; set; }

        public double Plan3Price { get; set; }

    }
}