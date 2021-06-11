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
  }
}