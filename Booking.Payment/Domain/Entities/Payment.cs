using Booking.Payment.Domain.Dictionaries;

namespace Booking.Payment.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public string OrderIntegrationId { get; set; }
        public int Total { get; set; }
        public int PaymentStatusId { get; set; }
        public PaymentStatus? PaymentStatusRef { get; set; }
    }
}
