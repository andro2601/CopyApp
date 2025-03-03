using Microsoft.EntityFrameworkCore;

namespace CopyApp.Data
{
    public class CopyAppContext : DbContext
    {
        protected readonly IConfiguration configuration;
        public CopyAppContext(IConfiguration configuration) {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("CopyAppDBConnection"));
        }
    }
}
