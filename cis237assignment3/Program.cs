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
                
            }

            
        }

        private static void AddDroid()
        {
            //istantiate variables
            DroidCollecion dc = new DroidCollecion();
            UserInterface ui = new UserInterface();
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

                if (droidType.ToLower() == "astromech") //astromech path
                {
                    ui.ToolBoxAsk();
                    droidToolBox = Convert.ToBoolean(ui.ReadLine());
                    ui.ComputerConnectionAsk();
                    droidComputerConnection = Convert.ToBoolean(ui.ReadLine());
                    ui.ArmAsk();
                    droidArm = Convert.ToBoolean(ui.ReadLine());
                    ui.FireExtinguisher();
                    droidFireExtingusher = Convert.ToBoolean(ui.ReadLine());
                    ui.NumberShips();
                    droidNumberShips = Convert.ToInt32(ui.ReadLine());
                    droid = new Astromech(droidMaterial, droidType, droidColor, droidToolBox, droidComputerConnection, droidArm, droidFireExtingusher, droidNumberShips);
                }
                else if (droidType.ToLower() == "janitor")  //janitor path
                {
                    ui.ToolBoxAsk();
                    droidToolBox = Convert.ToBoolean(ui.ReadLine());
                    ui.ComputerConnectionAsk();
                    droidComputerConnection = Convert.ToBoolean(ui.ReadLine());
                    ui.ArmAsk();
                    droidArm = Convert.ToBoolean(ui.ReadLine());
                    ui.TrashCompactor();
                    droidTrashCompactor = Convert.ToBoolean(ui.ReadLine());
                    ui.Vacuum();
                    droidVacuum = Convert.ToBoolean(ui.ReadLine());
                    droid = new Janitor(droidMaterial, droidType, droidColor, droidToolBox, droidComputerConnection, droidArm, droidTrashCompactor, droidVacuum);
                }
                else if (droidType.ToLower() == "protocol") //protocol path
                {
                    ui.DroidLanguages();
                    droidNumberLanguages = Convert.ToInt32(ui.ReadLine());
                    droid = new Protocol(droidMaterial, droidType, droidColor, droidNumberLanguages);
                }
                else
                {
                    ui.DroidTypeError();    
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
