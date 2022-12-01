using Booking.Service.Application.Features.Queries.CheckTermByOrderId;
using Booking.Service.Service.SynchCommunication.PaymentAPI.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Booking.Service.Service.SynchCommunication.PaymentAPI.Abstract;

namespace Booking.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public ExternalController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("ProcessPayment")]
        public async Task<ActionResult> ProcessPayment(string orderId)
        {
            var result = await this._paymentService.ProcessPayment(orderId);
            return Ok(result);
        }
    }
}
