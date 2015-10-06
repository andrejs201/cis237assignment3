using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        protected string material;
        protected string model;
        protected string color;
        protected double baseCost;
        protected double totalCost;

        public decimal TotalCost { get; set; }

        public Droid(string material, string model, string color)
        {
            this.material = material;
            this.model = model;
            this.color = color;
        }

        public abstract void CalculateTotalCost();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
