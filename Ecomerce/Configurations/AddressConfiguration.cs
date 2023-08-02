using Ecomerce.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(a => a.Street)
                .HasColumnName("Street")
                .IsRequired();

            builder.Property(a => a.Number)
             .HasColumnName("Number")
             .IsRequired();

            builder.Property(a => a.Complement)
                .HasColumnName("Complement");

            builder.Property(a => a.CityId)
                .HasColumnName("CityId");

            builder.Property(a => a.StateId)
                .HasColumnName("StateId");

            builder.Property(a => a.ZipCode)
                .HasColumnName("ZipCode")
                .IsRequired();

            builder.Property(a => a.Country)
                .HasColumnName("Country");

            builder.HasOne(a => a.City)
                .WithMany()
                .HasForeignKey(a => a.CityId);

            builder.HasOne(a => a.State)
                .WithMany()
                .HasForeignKey(a => a.StateId);
        }
    }
}
