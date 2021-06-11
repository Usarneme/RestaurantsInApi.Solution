using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantsInApi.Models;

namespace RestaurantsInApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CitiesController : ControllerBase
  {
    private readonly RestaurantsInApiContext _db;
    public CitiesController(RestaurantsInApiContext db)
    {
      _db = db;
    }

    [HttpGet] // api/Cities
    public async Task<ActionResult<IEnumerable<City>>> GetCities()
    {
      return await _db.Cities.ToListAsync();
    }

    [HttpGet("{id}")] // api/Cities/#
    public async Task<ActionResult<City>> GetCity(string id)
    {
      var City = await _db.Cities.FindAsync(id);
      if (City == null)
      {
        return NotFound();
      }
      return City;
    }

    [HttpPost] // api/City
    public async Task<ActionResult<City>> PostNewCity(City c)
    {
      _db.Cities.Add(c);
      await _db.SaveChangesAsync();
      return CreatedAtAction("GetCity", new { id = c.Id }, c);
    }

    [HttpPut("{id}")] // api/City/#
    public async Task<IActionResult> PutCity(string id, City c)
    {
      if (id != c.Id)
      {
        return BadRequest();
      }
      _db.Entry(c).State = EntityState.Modified;
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CityExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    [HttpDelete("{id}")] // api/Cities/#
    public async Task<IActionResult> DeleteCity(string id)
    {
      var City = await _db.Cities.FindAsync(id);
      if (City == null)
      {
        return NotFound();
      }
      _db.Cities.Remove(City);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    [HttpGet("random")] // api/Cities/random
    public async Task<ActionResult<City>> GetRandomCity()
    {
      var cities = await _db.Cities.ToListAsync();
      var random = new Random();
      int index = random.Next(cities.Count);
      return cities[index];
    }

    [HttpGet("search/{query}")] // api/Cities/search/?
    public async Task<ActionResult<City>> Search(string query)
    {
      var city = await _db.Cities.FirstOrDefaultAsync(r => r.Name.ToLower() == query.ToLower());
      if (city == null)
      {
        return NotFound();
      }
      return city;
    }

    private bool CityExists(string id)
    {
      return _db.Cities.Any(r => r.Id == id);
    }
  }
}