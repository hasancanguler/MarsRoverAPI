using MarsRoverAPI.Models;

namespace MarsRoverAPI.Actions
{
    public interface IForward
    {
        Rover Forward(Rover rover);
    }
}
