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
        protected bool numberShips;

        public Astromech(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, bool numberShips) 
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

        private double AstromechCalculate(bool fireExtinguisher, bool numberShips)
        {
            double temp = 0;
            if (fireExtinguisher)
                temp += 1;
            if (numberShips)
                temp += 1;
            return temp;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
