using Ecomerce.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory");

            builder.HasKey(ac => ac.Id);

            builder.Property(ac => ac.Id)
                .ValueGeneratedOnAdd();

            builder.Property(ac => ac.Description)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}