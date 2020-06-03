using System;
using System.Collections.Generic;
using System.Text;

namespace FindObjects
{
    class PC
    {
        private int screenCount;
        private string caseSize;
        private bool isOn;
        private string color;

        public PC(int screenCount, string caseSize, bool isOn, string color)
        {
            this.screenCount = screenCount;
            this.caseSize = caseSize;
            this.isOn = isOn;
            this.color = color;
        }

        public string description()
        {
            return $"My PC has a {caseSize} {color} case.";
        }
        public string changeCaseSize(string size)
        {
            caseSize = size;
            return $"Case size: {caseSize}.";
        }
    }
}
