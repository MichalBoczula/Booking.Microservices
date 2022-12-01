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
        [HttpPost("AddPayment")]
        public async Task<ActionResult> AddPaymentCommand(AddPaymentExternal addPaymentExternal)
        {
            var result = await Mediator.Send(new AddPaymentCommand()
            {
                AddPaymentExternal = addPaymentExternal
            });
            return Ok(result);
        }
    }
}
