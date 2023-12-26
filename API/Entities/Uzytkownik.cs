
namespace API.Entities
{
    public class Uzytkownik : BaseEntity
    {
        public required string username { get; set; }
        public required string password { get; set; }
        public required string typ { get; set; }
        public required int idWspolnoty { get; set; }
    }
}