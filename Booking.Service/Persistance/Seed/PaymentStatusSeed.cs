using Booking.Service.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Persistance.Seed
{
    public static class PaymentStatusSeed
    {
        public static void CreatePaymentStatus(this ModelBuilder modelBuilder)
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
