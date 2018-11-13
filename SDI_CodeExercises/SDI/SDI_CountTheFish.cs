using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_CountTheFish
    {
        public static void CountTheFish() {

            /*
            Mark Mckinney
            SDI Section 01
            Count Fish
            10 June 2018
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Count The Fish:\r\n");

            //Fish Array
            string[] fishiesColors = new string[] { "red", "blue", "green", "yellow", "blue", "green", "blue", "blue", "red", "green" };

            //User input for selecting fish
            Console.Write(" Please choose a color [1]Red, [2]Blue, [3]Green, [4]Yellow: ");
            string colorString = Console.ReadLine();
            int colors;
            int.TryParse(colorString, out colors);
            while (!(colors > 0) || !(colors <= 4)) {
                Console.WriteLine(" You did NOT enter a value 1-4.\r\nPlease choose a color: (1)Red, (2)Blue, (3)Green, (4)Yellow.");
                colorString = Console.ReadLine();
                int.TryParse(colorString, out colors);
            }

            //Fish color conditional
            string fishColor = "";
            int fishSum = 0;
            for (int i = 0; i < fishiesColors.Length; i++) {
                if (colors == 1 && fishiesColors[i] == "red") {
                    fishSum += 1;
                    fishColor = "red";
                }
                else if (colors == 2 && fishiesColors[i] == "blue") {
                    fishSum += 1;
                    fishColor = "blue";
                }
                else if (colors == 3 && fishiesColors[i] == "green") {
                    fishSum += 1;
                    fishColor = "green";
                }
                else if (colors == 4 && fishiesColors[i] == "yellow") {
                    fishSum += 1;
                    fishColor = "yellow";
                }
            }

            //Output to console
            Console.WriteLine(" In the fish tank there are {0} fish of the color {1}.", fishSum, fishColor);
            Console.WriteLine("\r\n Here is the fish tank:\r\n " + string.Join(", ", fishiesColors)); 

            //Return to main menu
            Console.WriteLine("\r\n\r\n ===========================================================================");
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }
    }
}
