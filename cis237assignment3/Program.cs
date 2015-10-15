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
            DroidCollecion dc = new DroidCollecion();

            while (!exitCondition)  //main program loop
            {
                ui.DisplayMenu();
                try     //catches letters entered into the console
                {
                    selectionInt = Convert.ToInt32(ui.ReadLine());
                    switch (selectionInt)
                    {
                        case 0:     //Exit program
                            exitCondition = true;
                            break;

                        case 1:     //Add droid
                            AddDroid();
                            break;

                        case 2:     //print droid list
                            ui.Print(dc.PrintArray());
                            break;

                        default:    //catches numbers not used
                            ui.ErrorMessage2();
                            break;
                    }
                }
                catch
                {
                    ui.Print(Environment.NewLine + "Enter a number Please." + Environment.NewLine);
                }
                
            }

            
        }

        private static void AddDroid()
        {

        }
    }
}
