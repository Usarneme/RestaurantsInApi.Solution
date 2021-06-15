using System;
using System.ComponentModel.DataAnnotations;

namespace Client.Data
{
  [Serializable]
  public class City
  {
    public City()
    {
      Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }

    [Required(ErrorMessage ="Name of the City is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage ="Description of the City is required.")]
    public string Description { get; set; }

    [Required(ErrorMessage ="The City's State is required.")]
    public string State { get; set; }
  }
}
