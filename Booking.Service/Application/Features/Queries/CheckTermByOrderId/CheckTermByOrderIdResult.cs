using AutoMapper;
using Booking.Service.Application.Features.Queries.CheckAvailableTerms;
using Booking.Service.Application.Mapping;
using Booking.Service.Domain.Entities;

namespace Booking.Service.Application.Features.Queries.CheckTermByOrderId
{
    public class CheckTermByOrderIdResult : IMapFrom<BookedTerm>
    {
        public string OrderIntegrationId { get; set; }
        public AvailableTermDto AvailableTermRef { get; set; }
        public PaymentStatusDto PaymentStatusRef { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BookedTerm, CheckTermByOrderIdResult>();
        }
    }
}
