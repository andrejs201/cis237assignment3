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
            AstromechCalculate(this.fireExtinguisher, this.numberShips);
            base.CalculateTotalCost();
        }

        private double AstromechCalculate(bool fireExtinguisher, int numberShips)
        {
            double temp = 0;
            if (fireExtinguisher)
                temp += 1;
            temp += this.numberShips;
            return temp;
        }

        public override string ToString()
        {
            string tempString = base.ToString();
            tempString += Environment.NewLine + "Astromech Features:";
            if (this.fireExtinguisher)
                tempString += " fire extinguisher";
            tempString += " number of ships: " + this.numberShips;
            return tempString;
        }
    }
}
