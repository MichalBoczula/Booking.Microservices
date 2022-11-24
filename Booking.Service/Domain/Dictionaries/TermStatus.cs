using Booking.Service.Domain.Entities;

namespace Booking.Service.Domain.Dictionaries
{
    public class TermStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AvailableTerm> AvailableTerms { get; set; }
    }
}
