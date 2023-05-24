using Microsoft.AspNetCore.Mvc;
using PokemonTrainersApp.Models;

namespace PokemonTrainersApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PokedexController: ControllerBase
{
    
    [HttpGet]
    [Route("All", Name = "GetAllPokemons")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<PokemonsDTO> GetAllPokemons()
    {
        var pokemon = PokemonsRepostory.Pokemons.Select(s => new PokemonsDTO()
        {
            Id = s.Id,
            Name = s.Name,
            Type = s.Type,
            BaseHP = s.BaseHP,
            BaseAttack = s.BaseAttack,
            BaseDeffance = s.BaseDefance,
            Speed = s.Speed

        });
        return Ok(PokemonsRepostory.Pokemons);
    }
    [HttpGet]
    [Route("{name:alpha}", Name = "GetPokemonByName")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PokemonsDTO> GetPokemonByName(string name)
    {
        // Bad Request - 400 - Client Error
        if (string.IsNullOrEmpty(name))
            return BadRequest();
            
        var pkmn = PokemonsRepostory.Pokemons.Where(n=>n.Name==name).FirstOrDefault();
        // Not Found - 404 - Client Error
        if (pkmn == null)
            return NotFound($"The Pokemin with name {name} not found");
        return Ok(PokemonsRepostory.Pokemons.Where(n => n.Name == name).FirstOrDefault());
    }
}