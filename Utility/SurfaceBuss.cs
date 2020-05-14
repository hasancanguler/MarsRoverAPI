using MarsRoverAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRoverAPI.Utility
{
    public class SurfaceBuss
    {
        public string Create(Surface surface)
        {
            Surface mars = Surface.GetInstance();
            mars.X = surface.X;
            mars.Y = surface.Y;

            Utility.Direction.Create();

            return mars.X + ", " + mars.Y + " surface is created";
        }
    }
}
