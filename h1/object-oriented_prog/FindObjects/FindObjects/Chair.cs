using System;
using System.Collections.Generic;
using System.Text;

namespace FindObjects
{
    class Chair
    {
        private string color;
        private string material;
        private string chairCushion;

        public Chair(string color, string material, string chairCushion)
        {
            this.color = color;
            this.material = material;
            this.chairCushion = chairCushion;
        }

        public string description()
        {
            return $"A {color} chair with a {chairCushion} cushion.";
        }
        public string changeColor(string color)
        {
            this.color = color;
            return $"Chair's color: {color}.";
        }
    }
}
