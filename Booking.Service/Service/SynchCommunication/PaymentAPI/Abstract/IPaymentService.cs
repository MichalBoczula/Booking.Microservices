using Booking.Service.Service.SynchCommunication.PaymentAPI.Contracts;

namespace Booking.Service.Service.SynchCommunication.PaymentAPI.Abstract
{
    public interface IPaymentService
    {
        Task<AddPaymentResult> ProcessPayment(string orderId);
    }
}
