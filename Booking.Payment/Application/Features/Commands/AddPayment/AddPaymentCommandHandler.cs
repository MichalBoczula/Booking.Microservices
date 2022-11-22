using AutoMapper;
using Booking.Payment.Application.Contracts;
using Booking.Payment.Application.Features.Common;
using MediatR;

namespace Booking.Payment.Application.Features.Commands.AddPayment
{
    public class AddPaymentCommandHandler : CommandBase, IRequestHandler<AddPaymentCommand, AddPaymentResult>
    {
        public AddPaymentCommandHandler(IPaymentDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<AddPaymentResult> Handle(AddPaymentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var payment = _mapper.Map<Booking.Payment.Domain.Entities.Payment>(request.AddPaymentExternal);
                payment = this.ProcessPayment(payment);
                _context.Payments.Add(payment);
                await _context.SaveChangesAsync(cancellationToken);
                var result = _mapper.Map<AddPaymentResult>(payment);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Booking.Payment.Domain.Entities.Payment ProcessPayment(Booking.Payment.Domain.Entities.Payment payment)
        {
            payment.PaymentStatusId = 1;
            return payment;
        }

    }
}
