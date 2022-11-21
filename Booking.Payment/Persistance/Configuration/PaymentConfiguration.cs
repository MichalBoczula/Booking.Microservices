using Booking.Payment.Domain.Dictionaries;
using Booking.Payment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Payment.Persistance.Configuration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Domain.Entities.Payment>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Payment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.PaymentStatusRef)
                .WithMany(x => x.Payments);
        }
    }
}
