using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    public class Menu
    {
        public static void MainMenu()
        {
            //Name: Mark Mckinney
            //Date: August 2018
            //Course: Project & Portfolio I
            //Synopsis:Rock, paper, scissors game. User plays against the computer.
            Console.Clear();

            //Heading "Project + Portfolio I"
            Header();

            //Menu Options
            R(); Console.Write("    ["); CLR(); Console.Write("1"); R(); Console.Write("]"); CLR(); Console.WriteLine(" Swap Name");
            R(); Console.Write("    ["); CLR(); Console.Write("2"); R(); Console.Write("]"); CLR(); Console.WriteLine(" Backwards");
            R(); Console.Write("    ["); CLR(); Console.Write("3"); R(); Console.Write("]"); CLR(); Console.WriteLine(" Age Convert");
            R(); Console.Write("    ["); CLR(); Console.Write("4"); R(); Console.Write("]"); CLR(); Console.WriteLine(" Temp Convert");
            R(); Console.Write("    ["); CLR(); Console.Write("5"); R(); Console.Write("]"); CLR(); Console.WriteLine(" Big Blue Fish");
            R(); Console.Write("    ["); CLR(); Console.Write("6"); R(); Console.Write("]"); CLR(); Console.WriteLine(" Rock, Paper, Scissors");
            R(); Console.Write("\r\n    ["); CLR(); Console.Write("0"); R(); Console.Write("]"); CLR(); Console.WriteLine(" Exit");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n ==============================================================================");
            Console.ResetColor();
            
            //Make Selection
            Console.Write(" Make your selection: ");
            string selectionString = Console.ReadLine();
            int selection;
            while (!(int.TryParse(selectionString, out selection) && (selection >= 0) && (selection < 7))) {
                Console.Write(" Please make a selection 1-6: ");
                selectionString = Console.ReadLine();
                int.TryParse(selectionString, out selection);
            }
            if (selection == 0) { Environment.Exit(0); }
            else if (selection == 1) { SwapName.SwapNameChallenge(); }
            else if (selection == 2) { Backwards.BackwardsChallenge(); }
            else if (selection == 3) { AgeConvert.AgeConvertChallenge(); }
            else if (selection == 4) { TempConvert.TempConvertChallenge(); }
            else if (selection == 5) { BigBlueFish.BigBlueFishChallenge(); }
            else if (selection == 6) { RockPaperScissor.RockPaperScissorChallenge(); }
            else if (selection == 99) { RockPaperScissor.RockPaperScissorChallenge(); }
        }

        //METHODS
        public static void Header(){
            Console.Title = "Mark Mckinney's Code Challenges - Main Menu";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("   ___          _        _     __       ___         _    __     _ _       ___");
            Console.WriteLine("  | _ \\_ _ ___ (_)___ __| |_  / _|___  | _ \\___ _ _| |_ / _|___| (_)___  |_ _|");
            Console.WriteLine("  |  _/ '_/ _ \\| / -_) _|  _| > _|_ _| |  _/ _ \\ '_|  _|  _/ _ \\ | / _ \\  | |");
            Console.WriteLine("  |_| |_| \\___// \\___\\__|\\__| \\_____|  |_| \\___/_|  \\__|_| \\___/_|_\\___/ |___|");
            Console.WriteLine("              |___/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                               M A I N   M E N U");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Coding Challenge Menu:\r\n\r\n Please enter the number of the challenge you would like to run...\r\n");
        }

        public static void R() {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void CLR() {
            Console.ResetColor();
        }
    }
}
