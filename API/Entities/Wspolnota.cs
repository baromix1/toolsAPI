using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Wspolnota : BaseEntity
    {
        public required string nazwa { get; set; }

        public required string miasto { get; set; }
    }
}