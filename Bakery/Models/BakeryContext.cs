using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
  public class BakeryContext : IdentityDbContext<ApplicationUser> //tells identity which class in the application will contain the user account information identity is responsible for authenticating
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat {get; set; }
    public DbSet<ApplicationUserTreat> ApplicationUserTreat { get; set; }
    
    public BakeryContext(DbContextOptions options) : base(options) { }
  }
}