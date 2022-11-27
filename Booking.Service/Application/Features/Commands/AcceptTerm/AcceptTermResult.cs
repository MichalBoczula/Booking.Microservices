using AutoMapper;
using Booking.Service.Application.Mapping;
using Booking.Service.Domain.Entities;
using Booking.Service.Domain.Enums;

namespace Booking.Service.Application.Features.Commands.AcceptTerm
{
    public class AcceptTermResult : IMapFrom<BookedTerm>
    {
        public string OrderIntegrationId { get; set; }
        public string PaymentStatus { get; set; }
        public string TermStatus { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<BookedTerm, AcceptTermResult>()
                .ForMember(x => x.PaymentStatus, opt => opt.MapFrom(x => (PaymentStatus) x.PaymentStatusId))
                .ForMember(x => x.TermStatus, opt => opt.MapFrom(x => (TermStatus) x.AvailableTermRef.TermStatusId));
        }
    }
}
