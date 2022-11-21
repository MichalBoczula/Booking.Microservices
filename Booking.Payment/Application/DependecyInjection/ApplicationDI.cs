using MediatR.Pipeline;
using MediatR;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace Booking.Payment.Application.DependecyInjection
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
