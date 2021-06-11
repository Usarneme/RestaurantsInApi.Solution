using System;
using System.Device.Location;

namespace RestaurantsInApi.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      Id = Guid.NewGuid().ToString;
    }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Location Location { get; set; }
    public string Menu { get; set; }
  }
}
