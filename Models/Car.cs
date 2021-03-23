using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fleks_backend.Models
{
  public class Car
  {
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Model { get; set; }
    
    [Required]
    public int? Year { get; set; }
    
    [Required]
    public string Transmission { get; set; }
    
    [Required]
    public string Fuel { get; set; }
    
    [Required]
    public int? Storage { get; set; }
    
    [Required]
    public int? Price { get; set; }
  }
}