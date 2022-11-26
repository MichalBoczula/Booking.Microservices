using Booking.Service.Application.Contracts;
using Booking.Service.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookingServiceDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IBookingServiceDbContext, BookingServiceDbContext>();

            return services;
        }
    }
}
