using DISample.Models;
using DISample.Services;
using DISample.Services.Abstracts;
using Microsoft.Extensions.DependencyInjection;

namespace DISample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ServiceProviderBuilder.BuildServiceProvider();

            var product = serviceProvider.GetRequiredService<IProductService>();    
            var productList = product.GetAllProducts();
            Console.WriteLine("Process Order: ");

            var orderDetail = new Order() { Id = "XSH5588", Quantity = 20 };
            var paymentInfo = new PaymentInfo() { Price = 2000, BankName = "Word Bank" };

            IOrderService? order = serviceProvider.GetService<IOrderService>();
            order?.PlaceOrder(productList, orderDetail, paymentInfo);

            Console.ReadKey();
        }
    }
}
