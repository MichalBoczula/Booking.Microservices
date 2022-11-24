using Booking.Service.Domain.Dictionaries;

namespace Booking.Service.Domain.Entities
{
    public class AvailableTerm
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int HotelId { get; set; }
        public Hotel HotelRef { get; set; }
        public int TermStatusId { get; set; }
        public TermStatus TermStatusRef { get; set; }
        public BookedTerm? BookedTermRef { get; set; }
    }
}
