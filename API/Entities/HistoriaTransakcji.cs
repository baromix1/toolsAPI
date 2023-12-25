using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class HistoriaTransakcji : BaseEntity
    {
        public required int idUzytkownika { get; set; }
        public required int idOferty { get; set; }
    }
}