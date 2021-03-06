using System;
using System.Collections.Generic;

namespace RestaurantsInApi.Models
{
  public class City
  {
    public City()
    {
      Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Longitude { get; set; }
    public float Latitude { get; set; }
    public string State { get; set; }
    public ICollection<Restaurant> Restaurants { get; set; }
  }
}
