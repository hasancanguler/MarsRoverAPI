using MarsRoverAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRoverAPI.Actions
{
    public class ActionProvider
    {
        public Rover Start(Action action, Rover rover)
        {
            return action.Move(rover);
        }
    }
}
