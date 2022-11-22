using AutoMapper;
using Booking.Payment.Application.Contracts;

namespace Booking.Payment.Application.Features.Common
{
    public class CommandBase
    {
        protected readonly IPaymentDbContext _context;
        protected readonly IMapper _mapper;

        public CommandBase(IPaymentDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
