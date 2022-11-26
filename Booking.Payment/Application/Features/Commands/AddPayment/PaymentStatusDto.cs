using AutoMapper;
using Booking.Payment.Application.Mapping;
using Booking.Payment.Domain.Dictionaries;

namespace Booking.Payment.Application.Features.Commands.AddPayment
{
    public class PaymentStatusDto : IMapFrom<PaymentStatus>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PaymentStatus, PaymentStatusDto>();
        }
    }
}
