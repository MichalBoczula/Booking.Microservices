using MediatR;

namespace Booking.Payment.Application.Features.Commands.AddPayment
{
    public class AddPaymentCommand : IRequest<AddPaymentResult>
    {
        public AddPaymentExternal AddPaymentExternal { get; set; }
    }
}
