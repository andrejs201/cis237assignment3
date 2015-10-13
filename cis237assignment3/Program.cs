using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitCondition = false;
            int selectionInt;
            UserInterface ui = new UserInterface();

            while (!exitCondition)
            {
                ui.DisplayMenu();
                selectionInt = Convert.ToInt32(ui.ReadLine());
                switch (selectionInt)
                {
                    case 0:     //Exit program
                        exitCondition = true;
                        break;

                    case 1:     //Add droid

                        break;

                    case 2:     //print droid list

                        break;

                    default:
                        break;
                }
            }
        }
    }
}
