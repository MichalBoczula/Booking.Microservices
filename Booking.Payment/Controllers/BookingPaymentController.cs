using Booking.Payment.Application.Features.Commands.AddPayment;
using Booking.Payment.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingPaymentController : BaseController
    {
        [HttpGet("GetAvailableTerms")]
        public async Task<ActionResult> GetAvailableTermsAsync()
        {
            var result = await Mediator.Send(new AddPaymentCommand()
            {
                AddPaymentExternal = new AddPaymentExternal()
                {
                    OrderIntegrationId = Guid.NewGuid().ToString(),
                    Total = 200
                }
            });
            return Ok(result);
        }
    }
}
