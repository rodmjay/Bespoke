using System.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Bespoke.Rest.Filters;

public class ValidateModelAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var model = context.ActionArguments.Values.FirstOrDefault();

        if (model == null)
        {
            context.Result = new BadRequestObjectResult(new { Errors = "Request body cannot be null" });
            return;
        }

        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(model, null, null);

        // Validate the object and its nested objects recursively
        ValidateObject(model, validationResults);

        if (validationResults.Any())
        {
            var errors = validationResults.Select(vr => new
            {
                Field = string.Join(".", vr.MemberNames),
                Message = vr.ErrorMessage
            });

            context.Result = new BadRequestObjectResult(new { Errors = errors });
        }
    }

    private void ValidateObject(object obj, List<ValidationResult> validationResults)
    {
        if (obj == null) return;

        var context = new ValidationContext(obj, null, null);
        Validator.TryValidateObject(obj, context, validationResults, true);

        // Check nested properties
        var properties = obj.GetType().GetProperties()
            .Where(p => typeof(IValidatableObject).IsAssignableFrom(p.PropertyType) ||
                        (p.PropertyType.IsGenericType &&
                         typeof(IEnumerable).IsAssignableFrom(p.PropertyType)));

        foreach (var property in properties)
        {
            var value = property.GetValue(obj);

            if (value is IEnumerable enumerable)
                foreach (var item in enumerable)
                    ValidateObject(item, validationResults);
            else if (value is IValidatableObject validatableObject)
                Validator.TryValidateObject(validatableObject, new ValidationContext(validatableObject),
                    validationResults, true);
        }
    }
}