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
  public class RestaurantsController : ControllerBase
  {
    private readonly RestaurantsInApiContext _db;
    public RestaurantsController(RestaurantsInApiContext db)
    {
      _db = db;
    }

    [HttpGet] // api/Restaurants
    public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestaurants()
    {
      return await _db.Restaurants.ToListAsync();
    }

    [HttpGet("{id}")] // api/Restaurants/#
    public async Task<ActionResult<Restaurant>> GetRestaurant(string id)
    {
      var restaurant = await _db.Restaurants.FindAsync(id);
      if (restaurant == null)
      {
        return NotFound();
      }
      return restaurant;
    }

    [HttpPost] // api/Restaurant
    public async Task<ActionResult<Restaurant>> PostNewRestaurant(Restaurant r)
    {
      _db.Restaurants.Add(r);
      await _db.SaveChangesAsync();
      return CreatedAtAction("GetRestaurant", new { id = r.Id }, r);
    }

    [HttpPut("{id}")] // api/Restaurant/#
    public async Task<IActionResult> PutRestaurant(string id, Restaurant r)
    {
      if (id != r.Id)
      {
        return BadRequest();
      }
      _db.Entry(r).State = EntityState.Modified;
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!RestaurantExists(id))
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

    [HttpDelete("{id}")] // api/Restaurants/#
    public async Task<IActionResult> DeleteRestaurant(string id)
    {
      var restaurant = await _db.Restaurants.FindAsync(id);
      if (restaurant == null)
      {
        return NotFound();
      }
      _db.Restaurants.Remove(restaurant);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    [HttpGet("random")] // api/Restaurants/random
    public async Task<ActionResult<Restaurant>> GetRandomRestaurant()
    {
      var restaurants = await _db.Restaurants.ToListAsync();
      var random = new Random();
      int index = random.Next(restaurants.Count);
      return restaurants[index];
    }

    [HttpGet("search/{query}")] // api/Restaurants/search/?
    public async Task<ActionResult<Restaurant>> Search(string query)
    {
      var restaurant = await _db.Restaurants.FirstOrDefaultAsync(r => r.Name.ToLower() == query.ToLower());
      if (restaurant == null)
      {
        return NotFound();
      }
      return restaurant;
    }

    private bool RestaurantExists(string id)
    {
      return _db.Restaurants.Any(r => r.Id == id);
    }
  }
}