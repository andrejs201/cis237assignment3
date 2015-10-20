//Andrejs Tomsons
//CIS 237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {

        public UserInterface()
        { }

        public string ReadLine()    //Reusable Console.Readline
        {
            return Console.ReadLine();
        }

        public void Print(string tempString)    //Reusable Console.WriteLine with an extra carriage return
        {
            Console.WriteLine();
            Console.WriteLine(tempString);
        }

        /**********************************
         * A Lot of text
         **********************************/

        public void DisplayMenu()
        {
            Print("-------Main-Menu-------" + Environment.NewLine + "Exit: 0" + Environment.NewLine + "Add a new droid: 1" + Environment.NewLine + "Print droid list: 2" + Environment.NewLine + "-----------------------");
        }

        public void ErrorMessage()
        {
            Print("Enter a number please." + Environment.NewLine);
        }

        public void ErrorMessage2()
        {
            Print("Enter a correct number." + Environment.NewLine);
        }

        public void DroidType()
        {
            Print("What is the droid's type? Astromech, Janitor, or Protocol?");
        }

        public void DroidMaterial()
        {

            Print("-------Droid-Add-------" + Environment.NewLine + "What material is the droid made out of?" + Environment.NewLine + "Metal: 1" + Environment.NewLine + "More expensive metal: 2" + Environment.NewLine + "Even more expensive metal: 3" + Environment.NewLine + "Extravagently expensive metal: 4");
        }

        public void DroidColor()
        {
            Print("What color is the droid?");
        }

        public void DroidLanguages()
        {
            Print("How many languages does the protocol droid know?");
        }

        private void Ask()
        {
            Print("true for yes, false for no.");
        }

        public void ToolBoxAsk()
        {
            Ask();
            Console.WriteLine("Does the droid have a toolbox?");
        }

        public void ComputerConnectionAsk()
        {
            Ask();
            Console.WriteLine("Does the droid have a computer connection?");
        }

        public void ArmAsk()
        {
            Ask();
            Console.WriteLine("Does the droid have an arm?");
        }

        public void NumberShips()
        {
            
            Print("How many ships has the droid served on?");
        }

        public void FireExtinguisher()
        {
            Ask();
            Print("Does the droid have a fire extinguisher?");
        }

        public void TrashCompactor()
        {
            Ask();
            Console.WriteLine("Does the droid have a trash compactor?");
        }

        public void Vacuum()
        {
            Ask();
            Console.WriteLine("Does the droid have a vacuum?");
        }

        public void DroidTypeError()
        {
            Print("Droid type not found, try again.");
        }

        public void DroidAdded()
        {
            Print("The droid has successfully been added." + Environment.NewLine + "-----End-Droid-Add-----");
        }

        public void DroidNotAdded()
        {
            Print("The droid has not been added." + Environment.NewLine + "-----End-Droid-Add-----");
        }
    }
}
