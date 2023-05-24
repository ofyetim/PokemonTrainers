namespace PokemonTrainersApp.Models;
using System.ComponentModel.DataAnnotations;

public class TrainerCreateResponse
{
    public int Id { get; set; }
    public int BagId { get; set; }
    [Required(ErrorMessage = "Please enter a doesnt exist username")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Please enter a doesnt exist mail")]
    public string Email { get; set; }
    
    public string Password { get; set; }
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

    public TrainersBag Bag { get; set; }  
    
    public DateTime AdmissionDate { get; set; }
}