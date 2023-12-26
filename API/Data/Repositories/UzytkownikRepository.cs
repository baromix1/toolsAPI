using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class UzytkownikRepository
    {
        private readonly DataContext _context;

        public UzytkownikRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<userDto> GetUzytkownikByUsernameAsync(string username)
        {

#pragma warning disable CS8603 // Possible null reference return.
            var user= await _context.uzytkownicy.SingleOrDefaultAsync(p => p.username == username);
#pragma warning restore CS8603 // Possible null reference return.
            return new userDto{
                idUzytkownika=user.Id,
                username=user.username
            };

        }

        public async Task<IReadOnlyList<userDto>> GetUzytkownicyAsync()
        {
            List<userDto> lista=new List<userDto>();
            var users= await _context.uzytkownicy.ToListAsync();
            foreach(var u in users){
                userDto temp = new userDto{
                    idUzytkownika=u.Id,
                    username=u.username
                };
                lista.Add(temp);
            }
            return lista;
        }

        public async Task<LoggedUserDto> GetUzytkownikByUsernameAndPasswordAsync(string username, string password)
        {


            var uzytkownik = await _context.uzytkownicy.SingleOrDefaultAsync(p => p.username == username && p.password == password);


            if (uzytkownik == null)
            {
                return null;
            }
            var asocjacja = await _context.uzytkownicyWspolnotyAsocjace
            .Where(p => p.idUzytkownika == uzytkownik.Id)
            .ToListAsync();

            List<Wspolnota> lista = new List<Wspolnota>();
            foreach (var a in asocjacja)
            {
                var temp = await _context.wspolnoty.SingleOrDefaultAsync(p => p.Id == a.idWspolnoty);
                if (temp != null)
                {
                    lista.Add(temp);
                }
            }
            return new LoggedUserDto
            {
                username = uzytkownik.username,
                typ = uzytkownik.typ,
                listaWspolnot = lista
            };

        }
    }
}