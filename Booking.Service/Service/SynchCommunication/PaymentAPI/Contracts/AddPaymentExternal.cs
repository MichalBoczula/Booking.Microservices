using Booking.Service.Domain.Enums;

namespace Booking.Service.Service.SynchCommunication.PaymentAPI.Contracts
{
    public class AddPaymentExternal
    {
        public string OrderIntegrationId { get; set; }
        public int Total { get; set; }
    }
}
