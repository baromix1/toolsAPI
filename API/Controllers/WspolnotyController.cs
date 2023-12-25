using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class WspolnotyController : BaseApiController
    {
        private readonly DataContext _context;
        public WspolnotyController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Wspolnota>> GetWspolnoty()
        {
            var wspolnota = _context.wspolnoty.ToList();

            return wspolnota;
        }

        [HttpGet("{id}")]
        public ActionResult<Wspolnota> GetWspolnota(int id)
        {
            return _context.wspolnoty.Find(id);
        }
    }
}