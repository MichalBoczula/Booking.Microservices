using MediatR;

namespace Booking.Service.Application.Features.Commands.ReserveTerm
{
    public class ReserveTermCommand : IRequest<ReserveTermCommandResult>
    {
        public ReserveTermCommandExternal ReserveTermCommandExternalRef { get; set; }
    }
}
