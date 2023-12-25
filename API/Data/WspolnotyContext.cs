using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class WspolnotyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=toolsserverforpolsl.mysql.database.azure.com;user=root1;password=admin123$;database=toolsdb";

            var serverVersion = new MySqlServerVersion(new Version(8, 0));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        public DbSet<Wspolnota> Wspolnoty { get; set; }
    }
}