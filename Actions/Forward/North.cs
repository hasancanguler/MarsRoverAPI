using MarsRoverAPI.Models;

namespace MarsRoverAPI.Actions
{
    public class North : IForward
    {
        public Rover Forward(Rover rover)
        {
            rover.Y += 1;
            return rover;
        }
    }
}
