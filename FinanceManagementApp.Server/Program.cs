
using DbContext;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FinanceManagementApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string connectionString = builder.Configuration.GetConnectionString("Default");
            // Add services to the container.

            builder.Services.AddAuthorization();
            builder.Services.AddIdentityApiEndpoints<Users>().AddEntityFrameworkStores<FMADbContext>();

            builder.Services.AddControllers();
            builder
                .Services
                .AddDbContext<FMADbContext>(cfg => cfg.UseSqlServer(@"there is a connection string!", 
                ss => ss.MigrationsAssembly("FinanceManagementApp.Server")));

            builder.Services.AddIdentityCore<Users>(options =>
            {
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<FMADbContext>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.MapIdentityApi<Users>();
            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
