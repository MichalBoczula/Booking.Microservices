using Booking.Service.Domain.Dictionaries;
using Booking.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Persistance.Seed
{
    public static class TermStatusSeed
    {
        public static void CreateTermStatus(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TermStatus>()
                .HasData(new TermStatus()
                {
                    Id = 1,
                    Name = "Booked"
                });

            modelBuilder.Entity<TermStatus>()
                .HasData(new TermStatus()
                {
                    Id = 2,
                    Name = "Free"
                });

            modelBuilder.Entity<TermStatus>()
                .HasData(new TermStatus()
                {
                    Id = 3,
                    Name = "Reserved"
                });
        }
    }
}
