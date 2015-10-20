//Andrejs Tomsons
//CIS 237 Assignment 3

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

        public decimal TotalCost
        {
            get { return Convert.ToDecimal(this.totalCost); }
            set { this.totalCost = Convert.ToDouble(value); }
        }

        public Droid(string material, string model, string color)
        {
            this.material = material;
            this.model = model;
            this.color = color;
        }

        public abstract void CalculateTotalCost();

        protected void CalculateBaseCost(string material)   //Give a value based on the material
        {
            switch (material.ToLower())
            {
                case "1":
                    baseCost = 100;
                    break;

                case "2":
                    baseCost = 200;
                    break;

                case "3":
                    baseCost = 400;
                    break;

                case "4":
                    baseCost = 1000;
                    break;

                default:
                    break;
            }
        }

        public override string ToString()   //The base ToString where all the other ToStrings end up.
        {
            string tempString = "Model: " + this.model + Environment.NewLine + "Color: " + this.color + Environment.NewLine + "Material: " + MaterialTranslator(this.material);

            return tempString;
        }

        private string MaterialTranslator(string material)  //translates the material integer into the actual material type
        {
            switch (material)
            {
                case "1":
                    return "Metal";

                case "2":
                    return "More expensive metal";

                case "3":
                    return "Even more expensive metal";

                case "4":
                    return "Extravagently expensive metal";

                default:
                    return "Material Error";
            }
        }
    }
}
