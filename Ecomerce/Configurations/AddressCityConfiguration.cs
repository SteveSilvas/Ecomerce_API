using Ecomerce.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Configurations
{
    public class AddressCityConfiguration : IEntityTypeConfiguration<AddressCity>
    {
        public void Configure(EntityTypeBuilder<AddressCity> builder)
        {
            builder.ToTable("AddressCity");

            builder.HasKey(ac => ac.Id);

            builder.Property(ac => ac.Id)
                .ValueGeneratedOnAdd();

            builder.Property(ac => ac.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
