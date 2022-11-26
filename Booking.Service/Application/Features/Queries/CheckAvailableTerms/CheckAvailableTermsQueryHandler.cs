using AutoMapper;
using Booking.Service.Application.Features.Common;
using Booking.Service.Persistance.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Application.Features.Queries.CheckAvailableTerms
{
    public class CheckAvailableTermsQueryHandler : QueryBase, IRequestHandler<CheckAvailableTermsQuery, CheckAvailableTermsQueryResult>
    {
        public CheckAvailableTermsQueryHandler(BookingServiceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<CheckAvailableTermsQueryResult> Handle(CheckAvailableTermsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var terms = await _context.Hotels.Include(x => x.AvailableTerms).ToListAsync();
                var result = _mapper.Map<List<HotelDto>>(terms);
                return new CheckAvailableTermsQueryResult
                {
                    Hotels = result
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
