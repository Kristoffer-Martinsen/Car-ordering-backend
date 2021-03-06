using fleks_backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace fleks_backend.Data
{
  public class FleksBackendContext : IdentityDbContext
  {
    public FleksBackendContext(DbContextOptions<FleksBackendContext> opt) : base(opt)
    {
        
    }

    public DbSet<Car> Cars { get; set; }   
    public DbSet<User> Users { get; set; }
  }
}