using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Validations
{
    public class FirstLetterAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var firstLetter = value.ToString()[0].ToString();
            if (firstLetter != firstLetter.ToUpper())
            {
                return new ValidationResult("A primeira letra do produto deve ser maiúscula!");
            }
            return base.IsValid(value, validationContext);
        }
    }
}
