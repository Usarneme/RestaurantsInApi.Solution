using System;
using System.ComponentModel.DataAnnotations;

namespace Client.Data
{
  [Serializable]
  public class Restaurant
  {
    public Restaurant()
    {
      Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }

    [Required(ErrorMessage ="Name of the Restaurant is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage ="Description of the Restaurant is required.")]
    public string Description { get; set; }
    public float Longitude { get; set; }
    public float Latitude { get; set; }
    public string Menu { get; set; }
  }
}
