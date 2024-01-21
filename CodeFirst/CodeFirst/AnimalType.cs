using System.ComponentModel.DataAnnotations;

namespace CodeFirst;

public class AnimalType
{
    [Key]
    public int Id { get; set; }
    
    [Required, 
     MaxLength(30),
     MinLength(2),
     RegularExpression(@"^[a-zA-Z]+$")]
    public string Name { get; set; }

    public ICollection<Animal> Animals { get; set; }
}