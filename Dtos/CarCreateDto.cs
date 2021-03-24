using System.ComponentModel.DataAnnotations;

namespace fleks_backend.Dtos
{

  // IF AN INT PROPERTY THAT IS REQUIRED IS REMOVED FROM POST
  // WILL RETURN 201 CREATED
  // INT PROPERTY WILL BE 0
  // WHAT GIVES?

  public class CarCreateDto
  {
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
    
    [Required]
    public string ImagePath { get; set; }
  }
}