using AutoMapper;
using Booking.Service.Application.Features.Common;
using Booking.Service.Domain.Enums;
using Booking.Service.Persistance.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Application.Features.Commands.AcceptTerm
{
    public class AcceptTermCommandHandler : CommandBase, IRequestHandler<AcceptTermCommand, AcceptTermResult>
    {
        public AcceptTermCommandHandler(BookingServiceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<AcceptTermResult> Handle(AcceptTermCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var bookedterm = this._context.BookedTerms
                .Include(x => x.AvailableTermRef)
                .FirstOrDefault(x => x.OrderIntegrationId == request.AcceptTermExternal.OrderId);

                if (bookedterm == null)
                {
                    throw new KeyNotFoundException(nameof(bookedterm));
                }

                bookedterm.PaymentStatusId = (int)PaymentStatus.Accepted;
                bookedterm.AvailableTermRef.TermStatusId = (int)TermStatus.Booked;

                _context.BookedTerms.Update(bookedterm);
                _context.AvailableTerms.Update(bookedterm.AvailableTermRef);

                await _context.SaveChangesAsync(cancellationToken);

                var result = this._mapper.Map<AcceptTermResult>(bookedterm);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
