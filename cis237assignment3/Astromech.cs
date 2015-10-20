//Andrejs Tomsons
//CIS 237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        protected bool fireExtinguisher;
        protected int numberShips;

        public Astromech(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips) 
            : base( material, model, color, toolbox, computerConnection, arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        public override void CalculateTotalCost()
        {
            this.totalCost += AstromechCalculate(this.fireExtinguisher, this.numberShips);
            base.CalculateTotalCost();
        }

        private double AstromechCalculate(bool fireExtinguisher, int numberShips)
        {
            double temp = 0;
            if (fireExtinguisher)
                temp += 100;
            temp += this.numberShips * 100.0;
            return temp;
        }

        public override string ToString()   //Adds to the description the features that the astromech droid has
        {
            string tempString = base.ToString();    //go up a class first
            tempString += Environment.NewLine + "---Astromech-Features---" + Environment.NewLine;
            if (this.fireExtinguisher)
                tempString += " fire extinguisher" + Environment.NewLine;
            tempString += " number of ships: " + this.numberShips + Environment.NewLine;
            return tempString;
        }
    }
}
