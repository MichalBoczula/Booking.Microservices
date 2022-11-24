using Booking.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Service.Persistance.Configuration
{
    public class BookedTermConfiguration : IEntityTypeConfiguration<BookedTerm>
    {
        public void Configure(EntityTypeBuilder<BookedTerm> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.AvailableTermRef)
                .WithOne(x => x.BookedTermRef);
            builder.HasOne(x => x.PaymentStatusRef)
                .WithMany(x => x.BookedTerms);
        }
    }
}
