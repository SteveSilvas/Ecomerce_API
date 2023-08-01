﻿using Ecomerce.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Configurations
{
    public class AddressStateConfiguration : IEntityTypeConfiguration<AddressState>
    {
        public void Configure(EntityTypeBuilder<AddressState> builder)
        {
            builder.ToTable("AddressState");

            builder.HasKey(ac => ac.Id);

            builder.Property(ac => ac.Id)
                .ValueGeneratedOnAdd();

            builder.Property(ac => ac.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
