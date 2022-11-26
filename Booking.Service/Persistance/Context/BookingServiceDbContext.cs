using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics.CodeAnalysis;

using Booking.Service.Application.Contracts;
using Booking.Service.Domain.Dictionaries;
using Booking.Service.Domain.Entities;
using Booking.Service.Persistance.Seed;

namespace Booking.Service.Persistance.Context
{
    public class BookingServiceDbContext : DbContext, IBookingServiceDbContext
    {
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<TermStatus> TermStatuses { get; set; }
        public DbSet<AvailableTerm> AvailableTerms { get; set; }
        public DbSet<BookedTerm> BookedTerms { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public BookingServiceDbContext([NotNull] DbContextOptions<BookingServiceDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.CreateHotel();
            modelBuilder.CreateTermStatus();
            modelBuilder.CreatePaymentStatus();
            modelBuilder.CreateAvailableTerm();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        public async Task<IDbContextTransaction> BeginTransaction()
        {
            return await this.Database.BeginTransactionAsync();
        }

        public async Task CommitTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken)
        {
            await Transaction.CommitAsync(cancellationToken);
        }

        public async Task RollbackTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken)
        {
            await Transaction.RollbackAsync(cancellationToken);
        }
    }
}
