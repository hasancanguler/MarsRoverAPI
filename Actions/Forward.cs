using MarsRoverAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MarsRoverAPI.Enums;

namespace MarsRoverAPI.Actions
{
    public class Forward : Action
    {
        private Dictionary<Direction, IForward> forwardSelector = new Dictionary<Direction, IForward>();

        public Forward()
        {
            forwardSelector.Clear();
            forwardSelector.Add(Direction.N, new North());
            forwardSelector.Add(Direction.E, new East());
            forwardSelector.Add(Direction.S, new South());
            forwardSelector.Add(Direction.W, new West());
        }

        public override Rover Move(Rover rover)
        {
            IForward forward;
            forwardSelector.TryGetValue(rover.Direction, out forward);
            return forward.Forward(rover);
        }
    }
  
}
