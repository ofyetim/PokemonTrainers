namespace PokemonTrainersApp.Models;

public class PokemonTrainersRepostory
{
    public static List<Trainers> Trainer { get; set; } = new List<Trainers>()
    {
        new Trainers
        {
            
            Id = 1,
            Bag = new TrainersBag(10,10,10,20,10,5),
            Username = "ofyetim",
            Email = "studentmail@mail.com",
            Password = "password1",
            ConfirmPassword = "password1",
            PokemonList = new List<Pokemon> {new Pokemon( 1, "Bulbasaur", "Grass", 45,  49, 49,  45)}
            
            
        },
        new Trainers
        {
            Id = 2,
            Bag = new TrainersBag(10,10,10,20,10,5),
            Username = "ofyetim1",
            Email = "student2@mail.com",
            Password = "password1",
            ConfirmPassword = "password1",
            PokemonList = new List<Pokemon> {new Pokemon( 2, "Charmander", "Fire", 39,  52, 43,  65)}

        },
    };
}