using AutoMapper;
using Booking.Service.Application.Mapping;
using Booking.Service.Domain.Entities;

namespace Booking.Service.Application.Features.Queries.CheckAvailableTerms
{
    public class HotelDto : IMapFrom<Hotel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AvailableTermDto> AvailableTerms { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Hotel, HotelDto>();
        }
    }
}