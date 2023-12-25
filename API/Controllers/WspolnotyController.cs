
using API.Data;
using API.Entities;

using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{   

public class WspolnotyController : BaseApiController
{
    private readonly WspolnotaRepository _wspolnoty;

    public WspolnotyController(WspolnotaRepository wspolnoty)
    {
        _wspolnoty = wspolnoty;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Wspolnota>>> GetWspolnoty()
    {
        return Ok(await _wspolnoty.GetWspolnotyAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Wspolnota>> GetWspolnota(int id)
    {
        var wspolnota = await _wspolnoty.GetWspolnotaByIdAsync(id);

        if (wspolnota == null)
        {
            return NotFound(); // Zwracaj NotFound, jeśli nie znaleziono wspólnoty o danym ID
        }

        return Ok(wspolnota);
    }
}
}