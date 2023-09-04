using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp
{
    public class AdminAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Get Cookies From User With Our Desired Name
            string checkContext = context.HttpContext.Request.Cookies["user-cookie"];
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
