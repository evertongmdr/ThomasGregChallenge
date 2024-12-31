using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThomasGreg.Domain.Models;

namespace ThomasGreg.Infrastructure.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(a => a.Number)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Neighborhood)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(a => a.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.State)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Country)
                .IsRequired()
            .HasMaxLength(100);

            builder.Property(a => a.ZipCode)
               .IsRequired()
               .HasMaxLength(8);
        }
    }
}
