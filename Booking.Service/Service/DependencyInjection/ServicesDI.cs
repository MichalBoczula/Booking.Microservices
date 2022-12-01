using Booking.Service.Application.Contracts;
using Booking.Service.Persistance.Context;
using Booking.Service.Service.SynchCommunication.PaymentAPI.Abstract;
using Booking.Service.Service.SynchCommunication.PaymentAPI.Concrete;

namespace Booking.Service.Service.DependencyInjection
{
    public static class ServicesDI
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPaymentService, PaymentService>();
            return services;
        }
    }
}
