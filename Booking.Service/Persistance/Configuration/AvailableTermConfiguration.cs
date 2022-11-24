using Booking.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Service.Persistance.Configuration
{
    public class AvailableTermConfiguration : IEntityTypeConfiguration<AvailableTerm>
    {
        public void Configure(EntityTypeBuilder<AvailableTerm> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.HotelRef)
                .WithMany(x => x.AvailableTerms);
            builder.HasOne(x => x.TermStatusRef)
                .WithMany(x => x.AvailableTerms);
            builder.HasOne(x => x.BookedTermRef)
                .WithOne(x => x.AvailableTermRef)
                .HasForeignKey<BookedTerm>(x => x.AvailableTermId);
        }
    }
}
