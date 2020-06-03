using System;
using System.Collections.Generic;
using System.Text;

namespace FindObjects
{
    class Bed
    {
        private string color;
        private int pillowCount;
        private int blanketCount;

        public Bed(string color, int pillowCount, int blanketCount)
        {
            this.color = color;
            this.pillowCount = pillowCount;
            this.blanketCount = blanketCount;
        }

        public string ChangeBlanketCount(int number)
        {
            blanketCount = number;
            return $"Blanket count: {blanketCount}.";
        }

        public string description()
        {
            if (blanketCount == 1)
            {
                return $"The bed has {pillowCount} pillows and {blanketCount} blanket.";
            }
            else
            {
                return $"The bed has {pillowCount} pillows and {blanketCount} blankets.";
            }
        }
    }
}
