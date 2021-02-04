using Metrobus.Services.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Metrobus.Services.Models
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<AppDbContext>().Database.Migrate(); 
            }
        }

        public static void SeedData(AppDbContext context)
        {
            System.Console.WriteLine("Appling Migrations...");
            context.Database.EnsureCreated();
        }
    }
}