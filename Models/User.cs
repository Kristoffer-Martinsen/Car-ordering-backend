using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fleks_backend.Models
{
  public class User
  {
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
  
  }
}