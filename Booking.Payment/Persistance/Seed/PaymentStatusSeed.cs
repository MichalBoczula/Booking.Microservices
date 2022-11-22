using Booking.Payment.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace Booking.Payment.Persistance.Seed
{
    public static class PaymentStatusSeed
    {
        public static void CreatePaymentStatusSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentStatus>()
                .HasData(new PaymentStatus
                {
                    Id = 1,
                    Name = "Accepted",
                });

            modelBuilder.Entity<PaymentStatus>()
                .HasData(new PaymentStatus
                {
                    Id = 2,
                    Name = "Declined",
                });
        }
    }
}
