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

        public string DisplayMenu()
        {
            return "Exit: 0" + Environment.NewLine + "Add a new droid: 1" + Environment.NewLine + "Print droid list: 2";
        }

        public string PrintDroidList()
        {
            return "";
        }
    }
}
