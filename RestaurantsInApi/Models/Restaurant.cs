using System;

namespace RestaurantsInApi.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Longitude { get; set; }
    public float Latitude { get; set; }
    public string Menu { get; set; }
  }
}
