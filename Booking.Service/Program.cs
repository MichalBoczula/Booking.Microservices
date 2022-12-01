using Booking.Service.Application.DependencyInjection;
using Booking.Service.Persistance.DependencyInjection;
using Booking.Service.Service.DependencyInjection;
using Booking.Service.Service.SynchCommunication.PaymentAPI.Abstract;
using Booking.Service.Service.SynchCommunication.PaymentAPI.Concrete;
using Booking.Service.Service.SynchCommunication.PaymentAPI.Policy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddHttpClient<IPaymentService, PaymentService>()
     .AddPolicyHandler(PaymentPolicy.GetRetryPolicy())
     .AddPolicyHandler(PaymentPolicy.GetCircuitBreakerPolicy());
builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
