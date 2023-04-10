using Microsoft.AspNetCore.Mvc.Filters;

namespace Employee1.Interface
{
    public interface IActionfilter
    {
        void OnActionExecuting(ActionExecutingContext context);
        void OnActionExecuted(ActionExecutedContext context);

    }
}
