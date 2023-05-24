using System.Net;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
namespace PokemonTrainersApp.Controllers;
using PokemonTrainersApp.Models;


[Route("api/[controller]")]
[ApiController]
public class PokemonTrainersController: ControllerBase
{
    [HttpGet]
    [Route("All", Name = "GetAllTrainers")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<Trainers> GetTrainers()
    {
        var trainers = PokemonTrainersRepostory.Trainer.Select(s => new TrainersDTO()
        {
            Id = s.Id,
            Bag = s.Bag,
            PokemonList = s.PokemonList,
            Username = s.Username,
            Email = s.Email,

        });
        return Ok(PokemonTrainersRepostory.Trainer);

    }
    
    [HttpGet]
    [Route("{id:int}", Name = "GetTrainerById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<TrainersDTO> GetTrainerById(int id)
    {   // Bad Request - 400 - Client Error
        if (id <= 0)
            return BadRequest();
            
        var trnn = PokemonTrainersRepostory.Trainer.Where(n=>n.Id==id).FirstOrDefault();
        // Not Found - 404 - Client Error
        if (trnn == null)
            return NotFound($"The student with id {id} not found");

        var  trainersDTO= new  TrainersDTO()
        {
            Id = trnn.Id,
            BagId = trnn.BagId,
            PokemonList = trnn.PokemonList,
            Username= trnn.Username,
            Email = trnn.Email
        };
            
        // Ok - 200 - Success
        return Ok(trainersDTO);
    }
    
    
    [HttpGet]
    [Route("{username:alpha}", Name = "GetTrainersByUsername")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Trainers> GetTrainersByUsername(string username)
    {
        // Bad Request - 400 - Client Error
        if (string.IsNullOrEmpty(username))
            return BadRequest();
            
        var trnr = PokemonTrainersRepostory.Trainer.Where(n=>n.Username==username).FirstOrDefault();
        // Not Found - 404 - Client Error
        if (trnr == null)
            return NotFound($"The student with id {username} not found");
        return Ok(PokemonTrainersRepostory.Trainer.Where(n => n.Username == username).FirstOrDefault());
    }
    
    
    
    
    [HttpPost]
    [Route("Create")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<TrainersDTO> CreateTrainer([FromBody]TrainerCreateResponse model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
            
        if (model == null)
            return BadRequest();

        if (model.AdmissionDate <= DateTime.Today)
        {
            //1. directly adding error message
            //2. using custom attribute
            ModelState.AddModelError("Admission Error"," Aga bu tarih daha gelmedi");
            return BadRequest(ModelState);
        }

        
        int newId = PokemonTrainersRepostory.Trainer.LastOrDefault().Id + 1;
        Trainers trainer = new Trainers()
        {
            Id = newId,
            Bag = model.Bag,
            PokemonList = new List<Pokemon>(),
            Username = model.Username,
            Email = model.Email
            
        };
        int id = Pokemon.GivePokemon();
        var pokemon = PokemonsRepostory.Pokemons.Where(n=>n.Id==id).FirstOrDefault();
        trainer.PokemonList.Add(pokemon);
        
        PokemonTrainersRepostory.Trainer.Add(trainer);
        model.Id = trainer.Id;
        return CreatedAtRoute("GetTrainerById", new { id = model.Id }, model);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Route("{id:int}", Name = "UpdateTrainerById")]
    public ActionResult<TrainersDTO> UpdateTrainer([FromBody] TrainersDTO model)
    {
        if (model == null || model.Id <= 0)
            BadRequest();
            
        var existingTrainer = PokemonTrainersRepostory.Trainer.Where(s => s.Id == model.Id).FirstOrDefault();
        if (existingTrainer == null)
            return NotFound();

        existingTrainer.Username = model.Username;
        existingTrainer.Email = model.Email;
        existingTrainer.Password = model.Password;
        existingTrainer.ConfirmPassword = model.ConfirmPassword;

        return NoContent(); 
    }

    [HttpDelete("{id:int}", Name = "DeleteTrainerById")]
    public bool DeleteStudents(int id)
    {
        var trainer = PokemonTrainersRepostory.Trainer.Where(n => n.Id == id).FirstOrDefault();
        PokemonTrainersRepostory.Trainer.Remove(trainer);
        return true; 
    }
    
    [HttpDelete("{username:alpha}", Name = "DeleteTrainerByUsername")]
    public bool DeleteStudents(string username)
    {
        var trainer = PokemonTrainersRepostory.Trainer.Where(n => n.Username == username).FirstOrDefault();
        PokemonTrainersRepostory.Trainer.Remove(trainer);
        return true; 
    }
    
    [HttpPost]
    [Route("{username:alpha}", Name = "CatchNewPokemon")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<TrainersDTO> CatchPokemin(string username)
    {
        var trainer = PokemonTrainersRepostory.Trainer.Where(n => n.Username == username).FirstOrDefault();
        int id = Pokemon.GivePokemon();
        var pokemon = PokemonsRepostory.Pokemons.Where(n=>n.Id==id).FirstOrDefault();
        trainer.PokemonList.Add(pokemon);
        
       return  Ok(PokemonTrainersRepostory.Trainer.Where(n => n.Username == username).FirstOrDefault());
    }

}

