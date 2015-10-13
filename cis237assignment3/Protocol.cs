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
            
        }

        private double ProtocolCalculate(int numberLanguages)
        {
            if (numberLanguages < 10)
                return 1;
            else if (numberLanguages < 50)
                return 2;
            else if (numberLanguages < 100)
                return 3;
            else
                return 4;
        }

        public override string ToString()
        {

            string tempString = base.ToString();
            tempString += Environment.NewLine + "languages known: " + this.numberLanguages;
            return tempString;
            
        }
    }
}
