using AutoMapper;
using Booking.Service.Application.Mapping;
using Booking.Service.Domain.Entities;

namespace Booking.Service.Application.Features.Queries.CheckTermByOrderId
{
    public class AvailableTermDto : IMapFrom<AvailableTerm>
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int HotelId { get; set; }
        public HotelDto HotelRef { get; set; }
        public TermStatusDto TermStatusRef { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AvailableTerm, AvailableTermDto>();
        }
    }
}
