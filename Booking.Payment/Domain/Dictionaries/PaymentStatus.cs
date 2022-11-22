using Booking.Payment.Domain.Entities;

namespace Booking.Payment.Domain.Dictionaries
{
    public class PaymentStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Domain.Entities.Payment> Payments { get; set; }
    }
}
