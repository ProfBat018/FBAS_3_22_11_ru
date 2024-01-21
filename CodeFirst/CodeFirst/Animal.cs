using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst;

public class Animal
{
    [Key]
    public int Id { get; set; }
    
    [Required, 
     MaxLength(30),
     MinLength(2),
     RegularExpression(@"^[a-zA-Z]+$")]
    public string Name { get; set; }
    
    [Required, Range(0, 30)]
    public int Age { get; set; }
    
    [ForeignKey("AnimalType")]
    public int AnimalTypeId { get; set; }
    public AnimalType AnimalType { get; set; }
}