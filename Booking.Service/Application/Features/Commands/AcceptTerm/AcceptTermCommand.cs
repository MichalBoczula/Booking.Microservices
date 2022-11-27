using MediatR;

namespace Booking.Service.Application.Features.Commands.AcceptTerm
{
    public class AcceptTermCommand : IRequest<AcceptTermResult>
    {
        public AcceptTermExternal AcceptTermExternal { get; set; }
    }
}
