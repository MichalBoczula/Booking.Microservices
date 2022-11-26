using Booking.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Persistance.Seed
{
    public static class AvailableTermSeed
    {
        public static void CreateAvailableTerm(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableTerm>()
                .HasData(new AvailableTerm
                {
                    Id = 1,
                    HotelId = 1,
                    TermStatusId = 1,
                    Month= 1,
                    Year= 2023,
                });

            modelBuilder.Entity<AvailableTerm>()
                .HasData(new AvailableTerm
                {
                    Id = 2,
                    HotelId = 1,
                    TermStatusId = 1,
                    Month = 2,
                    Year = 2023,
                });

            modelBuilder.Entity<AvailableTerm>()
                .HasData(new AvailableTerm
                {
                    Id = 3,
                    HotelId = 2,
                    TermStatusId = 1,
                    Month = 1,
                    Year = 2023,
                });

            modelBuilder.Entity<AvailableTerm>()
                .HasData(new AvailableTerm
                {
                    Id = 4,
                    HotelId = 2,
                    TermStatusId = 1,
                    Month = 2,
                    Year = 2023,
                });

            modelBuilder.Entity<AvailableTerm>()
                .HasData(new AvailableTerm
                {
                    Id = 5,
                    HotelId = 3,
                    TermStatusId = 1,
                    Month = 1,
                    Year = 2023,
                });

            modelBuilder.Entity<AvailableTerm>()
                .HasData(new AvailableTerm
                {
                    Id = 6,
                    HotelId = 3,
                    TermStatusId = 1,
                    Month = 2,
                    Year = 2023,
                });

        }
    }
}
