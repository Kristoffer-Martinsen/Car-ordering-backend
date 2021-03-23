namespace fleks_backend.Dtos
{
  public class CarReadDto
  {
    public int Id { get; set; }

    public string Model { get; set; }
    
    public int Year { get; set; }
    
    public string Transmission { get; set; }
    
    public string Fuel { get; set; }
    
    public int Storage { get; set; }
    
    public int Price { get; set; }
  }
}