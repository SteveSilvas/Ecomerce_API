using Ecomerce.Interface;
using Ecomerce.Repository;
using Ecomerce.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql;


namespace Ecomerce.Context
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureInjections(builder);

            WebApplication? app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }
        private static void ConfigureInjections(WebApplicationBuilder builder)
        {
            ConfigureDatabase(builder);
            ConfigureRepositories(builder.Services);
            ConfigureServices(builder.Services);
        }

        private static void ConfigureDatabase(WebApplicationBuilder builder)
        {
            //builder.Services.AddDbContext<DBContext>(options => options.UseInMemoryDatabase("InMemoryDB"));

            builder.Services.AddDbContext<DBContext>(options =>
                options.UseMySql(builder.Configuration
                .GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));
            //using (var context = builder.Services.BuildServiceProvider().GetRequiredService<DBContext>())
            //{
            //    context.Database.Migrate();
            //} Remover isto assim que testar
        }
        private static void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressCityRepository, AddressCityRepository>();
            services.AddScoped<IAddressStateRepository, AddressStateRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressCityService, AddressCityService>();
            services.AddScoped<IAddressStateService, AddressStateService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Ecomerce",
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

