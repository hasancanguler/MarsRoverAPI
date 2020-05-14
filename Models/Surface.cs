using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRoverAPI.Models
{
    
    public class Surface
    {
        private static Surface instance;
        private Surface(){}

        public static Surface GetInstance()
        {
            if (instance == null)
            {
                instance = new Surface();
            }
            return instance;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
