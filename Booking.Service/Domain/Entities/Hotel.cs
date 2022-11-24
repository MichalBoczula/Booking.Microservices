namespace Booking.Service.Domain.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<AvailableTerm> AvailableTerms { get; set; }
    }
}
