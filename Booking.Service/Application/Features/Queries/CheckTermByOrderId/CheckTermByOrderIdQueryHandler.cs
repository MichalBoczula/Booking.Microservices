using AutoMapper;
using AutoMapper.QueryableExtensions;
using Booking.Service.Application.Features.Common;
using Booking.Service.Persistance.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Application.Features.Queries.CheckTermByOrderId
{
    public class CheckTermByOrderIdQueryHandler : QueryBase, IRequestHandler<CheckTermByOrderIdQuery, CheckTermByOrderIdResult>
    {
        public CheckTermByOrderIdQueryHandler(BookingServiceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<CheckTermByOrderIdResult> Handle(CheckTermByOrderIdQuery request, CancellationToken cancellationToken)
        {
            var term = await _context.BookedTerms
                .Include(x => x.PaymentStatusRef)
                .Include(x => x.AvailableTermRef)
                .ThenInclude(x => x.HotelRef)
                .Include(x => x.AvailableTermRef.TermStatusRef)
                .FirstOrDefaultAsync(cancellationToken);

            var result = this._mapper.Map<CheckTermByOrderIdResult>(term);

            return result; 
        }
    }
}
