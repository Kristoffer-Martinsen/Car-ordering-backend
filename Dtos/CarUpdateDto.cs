using System;
using System.ComponentModel.DataAnnotations;

namespace fleks_backend.Dtos
{

  public class CarUpdateDto
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