using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class UzytkownikWspolnotaAsocjacja : BaseEntity
    {
        public required int idUzytkownika { get; set; }
        public required int idWspolnoty { get; set; }
    }
}