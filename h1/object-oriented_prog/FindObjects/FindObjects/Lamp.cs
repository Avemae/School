using System;
using System.Collections.Generic;
using System.Text;

namespace FindObjects
{
    class Lamp
    {
        private int heightInCm;
        private bool isOn;
        private int bulbs;
        private string color;

        public Lamp(int heightInCm, bool isOn, int bulbs, string color)
        {
            this.heightInCm = heightInCm;
            this.isOn = isOn;
            this.bulbs = bulbs;
            this.color = color;
        }


        public string turnTheLightOnAndOff ()
        {
            if (isOn == false)
            {
                isOn = true;
            } 
            else
            {
                isOn = false;
            }
            return $"Is the light turned on?: {isOn}.";
        }
    }
}
