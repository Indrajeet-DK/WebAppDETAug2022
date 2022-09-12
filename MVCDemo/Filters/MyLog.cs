using Microsoft.AspNetCore.Mvc.Filters;
namespace MVCDemo.Filters
{
    public class MyLog:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext contaxt)
        {
            Console.WriteLine($"- {nameof(MyLog)}.{nameof(OnActionExecuting)}");
            base.OnActionExecuting(contaxt);

        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"- {nameof(MyLog)}.{nameof(OnActionExecuted)}");

            base.OnActionExecuted(context);
        }
    }
}
