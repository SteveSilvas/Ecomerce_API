using Ecomerce.Configurations;
using Ecomerce.Model;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Ecomerce.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressCity> AddressCities { get; set; }
        public DbSet<AddressState> AddressStates { get; set; }
        public DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new AddressCityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressStateConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new StockConfiguration());
        }
    }
}
