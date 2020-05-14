using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarsRoverAPI.Models;
using MarsRoverAPI.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarsRoverAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurfacesController : ControllerBase
    {
        [HttpPost]
        public string Create([FromBody] Surface surface)
        {
            SurfaceBuss surfaceBuss = new SurfaceBuss();
            return surfaceBuss.Create(surface);
        }
    }
}