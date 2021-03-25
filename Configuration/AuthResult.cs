using System.Collections.Generic;

namespace fleks_backend.Configuration
{
  public class AuthResult
  {
    public string Token { get; set; }
    public bool Success { get; set; }
    public List<string> Errors { get; set; }
  }
}