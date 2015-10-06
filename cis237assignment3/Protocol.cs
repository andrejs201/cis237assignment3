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

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
