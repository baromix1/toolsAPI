using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class UzytkownicyWspolnotyAsocjacjeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=toolsserverforpolsl.mysql.database.azure.com;user=root1;password=admin123$;database=toolsdb";

            var serverVersion = new MySqlServerVersion(new Version(8, 0));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        public DbSet<UzytkownikWspolnotaAsocjacja> uzytkownicyWspolnotyAsocjace { get; set; }
    }
}