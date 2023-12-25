using API.Entities;

using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class WspolnotaRepository
    {
        private readonly DataContext _context;

        public WspolnotaRepository(DataContext context){
            _context=context;
        }

        public async Task<Wspolnota> GetWspolnotyByIdAsync(int id){
            return await _context.wspolnoty.SingleOrDefaultAsync(p=>p.id==id);
        }
    }
}