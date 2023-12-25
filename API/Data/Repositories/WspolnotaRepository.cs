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

#pragma warning disable CS8603 // Possible null reference return.
            return await _context.wspolnoty.SingleOrDefaultAsync(p=>p.Id==id);
#pragma warning restore CS8603 // Possible null reference return.

        }
    }
}