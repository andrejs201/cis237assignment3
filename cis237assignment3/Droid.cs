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

        abstract void CalculateTotalCost();

        protected void CalculateBaseCost(string material)
        {
            switch (material.ToLower())
            {
                case "1":
                    baseCost = 1;
                    break;

                case "2":
                    baseCost = 2;
                    break;

                case "3":
                    baseCost = 3;
                    break;

                case "4":
                    baseCost = 4;
                    break;

                default:
                    break;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
