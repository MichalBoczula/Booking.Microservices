using Booking.Service.Domain.Entities;

namespace Booking.Service.Domain.Dictionaries
{
    public class PaymentStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookedTerm> BookedTerms { get; set; }
    }
}
