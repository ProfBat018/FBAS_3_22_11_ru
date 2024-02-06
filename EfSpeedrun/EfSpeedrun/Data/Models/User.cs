using System.ComponentModel.DataAnnotations;

namespace EfSpeedrun.Data.Models;

public class User
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    [Required]
    [MaxLength(50)]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}