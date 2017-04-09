using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsuranceApplication.Models
{
    public class Policy
    {
        public int Id { get; set; }

        [Required]
        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Coverage Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "Coverage End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        public string PlanName { get; set; }

        [Required]
        public double Amount { get; set; }
    }
}