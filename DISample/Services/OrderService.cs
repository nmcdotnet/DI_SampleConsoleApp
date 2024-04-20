using DISample.Models;
using DISample.Services.Abstracts;

namespace DISample.Services
{
    public class OrderService : IOrderService
    {
          
        private readonly IProductService _productService;
        private readonly IPaymentService _paymentService;

        public OrderService(IProductService productService, IPaymentService paymentService)
        {
            _productService = productService;
            _paymentService = paymentService;
        }

        public void PlaceOrder(List<Product> products, Order order, PaymentInfo paymentInfo)
        {
            bool isPaid = _paymentService.ProccessPayment(paymentInfo);
            if (isPaid)
            {
                Console.WriteLine($"Product List ({_productService.GetProductCount()}): ");
                foreach (Product product in products)
                {
                    Console.WriteLine(product.ID +"-"+ product.Name);
                }
                Console.WriteLine("Order ID: " + order.Id);
                Console.WriteLine("Order Qty: " + order.Quantity);
            }
            else
            {
                Console.WriteLine("Order fail!");
            }
        }
    }
}
