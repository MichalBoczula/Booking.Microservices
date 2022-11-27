using AutoMapper;
using Booking.Service.Application.Mapping;
using Booking.Service.Domain.Dictionaries;
using Booking.Service.Domain.Entities;

namespace Booking.Service.Application.Features.Queries.CheckTermByOrderId
{
    public class TermStatusDto : IMapFrom<TermStatus>
    {
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TermStatus, TermStatusDto>();
        }
    }
}