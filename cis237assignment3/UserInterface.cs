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

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Print(string tempString)
        {
            Console.WriteLine(tempString);
        }

        public void DisplayMenu()
        {
            Print("-------Main-Menu-------" + Environment.NewLine + "Exit: 0" + Environment.NewLine + "Add a new droid: 1" + Environment.NewLine + "Print droid list: 2" + Environment.NewLine + "-----------------------");
        }

        public string PrintDroidList()
        {
            return "";
        }

        public void ErrorMessage()
        {
            Print(Environment.NewLine + "Enter a number please." + Environment.NewLine);
        }

        public void ErrorMessage2()
        {
            Print(Environment.NewLine + "Enter a correct number." + Environment.NewLine);
        }

        public void DroidType()
        {
            Print(Environment.NewLine + "Astromech: 1" + Environment.NewLine + "Janitor: 2" + Environment.NewLine + "Protocol: 3");
        }
    }
}
