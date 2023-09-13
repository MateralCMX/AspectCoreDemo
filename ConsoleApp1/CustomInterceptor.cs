using AspectCore.DynamicProxy;

namespace ConsoleApp1
{
    public class CustomInterceptor : AbstractInterceptor
    {
        public override async Task Invoke(AspectContext context, AspectDelegate next) => await context.Invoke(next);
    }
    //public class CustomInterceptorAttribute : AbstractInterceptorAttribute
    //{
    //    public override async Task Invoke(AspectContext context, AspectDelegate next) => await context.Invoke(next);
    //}
}