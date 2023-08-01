using Ecomerce.Interface;
using Ecomerce.Repository;
using Ecomerce.Services;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;


namespace Ecomerce.Context
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureInjections(builder);

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //using (var scope = app.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    var context = services.GetRequiredService<DBContext>();
            //    SeedData(context);
            //}

            app.Run();
        }
        private static void ConfigureInjections(WebApplicationBuilder builder)
        {
            // services.AddDbContext<DBContext>(
            //    options => options.UseMySql(builder.Configuration.GetSection("ApiOptions").GetValue<string>("ConnectionString"))
            //);

            //builder.Services.AddDbContext<DBContext>(options => options.UseInMemoryDatabase("InMemoryDB"));

            builder.Services.AddDbContext<DBContext>(options =>
                options.UseMySql(builder.Configuration
                .GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));
            using (var context = builder.Services.BuildServiceProvider().GetRequiredService<DBContext>())
            {
                context.Database.Migrate();
            }

            ConfigureRepositories(builder.Services);
            ConfigureServices(builder.Services);
        }
        private static void ConfigureRepositories(IServiceCollection services)
        {
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Program));

            services.AddScoped<IEmployeeService, EmployeeService>();



            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        //private static void SeedData(DBContext context)
        //{
        // Add some data to the context if needed
        // e.g., context.Employees.Add(new Employee { ... });
        // context.SaveChanges();
        //}
    }
}

