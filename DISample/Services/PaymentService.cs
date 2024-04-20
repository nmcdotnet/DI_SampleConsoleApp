using DISample.Models;
using DISample.Services.Abstracts;

namespace DISample.Services
{
    public class PaymentService : IPaymentService
    {
        public bool ProccessPayment(PaymentInfo paymentInfo)
        {
            if(paymentInfo.Price > 1000)
            {
                Console.WriteLine("Payment successful!");
                Console.WriteLine("Price: " + paymentInfo.Price);
                Console.WriteLine("Bank name: "+paymentInfo.BankName);
                return true;
            }
            else
            {
                Console.WriteLine("Payment fail!");
                return false;
            }
        }
    }
}
