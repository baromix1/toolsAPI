using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class userDto
    {   
        public int idUzytkownika { get; set; }
        public required string username { get; set; }
    }
}