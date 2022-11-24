using Booking.Service.Domain.Dictionaries;

namespace Booking.Service.Domain.Entities
{
    public class BookedTerm
    {
        public int Id { get; set; }
        public int AvailableTermId { get; set; }
        public AvailableTerm AvailableTermRef { get; set; }
        public int PaymentStatusId;
        public PaymentStatus PaymentStatusRef;
    }
}
