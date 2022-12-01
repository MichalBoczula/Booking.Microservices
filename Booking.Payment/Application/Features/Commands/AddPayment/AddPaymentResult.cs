using AutoMapper;
using Booking.Payment.Application.Mapping;
using Booking.Payment.Domain.Dictionaries;

namespace Booking.Payment.Application.Features.Commands.AddPayment
{
    public class AddPaymentResult : IMapFrom<Domain.Entities.Payment>
    {
        public string OrderIntegrationId { get; set; }
        public int PaymentStatusId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Payment, AddPaymentResult>();
        }
    }
}
