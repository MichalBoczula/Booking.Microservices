namespace Booking.Payment.Application.Features.Commands.AddPayment
{
    public class AddPaymentExternal
    {
        public string OrderIntegrationId { get; set; }
        public int Total { get; set; }
    }
}
