using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Models;

namespace MoviesApp.Filters
{
    public class ActorsNameAtribute : ValidationAttribute
    {
        public ActorsNameAtribute()
        {
        }
        public string GetErrorMesage() => "Actors first name and last name must be longer then 4 simbols";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString().Length < 4)
            {
                return new ValidationResult(GetErrorMesage());
            }
            return ValidationResult.Success;
        }
    }
}
