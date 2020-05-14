using MarsRoverAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRoverAPI.Actions
{
    public abstract class Action
    {
        public abstract Rover Move(Rover rover);
    }
}
