//Andrejs Tomsons
//CIS 237 Assignment 3

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
            this.totalCost += JanitorCalculate(this.trashCompactor, this.vacuum);
            base.CalculateTotalCost();
        }

        private double JanitorCalculate(bool trashCompactor, bool vacuum)
        {
            double temp = 0;
            if (trashCompactor)
                temp += 100;
            if (vacuum)
                temp += 100;
            return temp;
        }

        public override string ToString()   //Adds to the description the features that the janitor droid has
        {
            string tempString = base.ToString();    //go up a class first
            if (this.trashCompactor || this.vacuum)
                tempString += Environment.NewLine + "----Janitor-Features----" + Environment.NewLine;
            if (this.trashCompactor)
                tempString += " trash compactor" + Environment.NewLine;
            if (this.vacuum)
                tempString += " vacuum" + Environment.NewLine;
            
            return tempString;
        }
    }
}
