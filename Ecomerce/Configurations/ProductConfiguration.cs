using Ecomerce.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(ac => ac.Id);

            builder.Property(ac => ac.Id)
                .ValueGeneratedOnAdd();

            builder.Property(ac => ac.Name)
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(ac => ac.Description)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(ac => ac.Price)
            .IsRequired();

            builder.HasOne(e => e.Category)
                .WithMany()
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}