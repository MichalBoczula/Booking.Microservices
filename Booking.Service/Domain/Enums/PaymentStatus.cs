using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Domain.Enums
{
    public enum PaymentStatus
    {
        Accepted = 1,
        Declined = 2,
        Waiting = 3,
    }
}
