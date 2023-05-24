namespace PokemonTrainersApp.Validators;
using System.ComponentModel.DataAnnotations;

public class DataCheckAttribute:ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var date = (DateTime?)value;
        if (date > DateTime.Today)
        {
            return new ValidationResult("Aga bu soyledigin gun daha gelmedi");
        }

        return ValidationResult.Success;
    }
}