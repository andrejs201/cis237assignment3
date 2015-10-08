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

        protected void CalculateTotalCost()
        {
            totalCost += ProtocolCalculate(this.numberLanguages);
            base.CalculateTotalCost();
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
            return base.ToString();
        }
    }
}
