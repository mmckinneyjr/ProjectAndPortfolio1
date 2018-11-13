using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_MainMenu
    {
        public static void MainMenu()
        {
            /*
            Mark Mckinney
            SDI Section 01
            2018
            Main Menu
            Synopsis:
            Main menu to a list of differnt code from my SDI course.
            */
            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ==============================================================================");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("    ▄████████ ████████▄   ▄█       ▄████████  ▄██████▄  ████████▄     ▄████████");
            Console.WriteLine("   ███    ███ ███   ▀███ ███      ███    ███ ███    ███ ███   ▀███   ███    ███");
            Console.WriteLine("   ███    █▀  ███    ███ ███▌     ███    █▀  ███    ███ ███    ███   ███    █▀ ");
            Console.WriteLine("   ███        ███    ███ ███▌     ███        ███    ███ ███    ███  ▄███▄▄▄    ");
            Console.WriteLine(" ▀███████████ ███    ███ ███▌     ███        ███    ███ ███    ███ ▀▀███▀▀▀    ");
            Console.WriteLine("          ███ ███    ███ ███      ███    █▄  ███    ███ ███    ███   ███    █▄ ");
            Console.WriteLine("    ▄█    ███ ███   ▄███ ███      ███    ███ ███    ███ ███   ▄███   ███    ██ ");
            Console.WriteLine("  ▄████████▀  ████████▀  █▀       ████████▀   ▀██████▀  ████████▀    ██████████");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ==============================================================================");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                              M A I N   M E N U");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Main Menu:\r\n");

            //Menu Options
            Console.WriteLine("         [1] Arrays                [7] Logic and Loops");
            Console.WriteLine("         [2] Conditionals          [8] Mad-Lib Story");
            Console.WriteLine("         [3] Count The Fish        [9] Methods");
            Console.WriteLine("         [4] Custom Classes       [10] String Objects");
            Console.WriteLine("         [5] Final Project        [11] Tip Calculator");
            Console.WriteLine("         [6] Lists              ");
            Console.WriteLine("\r\n         [0] Exit\r\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();

            //User input for Selection
            Console.Write(" Make your selection: ");
            string selectionString = Console.ReadLine();
            int selection;
            while (!(int.TryParse(selectionString, out selection) && (selection >= 0) && (selection < 13))) {
                Console.Write(" Please make a selection 1-12: ");
                selectionString = Console.ReadLine();
                int.TryParse(selectionString, out selection);
            }

            //Selection Conditionals
            if (selection == 0) {
                Environment.Exit(0);
            }
            else if (selection == 1) {
                SDI_Arrays.Arrays();
            }
            else if (selection == 2) {
                SDI_Conditionals.Conditionals();
            }
            else if (selection == 3) {
                SDI_CountTheFish.CountTheFish();
            }
            else if (selection == 4) {
                SDI_CustomClasses.CustomClasses();
            }
            else if (selection == 5) {
                SDI_FinalProjet.FinalProject();
            }
            else if (selection == 6) {
                SDI_Lists.Lists();
            }
            else if (selection == 7) {
                SDI_LogicAndLoops.LogicAndLoops();
            }
            else if (selection == 8) {
                SDI_MadLib.MadLib();
            }
            else if (selection == 9) {
                SDI_Methods.Methods();
            }
            else if (selection == 10) {
                SDI_StringObjects.StringObjects();
            }
            else if (selection == 11) {
                SDI_TipCalculator.TipCalculator();
            }
        }
    }
}
