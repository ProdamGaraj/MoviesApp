using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MoviesApp.Filters
{
    public class ActorsAgeFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var birthDate = DateTime.Parse(context.HttpContext.Request.Form["BirthDate"]);
            if(Math.Abs(birthDate.Year-DateTime.Now.Year)<7|| Math.Abs(birthDate.Year - DateTime.Now.Year) > 99)
            {
                context.Result = new BadRequestResult();
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
