using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Skeleton.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonsController : ControllerBase
{
    private IPokemonService _pokemonService;

    public PokemonsController(IPokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }

    [HttpGet("GetAll")]
    public async Task<List<Pokemon>> GetAll()
    {
        return await _pokemonService.GetAll();
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        if (id <= 0)
            return BadRequest();

        var pokemon = await _pokemonService.GetPokemon(id);

        if (pokemon == null)
            return NotFound();

        return Ok(pokemon);
    }
}
