using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThomasGreg.Domain.Models;

namespace ThomasGreg.Infrastructure.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.Email)
              .IsUnique();

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(c => c.Email)
               .IsRequired()
               .HasMaxLength(256);

        }
    }
}
