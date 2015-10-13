using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        protected bool trashCompactor;
        protected bool vacuum;

        public Janitor(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum) 
            : base( material, model, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        public override void CalculateTotalCost()
        {
            JanitorCalculate(this.trashCompactor, this.vacuum);
            base.CalculateTotalCost();
        }

        private double JanitorCalculate(bool trashCompactor, bool vacuum)
        {
            double temp = 0;
            if (trashCompactor)
                temp += 1;
            if (vacuum)
                temp += 1;
            return temp;
        }

        public override string ToString()
        {
            string tempString = base.ToString();
            if (this.trashCompactor || this.vacuum)
                tempString += Environment.NewLine + "Janitor Features:";
            if (this.trashCompactor)
                tempString += " trash compactor";
            if (this.vacuum)
                tempString += " vacuum";
            return tempString;
        }
    }
}
