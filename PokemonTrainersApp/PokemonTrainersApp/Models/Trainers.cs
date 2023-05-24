namespace PokemonTrainersApp.Models;
public class Trainers
{
    public int Id { get; set; }
    
    public int BagId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    
    public TrainersBag Bag { get; set; }  
    
    public List<Pokemon> PokemonList { get; set; }
}