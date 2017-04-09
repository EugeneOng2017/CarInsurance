using CarInsuranceApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsuranceApplication.Models
{
    public class Min18Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var driver = (Driver)validationContext.ObjectInstance;

            var BirthdatePlus18 = driver.Birthdate.AddYears(18);

            return (BirthdatePlus18 >= DateTime.Now.Date)
                ? new ValidationResult("Should be at least 18 years old to apply.")
                : ValidationResult.Success;
        }
    }
}