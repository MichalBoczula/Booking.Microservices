using Booking.Payment.Application.Contracts;
using Booking.Payment.Domain.Dictionaries;
using Booking.Payment.Persistance.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics.CodeAnalysis;

namespace Booking.Payment.Persistance.Context
{
    public class PaymentDbContext : DbContext, IPaymentDbContext
    {
        public DbSet<Domain.Entities.Payment> Payments { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }

        public PaymentDbContext([NotNull] DbContextOptions<PaymentDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.CreatePaymentStatusSeed();
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
