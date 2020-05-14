using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarsRoverAPI.Actions;
using MarsRoverAPI.Models;
using MarsRoverAPI.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MarsRoverAPI.Enums;

namespace MarsRoverAPI.Controllers
{
    [ApiController]
    public class RoversController : ControllerBase
    {
        Surface mars = Surface.GetInstance();
        private Rover rover = new Rover();


        [HttpPost]
        [Route("api/Rovers/Move")]
        public string Move([FromBody()] RoverRequest _rover)
        {
            new SurfaceBuss().Create(mars);
            rover = _rover.Rover;

            if (mars.X == 0 && mars.Y == 0)
            {
                mars.X = 5;
                mars.Y = 5;
            }

            foreach (string axis in _rover.Axises)
            {
                Actions.Action action;
                Utility.Direction.selector.TryGetValue(axis, out action);
                if (action != null)
                    rover = action.Move(rover);
            }
            return rover.X + ", " + rover.Y + ", " + rover.Direction + " rover stoped";
        }

    }
}
