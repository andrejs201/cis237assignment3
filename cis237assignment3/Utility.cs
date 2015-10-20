//Andrejs Tomsons
//CIS 237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        protected bool toolbox;
        protected bool computerConnection;
        protected bool arm;

        public Utility(string material, string model, string color, bool toolbox, bool computerConnection, bool arm)
            : base(material, model, color)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public override void CalculateTotalCost()
        {
            this.totalCost += UtilityCalculate(this.toolbox, this.computerConnection, this.arm);
            base.CalculateBaseCost(this.material);
            totalCost += baseCost;
        }

        private double UtilityCalculate(bool toolBox, bool computerConnection, bool arm)    //returns totalCost based on features
        {
            double temp = 0;
            if (toolBox)
                temp += 100;
            if (computerConnection)
                temp += 100;
            if (arm)
                temp += 100;
            return temp;
        }

        public override string ToString()   //Adds to the description the features that the utility droid has
        {
            string tempString = base.ToString();    //go up a class first
            if (this.toolbox || this.computerConnection || this.arm)
                tempString += Environment.NewLine + "----Utility-Features----" + Environment.NewLine;
            if (this.toolbox)
                tempString += " toolbox" + Environment.NewLine;
            if (this.computerConnection)
                tempString += " computer connection" + Environment.NewLine;
            if (this.arm)
                tempString += " computer screen" + Environment.NewLine;
            if (this.toolbox || this.computerConnection || this.arm)
                tempString += "------------------------";
            return tempString;
        }
    }
}
