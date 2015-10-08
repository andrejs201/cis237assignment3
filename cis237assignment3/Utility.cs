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
            UtilityCalculate(this.toolbox, this.computerConnection, this.arm);
            base.CalculateTotalCost();
        }

        private double UtilityCalculate(bool toolBox, bool computerConnection, bool arm)
        {
            double temp = 0;
            if (toolBox)
                temp += 1;
            if (computerConnection)
                temp += 1;
            if (arm)
                temp += 1;
            return temp;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
