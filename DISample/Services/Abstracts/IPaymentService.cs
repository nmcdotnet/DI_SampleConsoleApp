using DISample.Models;

namespace DISample.Services.Abstracts
{
    public interface IPaymentService
    {
        bool ProccessPayment(PaymentInfo paymentInfo);
    }
}
