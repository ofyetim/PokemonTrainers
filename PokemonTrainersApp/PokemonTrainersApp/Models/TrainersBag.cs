namespace PokemonTrainersApp.Models;

public class TrainersBag
{
    public TrainersBag(int standardPokeballCount, int superPokeballCount, int ultraPokeballCount, int lowPotionCount, int mediumPotionCount, int highPotionCount)
    {
        StandardPokeballCount = standardPokeballCount;
        SuperPokeballCount = superPokeballCount;
        UltraPokeballCount = ultraPokeballCount;
        LowPotionCount = lowPotionCount;
        MediumPotionCount = mediumPotionCount;
        HighPotionCount = highPotionCount;
    }

    public int StandardPokeballCount { get; set; }
    public int SuperPokeballCount { get; set; }
    public int UltraPokeballCount { get; set; }
    
    public int LowPotionCount { get; set; }
    public int MediumPotionCount { get; set; }
    public int HighPotionCount { get; set; }
}
