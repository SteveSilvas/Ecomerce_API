using Ecomerce.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Cart");

            builder.HasKey(ac => ac.Id);

            builder.Property(ac => ac.Id)
                .ValueGeneratedOnAdd();

            //builder.Property(ac => ac.Name)
            //.IsRequired()
            //.HasMaxLength(150);

            //builder.Property(ac => ac.Description)
            //    .IsRequired()
            //    .HasMaxLength(150);

        }
    }
}