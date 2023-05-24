namespace PokemonTrainersApp.Models;

public class PokemonsRepostory
{
    public static List<Pokemon> Pokemons { get; set; } = new List<Pokemon>()
    {
        new Pokemon
        {
            Id = 1,
            Name = "bulbasaur",
            Type = "Grass",
            BaseHP = 45,
            BaseAttack = 49,
            BaseDefance =49,
            Speed = 45
            
        },
        new Pokemon
        {
            Id = 2,
            Name = "charmander",
            Type = "Fire",
            BaseHP = 39,
            BaseAttack = 52,
            BaseDefance =43,
            Speed = 65
            
        },
        new Pokemon
        {
            Id = 3,
            Name = "squirtle",
            Type = "Water",
            BaseHP = 44,
            BaseAttack = 48,
            BaseDefance =65,
            Speed = 43
            
        },
        new Pokemon
        {
            Id = 4,
            Name = "caterpie",
            Type = "Bug",
            BaseHP = 45,
            BaseAttack = 30,
            BaseDefance =35,
            Speed = 45
            
        },
        new Pokemon
        {
            Id = 5,
            Name = "weedle",
            Type = "Bug",
            BaseHP = 40,
            BaseAttack = 35,
            BaseDefance =30,
            Speed = 50
            
        },
        new Pokemon
        {
            Id = 6,
            Name = "pidgey",
            Type = "Normal",
            BaseHP = 40,
            BaseAttack = 45,
            BaseDefance =40,
            Speed = 56
            
        },
        new Pokemon
        {
            Id = 7,
            Name = "rattata",
            Type = "Normal",
            BaseHP = 30,
            BaseAttack = 56,
            BaseDefance =35,
            Speed = 72
            
        },
        new Pokemon
        {
            Id = 8,
            Name = "spearow",
            Type = "Normal",
            BaseHP = 40,
            BaseAttack = 60,
            BaseDefance =30,
            Speed = 70
            
        },
        new Pokemon
        {
            Id = 9,
            Name = "ekans",
            Type = "Poison",
            BaseHP = 35,
            BaseAttack = 60,
            BaseDefance =44,
            Speed = 55
            
        },
        new Pokemon
        {
            Id = 10,
            Name = "pikachu",
            Type = "Electric",
            BaseHP = 35,
            BaseAttack = 55,
            BaseDefance =40,
            Speed = 90
            
        },
        new Pokemon
        {
            Id = 11,
            Name = "sandshrew",
            Type = "Ground",
            BaseHP = 50,
            BaseAttack = 75,
            BaseDefance =85,
            Speed = 40
            
        },
        new Pokemon
        {
            Id = 12,
            Name = "nidoran",
            Type = "Poison",
            BaseHP = 55,
            BaseAttack = 47,
            BaseDefance =52,
            Speed = 41
            
        },
        new Pokemon
        {
            Id = 13,
            Name = "clefairy",
            Type = "Grass",
            BaseHP = 70,
            BaseAttack = 45,
            BaseDefance =48,
            Speed = 35
            
        },
        new Pokemon
        {
            Id = 14,
            Name = "vulpix",
            Type = "Fire",
            BaseHP = 38,
            BaseAttack = 41,
            BaseDefance =40,
            Speed = 65
            
        },
        new Pokemon
        {
            Id = 15,
            Name = "jigglypuff",
            Type = "Fairy",
            BaseHP = 115,
            BaseAttack = 45,
            BaseDefance =20,
            Speed = 20
            
        }
    };
}