using DISample.Services.Abstracts;
using Microsoft.Extensions.DependencyInjection;

namespace DISample.Services
{
    public class ServiceProviderBuilder
    {
        public static IServiceProvider BuildServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IPaymentService, PaymentService>();
            services.AddSingleton<IOrderService, OrderService>();   

            return services.BuildServiceProvider();
        }
    }
}
