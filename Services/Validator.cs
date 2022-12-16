using ECommerce.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Services
{
    public class Validator<T> : IValidate<T>
    {
        public T? Validate(T value)
        {
            var context = new ValidationContext(value);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(value, context, results, true))
            {
                return default(T);
            }

            return value;

                
        }
    }
}
