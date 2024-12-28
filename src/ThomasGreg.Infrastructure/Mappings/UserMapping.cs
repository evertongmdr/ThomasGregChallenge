using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThomasGreg.Domain.Models;

namespace ThomasGreg.Infrastructure.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.FirstName)
                .IsRequired().HasMaxLength(50);

            builder.Property(p => p.LastName)
                .IsRequired().HasMaxLength(50);

            builder.Property(p => p.CustomName)
                .IsRequired().HasMaxLength(256);
        }
    }
}
