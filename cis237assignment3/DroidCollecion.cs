//Andrejs Tomsons
//CIS 237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollecion
    {
        private static IDroid[] droidArray = new IDroid[100];
        private static int arrayLength = 0;

        public DroidCollecion()
        { }

        public IDroid this[int index]
        {
            get { return droidArray[index]; }
            set { droidArray[index] = value; }
        }

        public void AddDroid(IDroid droid)
        {
            bool droidAdded = false;
            for (int i = 0; i < droidArray.Length; i++)
            {
                if (droidArray[i] == null && droidAdded == false)   //only add a droid if the spot is empty and a droid has not yet been added
                {
                    droidArray[i] = droid;
                    arrayLength++;
                    droidAdded = true;
                }
            }
        }

        public string PrintArray()
        {
            string tempString = "";
            if (arrayLength == 0)
            {
                tempString = Environment.NewLine + "There are no droids in the array" + Environment.NewLine;
            }
            else
            {
                for (int i = 0; i < arrayLength; i++)   //Print the droid array
                {
                    if (droidArray[i] != null)  
                    {
                        droidArray[i].CalculateTotalCost(); //get the total cost
                        tempString += "--------Droid-" + (i + 1);   //Add header
                        if (i + 1 > 9)
                            tempString += "-------" + Environment.NewLine;
                        else
                            tempString += "--------" + Environment.NewLine;

                        tempString += droidArray[i].ToString();
                        tempString += Environment.NewLine + "Total Cost: " + droidArray[i].TotalCost + " Credits";
                        tempString += Environment.NewLine + "------End-Droid-" + (i + 1);
                        if (i + 1 > 9)  //Add footer
                            tempString += "-----" + Environment.NewLine + Environment.NewLine;
                        else
                            tempString += "------" + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

            return tempString;
        }


    }
}
