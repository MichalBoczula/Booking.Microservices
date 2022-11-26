using Booking.Service.Application.Features.Queries.CheckAvailableTerms;
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
    }
}
