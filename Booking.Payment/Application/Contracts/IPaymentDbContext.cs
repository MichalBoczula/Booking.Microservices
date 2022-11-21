using Booking.Payment.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Booking.Payment.Application.Contracts
{
    public interface IPaymentDbContext
    {
        DbSet<Domain.Entities.Payment> Payments { get; set; }
        DbSet<PaymentStatus> PaymentStatuses { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<IDbContextTransaction> BeginTransaction();
        Task CommitTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken);
        Task RollbackTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken);
    }
}
