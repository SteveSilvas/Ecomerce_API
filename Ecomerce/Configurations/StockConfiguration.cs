using Ecomerce.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.ToTable("Stock");

            builder.HasKey(ac => ac.Id);

            builder.Property(ac => ac.Id)
                .ValueGeneratedOnAdd();

            builder.Property(ac => ac.ProductId)
                .IsRequired();

            builder.Property(ac => ac.Quantity)
                .IsRequired();

            builder.Property(ac => ac.UpdatedAt)
                .IsRequired();

            builder.HasOne(e => e.Product)
                .WithMany()
                .HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
