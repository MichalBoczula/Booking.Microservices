using AutoMapper;
using Booking.Service.Application.Contracts;
using Booking.Service.Persistance.Context;

namespace Booking.Service.Application.Features.Common
{
    public class CommandBase
    {
        protected readonly IBookingServiceDbContext _context;
        protected readonly IMapper _mapper;

        public CommandBase(BookingServiceDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
