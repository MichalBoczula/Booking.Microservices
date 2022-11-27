using AutoMapper;
using Booking.Service.Application.Features.Common;
using Booking.Service.Domain.Entities;
using Booking.Service.Domain.Enums;
using Booking.Service.Persistance.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Application.Features.Commands.ReserveTerm
{
    public class ReserveTermCommandHandler : CommandBase, IRequestHandler<ReserveTermCommand, ReserveTermCommandResult>
    {
        public ReserveTermCommandHandler(BookingServiceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ReserveTermCommandResult> Handle(ReserveTermCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var orderIntegrationId = Guid.NewGuid().ToString();

                var bookedTerm = new BookedTerm()
                {
                    AvailableTermId = request.ReserveTermCommandExternalRef.AvailableTermId,
                    PaymentStatusId = (int)PaymentStatus.Waiting,
                    OrderIntegrationId = orderIntegrationId
                };

                await _context.BookedTerms.AddAsync(bookedTerm);
                var available = await _context.AvailableTerms.FirstOrDefaultAsync(x => x.Id == request.ReserveTermCommandExternalRef.AvailableTermId);

                if (available == null) 
                {
                    throw new KeyNotFoundException(nameof(available));
                }

                available.TermStatusId = (int)Domain.Enums.TermStatus.Reserved;
                _context.AvailableTerms.Update(available);
                await _context.SaveChangesAsync(cancellationToken);

                return new ReserveTermCommandResult()
                {
                    OrderIntegrationId = orderIntegrationId
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
