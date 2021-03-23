using fleks_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace fleks_backend.Data
{
  public class FleksBackendContext : DbContext
  {
    public FleksBackendContext(DbContextOptions<FleksBackendContext> opt) : base(opt)
    {
        
    }

    public DbSet<Car> Cars { get; set; }   
  }
}