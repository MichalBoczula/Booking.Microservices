using Booking.Payment.Domain.Dictionaries;

namespace Booking.Payment.Application.Features.Commands.AddPayment
{
    public class AddPaymentResult
    {
        public string OrderIntegrationId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

    }
}
