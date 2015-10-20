//Andrejs Tomsons
//CIS 237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        protected int numberLanguages;

        public Protocol(string material, string model, string color, int numberLanguages)
            : base(material, model, color)
        {
            this.numberLanguages = numberLanguages;
        }

        public override void CalculateTotalCost()
        {
            totalCost += ProtocolCalculate(this.numberLanguages);
            base.CalculateBaseCost(this.material);
            totalCost += baseCost;
        }

        private double ProtocolCalculate(int numberLanguages)   //returns totalCost based on the number of languages known
        {
            if (numberLanguages < 10)
                return 100;
            else if (numberLanguages < 50)
                return 200;
            else if (numberLanguages < 100)
                return 400;
            else
                return 600;
        }

        public override string ToString()   //Adds to the description the features that the protocol droid has
        {
            string tempString = base.ToString();    //go up a class first
            tempString += Environment.NewLine + "---Protocol-Features---" + Environment.NewLine + "languages known: " + this.numberLanguages;
            return tempString;
            
        }
    }
}
