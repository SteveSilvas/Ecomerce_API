using Ecomerce.Context;
using Ecomerce.Interface;
using Ecomerce.Repository;
using Ecomerce.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Ecomerce.Configurations.Injections
{
    public static class ConfigureInjections
    {
        public static void Execute(WebApplicationBuilder builder)
        {
            ConfigureDatabase(builder);
            ConfigureRepositories(builder.Services);
            ConfigureServices(builder.Services);
        }

        private static void ConfigureDatabase(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<DBContext>(options =>
                options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));
        }

        private static void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressCityRepository, AddressCityRepository>();
            services.AddScoped<IAddressStateRepository, AddressStateRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IStockRepository, StockRepository>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            ConfigureAutoMapper(services);
            ConfigureScopedServices(services);
            ConfigureControllers(services);
            ConfigureSwagger(services);
        }

        private static void ConfigureAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }

        private static void ConfigureScopedServices(IServiceCollection services)
        {
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressCityService, AddressCityService>();
            services.AddScoped<IAddressStateService, AddressStateService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IStockService, StockService>();
            // Adicione outros serviços conforme necessário.
        }

        private static void ConfigureControllers(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
        }

        private static void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Ecommerce",
                    Description = "Application of services and product transactions with integrated ERP",
                    Contact = new OpenApiContact
                    {
                        Name = "Steve Silva",
                        Url = new Uri("https://github.com/SteveSilvas")
                    },
                });
            });
        }

    }
}
