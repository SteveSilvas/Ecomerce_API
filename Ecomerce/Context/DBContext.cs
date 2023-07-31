using Ecomerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Context
{
    public class DBContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");
        }
    }
}
