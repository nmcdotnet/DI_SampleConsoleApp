using DISample.Models;

namespace DISample.Services.Abstracts
{
    public interface IOrderService
    {
        void PlaceOrder(List<Product> products, Order order, PaymentInfo paymentInfo);
    }
}
