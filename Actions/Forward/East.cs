using MarsRoverAPI.Models;

namespace MarsRoverAPI.Actions
{
    public class East : IForward
    {
        public Rover Forward(Rover rover)
        {
            rover.X += 1;
            return rover;
        }
    }
}
