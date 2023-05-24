namespace PokemonTrainersApp.Models;

public class Pokemon
{
    public Pokemon(int id, string name, string type, int baseHp, int baseAttack, int baseDefance, int speed)
    {
        Id = id;
        Name = name;
        Type = type;
        BaseHP = baseHp;
        BaseAttack = baseAttack;
        BaseDefance = baseDefance;
        Speed = speed;
    }

    public Pokemon()
    {
        Id = 0;
        Name ="";
        Type = "";
        BaseHP = 0;
        BaseAttack = 0;
        BaseDefance = 0;
        Speed = 0;
    }

    public static int GivePokemon()
    {
        Random r = new Random();
        int rInt = r.Next(1,15);
        
        return rInt;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string  Type { get; set; }
    public int BaseHP { get; set; }
    public int BaseAttack { get; set; }
    public int BaseDefance { get; set; }
    public int Speed { get; set; }

    
}