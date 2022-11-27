using AutoMapper;
using Booking.Service.Application.Mapping;
using Booking.Service.Domain.Entities;

namespace Booking.Service.Application.Features.Queries.CheckTermByOrderId
{
    public class HotelDto : IMapFrom<Hotel>
    {
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Hotel, HotelDto>();
        }
    }
}