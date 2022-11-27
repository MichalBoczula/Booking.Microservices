using MediatR;

namespace Booking.Service.Application.Features.Queries.CheckTermByOrderId
{
    public class CheckTermByOrderIdQuery : IRequest<CheckTermByOrderIdResult>
    {
        public CheckTermByIdExternal CheckTermById { get; set; }
    }
}
