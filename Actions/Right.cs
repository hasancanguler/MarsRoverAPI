using MarsRoverAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MarsRoverAPI.Enums;

namespace MarsRoverAPI.Actions
{
    public class Right : Action
    {
        public override Rover Move(Rover rover)
        {
            Direction minDirection = Enum.GetValues(typeof(Direction)).Cast<Direction>().Min();
            Direction maxDirection = Enum.GetValues(typeof(Direction)).Cast<Direction>().Max();

            if (rover.Direction == maxDirection)
                rover.Direction = minDirection;
            else
                rover.Direction = rover.Direction + 1;
            return rover;
        }
    }
}
