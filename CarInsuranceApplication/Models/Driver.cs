using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsuranceApplication.Models
{
    public class Driver
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters and numbers are not allowed.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters and numbers are not allowed.")]
        [StringLength(255)]
        public string Occupation { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        
        public DrivingExperience DrivingExperience { get; set; }

        [Required]
        [Display(Name = "Driving Experience in Years")]
        public int DrivingExperienceId { get; set; }

        public bool IsDemeritFree { get; set; }

        [Range(1, 24)]
        public byte? Demerit { get; set; }
    }
}