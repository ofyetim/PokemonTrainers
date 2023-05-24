using System.ComponentModel.DataAnnotations;

namespace PokemonTrainersApp.Models;

public class PokemonsDTO
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string  Type { get; set; }
    
    [Required]
    public int BaseHP { get; set; }
    
    [Required]
    public int BaseAttack { get; set; }
    
    [Required]
    public int BaseDeffance { get; set; }
    
    [Required]
    public int Speed { get; set; }
}