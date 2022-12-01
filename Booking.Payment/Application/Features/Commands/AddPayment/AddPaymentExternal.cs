using AutoMapper;
using Booking.Payment.Application.Mapping;

namespace Booking.Payment.Application.Features.Commands.AddPayment
{
    public class AddPaymentExternal : IMapFrom<Booking.Payment.Domain.Entities.Payment>
    {
        public string OrderIntegrationId { get; set; }
        public int Total { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddPaymentExternal, Domain.Entities.Payment>();
        }
    }
}
