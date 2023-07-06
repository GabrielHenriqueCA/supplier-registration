using Microsoft.EntityFrameworkCore;
using Supplier_Registration.Data;
using SupplierRegistration.Repositories;

namespace Supplier_Registration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string mySqlConection = builder.Configuration.GetConnectionString("DefaultConnection");

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
            builder.Services.AddDbContextPool<SupplierContext>(options => options.UseMySql(mySqlConection,
                ServerVersion.AutoDetect(mySqlConection)));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}