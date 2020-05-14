using MarsRoverAPI.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRoverAPI.Utility
{
    public static class Direction
    {
        public static Dictionary<string, Actions.Action> selector = new Dictionary<string, Actions.Action>();
               
        public static void Create()
        {
            selector.Clear();
            selector.Add("L", new Left());
            selector.Add("R", new Right());
            selector.Add("M", new Forward());
        }
    }
}
