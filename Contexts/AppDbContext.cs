using Metrobus.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrobus.Services.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Metrobuses> Metrobuses { get; set; }
        public DbSet<Alcaldias> Alcaldias { get; set; }
    }
}
