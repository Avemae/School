using System;
using System.Collections.Generic;
using System.Text;

namespace FindObjects
{
    class Cup
    {
        private string color = "white and purple";
        private bool containsTea = false;
        private string size = "large";

        public Cup(string color, bool containsTea, string size)
        {
            this.color = color;
            this.containsTea = containsTea;
            this.size = size;
        }

        public string description()
        {
            return $"This cup is pretty {size}.";
        }
        public string pourSomeTea()
        {
            containsTea = true;
            return $"Does the cup contain tea: {containsTea}.";
        }
    }
}
