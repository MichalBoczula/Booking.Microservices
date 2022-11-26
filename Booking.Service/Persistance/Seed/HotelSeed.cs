using Booking.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Persistance.Seed
{
    public static class HotelSeed
    {
        public static void CreateHotel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
                .HasData(new Hotel()
                {
                    Id = 1,
                    Name = "President"
                });

            modelBuilder.Entity<Hotel>()
                .HasData(new Hotel()
                {
                    Id = 2,
                    Name = "Bro"
                });

            modelBuilder.Entity<Hotel>()
                 .HasData(new Hotel()
                 {
                     Id = 3,
                     Name = "Island"
                 });
        }
    }
}
