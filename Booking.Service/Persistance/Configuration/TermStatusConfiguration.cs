using Booking.Service.Domain.Dictionaries;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Service.Persistance.Configuration
{
    public class TermStatusConfiguration : IEntityTypeConfiguration<PaymentStatus>
    {
        public void Configure(EntityTypeBuilder<PaymentStatus> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
