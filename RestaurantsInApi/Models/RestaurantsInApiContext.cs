using Microsoft.EntityFrameworkCore;

namespace RestaurantsInApi.Models
{
  public class RestaurantsInApiContext : DbContext
  {
    public RestaurantsInApiContext(DbContextOptions<RestaurantsInApiContext> options) : base(options) {}
    public DbSet<Restaurant> Restaurants { get; set; }
  }
}
