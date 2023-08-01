using Ecomerce.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(a => a.Id);

            builder.Property(e => e.Salario)
                .HasColumnType("decimal(18, 2)")
                .IsRequired();

            builder.Property(e => e.Admission)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(e => e.Resignation)
                .HasColumnType("date");

            builder.Property(e => e.Active)
                .IsRequired();

            builder.HasOne(e => e.Department)
                .WithMany()
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
