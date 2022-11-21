using Booking.Payment.Application.Contracts;
using Booking.Payment.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace Booking.Payment.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PaymentDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IPaymentDbContext, PaymentDbContext>();

            return services;
        }
    }
}
