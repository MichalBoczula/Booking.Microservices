using Booking.Service.Domain.Dictionaries;
using Booking.Service.Domain.Entities;
using Booking.Service.Persistance.Context;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Booking.Service.Application.Contracts
{
    public interface IBookingServiceDbContext
    {
        DbSet<PaymentStatus> PaymentStatuses { get; set; }
        DbSet<TermStatus> TermStatuses { get; set; }
        DbSet<AvailableTerm> AvailableTerms { get; set; }
        DbSet<BookedTerm> BookedTerms { get; set; }
        DbSet<Hotel> Hotels { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<IDbContextTransaction> BeginTransaction();
        Task CommitTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken);
        Task RollbackTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken);

    }
}
