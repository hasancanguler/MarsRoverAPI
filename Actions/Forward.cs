using MarsRoverAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MarsRoverAPI.Enums;

namespace MarsRoverAPI.Actions
{
    public class Forward: Action
    {
        public override Rover Move(Rover rover)
        {
            switch (rover.Direction)
            {
                case Direction.N:
                    rover.Y += 1;
                    break;
                case Direction.E:
                    rover.X += 1;
                    break;
                case Direction.S:
                    rover.Y += -1;
                    break;
                case Direction.W:
                    rover.X += -1;
                    break;
            }
            return rover;
        }
    }
}
