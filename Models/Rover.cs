using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MarsRoverAPI.Enums;

namespace MarsRoverAPI.Models
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
    }

    public class RoverRequest
    {
        public Rover Rover;
        public string[] Axises;
    }

}
