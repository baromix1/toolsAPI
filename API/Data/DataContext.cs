using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=toolsserverforpolsl.mysql.database.azure.com;user=root1;password=admin123$;database=toolsdb";

            var serverVersion = new MySqlServerVersion(new Version(8, 0));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UzytkownikWspolnotaAsocjacja>()
                .HasKey(uwa => new { uwa.idUzytkownika, uwa.idWspolnoty });

            modelBuilder.Entity<UzytkownikWspolnotaAsocjacja>()
                .HasOne<Uzytkownik>()
                .WithMany()
                .HasForeignKey(uwa => uwa.idUzytkownika);

            modelBuilder.Entity<UzytkownikWspolnotaAsocjacja>()
                .HasOne<Wspolnota>()
                .WithMany()
                .HasForeignKey(uwa => uwa.idWspolnoty);
        }
        public DbSet<Wspolnota> wspolnoty { get; set; }
        public DbSet<HistoriaTransakcji> historieTransakcji { get; set; }
        public DbSet<KomentarzForum> komentarzeForum { get; set; }
        public DbSet<KomentarzOferty> komentarzeOferty { get; set; }
        public DbSet<Konwersacja> konwersacje { get; set; }
        public DbSet<Oferta> oferty { get; set; }
        public DbSet<PostForum> postyForum { get; set; }
        public DbSet<Uzytkownik> uzytkownicy { get; set; }
        public DbSet<UzytkownikWspolnotaAsocjacja> uzytkownicyWspolnotyAsocjace { get; set; }
        public DbSet<Wiadomosc> wiadomosci { get; set; }
    }
}