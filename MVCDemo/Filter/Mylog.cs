using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCDemo.Filter
{
    public class Mylog:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"-{nameof(Mylog)}.{nameof(OnActionExecuting)}");
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"-{nameof(Mylog)}.{nameof(OnActionExecuting)}");
            base.OnActionExecuted(context);

        }

    }
}
