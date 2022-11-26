using AutoMapper;
using Booking.Service.Application.Mapping;
using Booking.Service.Domain.Dictionaries;
using Booking.Service.Domain.Entities;

namespace Booking.Service.Application.Features.Queries.CheckAvailableTerms
{
    public class AvailableTermDto : IMapFrom<AvailableTerm>
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AvailableTerm, AvailableTermDto>();
        }
    }
}