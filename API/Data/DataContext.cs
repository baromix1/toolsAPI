using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=toolsserverforpolsl.mysql.database.azure.com;user=root1;password=admin123$;database=toolsdb";

            var serverVersion = new MySqlServerVersion(new Version(8, 0));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
        public DbSet<Wspolnota> wspolnoty { get; set; }
        public DbSet<HistoriaTransakcji> historieTransakcji { get; set; }
        public DbSet<KomentarzForum> komentarzeForum { get; set; }
        public DbSet<KomentarzOferty> komentarzeOferty { get; set; }
        public DbSet<Konwersacja> Konwersacje { get; set; }
        public DbSet<Oferta> oferty { get; set; }
        public DbSet<PostForum> postyForum { get; set; }
        public DbSet<Uzytkownik> uzytkownicy { get; set; }
        public DbSet<UzytkownikWspolnotaAsocjacja> uzytkownicyWspolnotyAsocjace { get; set; }
        public DbSet<Wiadomosc> wiadomosci { get; set; }
    }
}