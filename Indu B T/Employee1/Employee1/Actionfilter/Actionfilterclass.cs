using Microsoft.AspNetCore.Mvc.Filters;


namespace Employee1.Actionfilter
{
    public class Actionfilterclass : IActionFilter
    {
        private readonly ILogger<Actionfilterclass> _logger;

        public Actionfilterclass(ILogger<Actionfilterclass> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Action starting: {ActionName}", context.ActionDescriptor.DisplayName);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Action finished: {ActionName}", context.ActionDescriptor.DisplayName);
        }
    }
}
