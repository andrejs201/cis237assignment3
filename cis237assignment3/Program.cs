//Andrejs Tomsons
//CIS 237 Assignment 3

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
                selectionInt = 0;
                bool selectionIntRead = false;
                try     //catches letters entered into the console
                {
                    selectionInt = Convert.ToInt32(ui.ReadLine());
                    selectionIntRead = true;
                }
                catch
                {
                    ui.Print(Environment.NewLine + "Enter a number Please." + Environment.NewLine);
                }

                if (selectionIntRead)
                {
                    switch (selectionInt)
                    {
                        case 0:     //Exit program
                            exitCondition = true;
                            break;

                        case 1:     //Add droid
                            AddDroid(dc, ui);
                            break;

                        case 2:     //print droid list
                            ui.Print(dc.PrintArray());
                            break;

                        default:    //catches numbers not used
                            ui.ErrorMessage2();
                            break;
                    }
                }
                
            }

            
        }

        private static void AddDroid(DroidCollecion droidCollection, UserInterface userInterface)
        {
            //istantiate variables
            DroidCollecion dc = droidCollection;
            UserInterface ui = userInterface;
            IDroid droid = null;
            string droidMaterial;
            string droidColor;
            string droidType;
            int droidNumberLanguages;
            bool droidToolBox;
            bool droidComputerConnection;
            bool droidArm;
            bool droidFireExtingusher;
            int droidNumberShips;
            bool droidTrashCompactor;
            bool droidVacuum;

            try     //catch incorrect entries
            {
                ui.DroidMaterial();
                droidMaterial = ui.ReadLine();
                ui.DroidColor();
                droidColor = ui.ReadLine();
                ui.DroidType();
                droidType = ui.ReadLine();

                if (droidType == "Astromech") //astromech path
                {
                    //utility variables
                    ui.ToolBoxAsk();
                    droidToolBox = Convert.ToBoolean(ui.ReadLine());
                    ui.ComputerConnectionAsk();
                    droidComputerConnection = Convert.ToBoolean(ui.ReadLine());
                    ui.ArmAsk();
                    droidArm = Convert.ToBoolean(ui.ReadLine());
                    //Astromech variables
                    ui.FireExtinguisher();
                    droidFireExtingusher = Convert.ToBoolean(ui.ReadLine());
                    ui.NumberShips();
                    droidNumberShips = Convert.ToInt32(ui.ReadLine());
                    //create new astromech in the droid variable
                    droid = new Astromech(droidMaterial, droidType, droidColor, droidToolBox, droidComputerConnection, droidArm, droidFireExtingusher, droidNumberShips);
                }
                else if (droidType == "Janitor")  //janitor path
                {
                    //Utitlity variables
                    ui.ToolBoxAsk();
                    droidToolBox = Convert.ToBoolean(ui.ReadLine());
                    ui.ComputerConnectionAsk();
                    droidComputerConnection = Convert.ToBoolean(ui.ReadLine());
                    ui.ArmAsk();
                    droidArm = Convert.ToBoolean(ui.ReadLine());
                    //Janitor variables
                    ui.TrashCompactor();
                    droidTrashCompactor = Convert.ToBoolean(ui.ReadLine());
                    ui.Vacuum();
                    droidVacuum = Convert.ToBoolean(ui.ReadLine());
                    //Create new janitor in the droid variable
                    droid = new Janitor(droidMaterial, droidType, droidColor, droidToolBox, droidComputerConnection, droidArm, droidTrashCompactor, droidVacuum);
                }
                else if (droidType == "Protocol") //protocol path
                {
                    //Protocol variables
                    ui.DroidLanguages();
                    droidNumberLanguages = Convert.ToInt32(ui.ReadLine());
                    //create new Protocol droid in the droid variable
                    droid = new Protocol(droidMaterial, droidType, droidColor, droidNumberLanguages);
                }
                else
                {
                    ui.DroidTypeError();    //output type error message
                }
            }
            catch
            {
                ui.Print("Invalid entry");
            }
            if (droid == null)  //if no droid was made do not add it to the list
            {
                ui.DroidNotAdded();
            }
            else
            {
                //if the droid is made add it to the list
            }
            {
                dc.AddDroid(droid);
                ui.DroidAdded();
            }
            
        }
    }
}
