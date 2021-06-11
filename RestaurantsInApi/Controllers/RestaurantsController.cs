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

  }
}