using Microsoft.Extensions.DependencyInjection;

namespace DITTestCs
{
    internal class ServiceProviderBuilder
    {
        public static IServiceProvider BuildServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IGreetingService, GreetingService>();

            return services.BuildServiceProvider();
        }
    }
}
