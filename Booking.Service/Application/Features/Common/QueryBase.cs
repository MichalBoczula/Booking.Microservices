using AutoMapper;
using Booking.Service.Application.Contracts;
using Booking.Service.Persistance.Context;

namespace Booking.Service.Application.Features.Common
{
    public class QueryBase
    {
        protected readonly IBookingServiceDbContext _context;
        protected readonly IMapper _mapper;

        public QueryBase(BookingServiceDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
