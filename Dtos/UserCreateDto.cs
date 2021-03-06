using System.ComponentModel.DataAnnotations;

namespace fleks_backend.Dtos
{
  public class UserCreateDto
  {
    [Required]
    public string UserName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
  }
}