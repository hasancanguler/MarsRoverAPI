using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRoverAPI
{
    public class Enums
    {
        public enum Direction
        {
            N = 0,
            E = 1,
            S = 2,
            W = 3
        }

        public enum Movement
        {
            L = -1,
            R = 1,
            M
        }
    }
}
