using Microsoft.EntityFrameworkCore;
using CopyApp.Models;

namespace CopyApp.Data
{
    public class CopyAppContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public CopyAppContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("CopyAppDBConnection"));
        }

        public DbSet<Document> Documents { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}