using Booking.Service.Application.Features.Commands.AcceptTerm;
using Booking.Service.Application.Features.Commands.ReserveTerm;
using Booking.Service.Application.Features.Queries.CheckAvailableTerms;
using Booking.Service.Application.Features.Queries.CheckTermByOrderId;
using Booking.Service.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingServiceController : BaseController
    {
        [HttpGet("GetAvailableTerms")]
        public async Task<ActionResult> GetAvailableTermsAsync()
        {
            var result = await Mediator.Send(new CheckAvailableTermsQuery());
            return Ok(result);
        }

        [HttpGet("CheckTermByOrderId")]
        public async Task<ActionResult> CheckTermByOrderIdAsync(string orderId)
        {
            var result = await Mediator.Send(
                new CheckTermByOrderIdQuery()
                {
                    CheckTermById = new CheckTermByIdExternal
                    {
                        OrderId = orderId
                    }
                });
            return Ok(result);
        }

        [HttpPost("ReserveTerm")]
        public async Task<ActionResult> ReserveTermAsync([FromBody] ReserveTermCommandExternal reserveTermCommandExternal)
        {
            var result = await Mediator.Send(new ReserveTermCommand()
            {
                ReserveTermCommandExternalRef = reserveTermCommandExternal
            });
            return Created(string.Empty, result);
        }

        [HttpPut("AcceptTerm")]
        public async Task<ActionResult> AcceptTermAsync([FromBody] AcceptTermExternal acceptTermExternal)
        {
            var result = await Mediator.Send(new AcceptTermCommand()
            {
                AcceptTermExternal = acceptTermExternal
            });
            return Created(string.Empty, result);
        }

        [HttpPut("DeclineTerm")]
        public async Task<ActionResult> DeclineTermAsync([FromBody] ReserveTermCommandExternal reserveTermCommandExternal)
        {
            var result = await Mediator.Send(new ReserveTermCommand()
            {
                ReserveTermCommandExternalRef = reserveTermCommandExternal
            });
            return Created(string.Empty, result);
        }
    }
}
