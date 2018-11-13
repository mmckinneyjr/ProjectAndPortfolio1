using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_CustomClasses
    {
        public static void CustomClasses() {

            /*
            Mark Mckinney
            24 June 2018
            SDI Section 01
            Custom Class Assignment
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\r\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  ███████ ██    ██ ██████  ███████ ██████  ███    ███  █████  ███    ██");
            Console.WriteLine("  ██      ██    ██ ██   ██ ██      ██   ██ ████  ████ ██   ██ ████   ██");
            Console.WriteLine("  ███████ ██    ██ ██████  █████   ██████  ██ ████ ██ ███████ ██ ██  ██");
            Console.WriteLine("       ██ ██    ██ ██      ██      ██   ██ ██  ██  ██ ██   ██ ██  ██ ██");
            Console.WriteLine("  ███████  ██████  ██      ███████ ██   ██ ██      ██ ██   ██ ██   ████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.ResetColor();
            Console.WriteLine("                     Welcome to Superman vs Doomsday\r\n");
            Console.WriteLine(" Superman will be fighting Doomsday through a selected number of rounds ");
            Console.WriteLine(" and will start off with 75 pts health. First, select whether Superman");
            Console.WriteLine(" attacks Doomsday by typing \"attack\" increasing his health or whether");
            Console.WriteLine(" Superman defends against Doomsday by typing \"defend\" decreasing his");
            Console.WriteLine(" health. Second enter the amount of damage caused by typing a positive");
            Console.WriteLine(" whole number.\r\n\r\n Let's play!\r\n");

            //Instance of Superman (Rounds, Starting Hit Pts, Max Pts, Min Pts)
            Superman hitPoints = new Superman(1, 25, 100, 0);

            //Set number of rounds
            hitPoints.SetRounds(hitPoints.SetRoundsFunc(hitPoints.GetSetRounds()));

            //rounds loop
            int i = 1;
            while (i <= hitPoints.GetSetRounds()) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\r\n      ROUND {0} of {1}\r\n", i, hitPoints.GetSetRounds());
                Console.ResetColor();
                Console.Write(" [");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(hitPoints.Bar(hitPoints.GetCurrentHP()));
                Console.ResetColor();
                Console.Write("] {0}%", hitPoints.GetCurrentHP());
                Console.Write("\r\n Attack or Defend: ");
                string aOrDString = Console.ReadLine();
                while (!(aOrDString == "attack" || aOrDString == "Attack" || aOrDString == "defend" || aOrDString == "Defend")) {
                    Console.Write(" Opps! Please type \"attack\" or \"defend\": ");
                    aOrDString = Console.ReadLine();
                }
                i++;

                //Attack conditional
                if (aOrDString == "attack" || aOrDString == "Attack") {
                    Console.Write(" Enter damage amount: "); string hitPtString = Console.ReadLine();
                    int increase;
                    while (!(int.TryParse(hitPtString, out increase) && (increase > 0))) {
                        Console.Write(" Opps! Please enter a positive number\r\n Enter damage amount: ");
                        hitPtString = Console.ReadLine();
                        int.TryParse(hitPtString, out increase);
                    }

                    //Update hit points
                    hitPoints.SetCurrentHP(hitPoints.TotalHpIncrease(hitPoints.GetCurrentHP(), increase));
                    //Health conditionals    
                    if (!(hitPoints.GetCurrentHP() < hitPoints.GetMaxHP())) {
                        Console.WriteLine(" Health Meter {0}", hitPoints.GetMaxHP());
                        hitPoints.SetCurrentHP(100);
                    }
                }

                //Defend conditional
                else if (aOrDString == "defend" || aOrDString == "Defend") {
                    Console.Write(" Enter damage amount:");
                    string hitPtString = Console.ReadLine();
                    int decrease;
                    while (!(int.TryParse(hitPtString, out decrease) && (decrease > 0))) {
                        Console.Write(" Opps! Please enter a positive number: ");
                        hitPtString = Console.ReadLine();
                        int.TryParse(hitPtString, out decrease);
                    }

                    //Update hit points
                    hitPoints.SetCurrentHP(hitPoints.TotalHpDecrease(hitPoints.GetCurrentHP(), decrease));
                    //Health Conditionals
                    if (hitPoints.GetCurrentHP() > hitPoints.GetMinHP())
                        Console.WriteLine(" Health Meter {0}", hitPoints.GetCurrentHP());
                    else if (!(hitPoints.GetCurrentHP() > hitPoints.GetMinHP())) {
                        Console.WriteLine("\r\n Supermans Health Meter has reach 0\r\n\r\n ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" Doomsday has defeated Superman!\r\n");
                        Console.ResetColor();
                        break;
                    } 
                }
            }

            if (hitPoints.GetCurrentHP() > 0) {
                Console.ResetColor();
                Console.Write("\r\n [");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(hitPoints.Bar(hitPoints.GetCurrentHP()));
                Console.ResetColor();
                Console.Write("] {0}%", hitPoints.GetCurrentHP());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\n Superman has defeated Doomsday!\r\n");
                Console.ResetColor();
            }

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n\r\n ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }   
    }
}