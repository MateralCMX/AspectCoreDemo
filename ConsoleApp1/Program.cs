using AspectCore.Configuration;
using AspectCore.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<IInteriorService, InteriorServiceImpl>();
            services.AddTransient<IExternalService, ExternalServiceImpl>();
            services.ConfigureDynamicProxy(option =>
            {
                option.Interceptors.AddTyped<CustomInterceptor>();
            });
            IServiceProvider serviceProvider = services.BuildDynamicProxyProvider();
            IExternalService service2 = serviceProvider.GetRequiredService<IExternalService>();
            service2.SayHello();
        }
    }
}