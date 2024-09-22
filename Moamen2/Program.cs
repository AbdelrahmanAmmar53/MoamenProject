using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moamen2.DAL.Data;
using Moamen2.DAL.Repository.IRepo;
using Moamen2.DAL.UnitOfWork;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Moamen2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
            ));
            builder.Services.AddDbContext<ApplicationDbContext>(option2 =>
            option2.UseSqlServer( b => b.MigrationsAssembly("Moamen2")));
            
            //UnitOfWork
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
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
