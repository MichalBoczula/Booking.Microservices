using Booking.Service.Domain.Dictionaries;

namespace Booking.Service.Service.SynchCommunication.PaymentAPI.Contracts
{
    public class AddPaymentResult
    {
        public string OrderIntegrationId { get; set; }
        public int PaymentStatusId { get; set; }
    }
}
