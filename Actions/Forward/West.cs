using MarsRoverAPI.Models;

namespace MarsRoverAPI.Actions
{
    public class West : IForward
    {
        public Rover Forward(Rover rover)
        {
            rover.X += -1;
            return rover;
        }
    }
}
