using System.ComponentModel.DataAnnotations;

namespace PokemonTrainersApp.Models;


public class TrainersDTO
{

    public int Id { get; set; }
    public int BagId { get; set; }
    [Required(ErrorMessage = "Please enter a doesnt exist username")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Please enter a doesnt exist email")]
    public string Email { get; set; }
    
    public string Password { get; set; }
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

    public TrainersBag Bag { get; set; }  
    
    public List<Pokemon> PokemonList { get; set; }
    public DateTime AdmissionDate { get; set; }
}