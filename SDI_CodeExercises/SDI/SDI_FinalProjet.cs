using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_FinalProjet
    {
        public static void FinalProject() {

            /*
            Mark Mckinney
            24 June 2018
            SDI Section 01
            Final Project
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor(); 
            Console.Write("             ______ /   \r\n            \\------/                                            oOOOOOo\r\n             \\   _//                                           ,|    oO\r\n              \\ (_/     ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("WELCOME TO THE SOBRIETY CALCULATOR"); Console.ResetColor();
            Console.WriteLine("    //|     |\r\n               \\_/                                            \\\\|     |\r\n                |                                              `|     |\r\n              __|__                                             `-----`");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor(); Console.ResetColor();
            Console.WriteLine("\r\n This program will determine how many minutes are needed to become sober based on\r\n how many and the type of drinks consumed.\r\n");
            Console.WriteLine(" Please enter each drink you you consumed throughout the night separated by a \",\".");
            Console.Write(" ");
            string drinkListString = Console.ReadLine();

            //Blank space validation
            while (string.IsNullOrWhiteSpace(drinkListString)) {
                Console.WriteLine(" Opps! Perhaps you've had too many,\r\nbut please do not leave blank. ");
                Console.Write(" ");
                drinkListString = Console.ReadLine();
            }

            //User input split to Drink List array
            string[] drinkList = DrinkTextToArray(drinkListString);

            //User selects Drink Type
            string[] drinkType = PromptForDrinkType(drinkList);

            //Calculations for Wait time
            int total = WaitTimeTillSober(drinkType);

            //Console Outputs
            Console.WriteLine("\r\n For the {0} drink(s) you had tonight,\r\n you must wait {1} minutes to become sober.\r\n", drinkList.Length, total);
            Console.WriteLine("\r\n PLEASE DRINK RESPONSIBLY\r\n");

            /*
            DATA SETS TO TEST
            Event List – “White Russian, Red’s Apple Ale, Moscato, Vodka Cran, Diet Coke”
                Drink - White Russian       Type – 1     Wait Time - 60
                Drink – Red’s Apple Ale     Type – 3     Wait Time - 30
                Drink - Moscato             Type – 2     Wait Time - 45
                Drink – Vodka Cran          Type – 1     Wait Time - 60
                Drink – Diet Coke           Type – 4     Wait Time - 0
  
            Final Results - “For the 5 drink(s) you had tonight,
                             you must wait 195 minutes to become sober.”

            Event List – “Jack & Coke, Miller Lite, Water, Long Island, Corona, Water”
                Drink - Jack & Coke         Type – 1     Wait Time - 60
                Drink – Miller Lite         Type – 3     Wait Time - 30
                Drink - Water               Type – 4     Wait Time - 0
                Drink – Long Island         Type – 1     Wait Time - 60
                Drink – Corona              Type – 3     Wait Time - 30
                Drink – Water               Type – 4     Wait Time - 0
  
            Final Results - "For the 6 drink(s) you had tonight,
                             you must wait 180 minutes to become sober."

            Event List – “OJ Vodka, Merlot, Guinness, Cranberry Juice”
                Drink - OJ Vodka            Type – 1     Wait Time - 60
                Drink – Merlot              Type – 2     Wait Time - 45
                Drink – Guinness            Type – 3     Wait Time - 30
                Drink - Cranberry Juice     Type – 4     Wait Time - 0
  
            Final Results - “For the 4 drink(s) you had tonight,
                             you must wait 135 minutes to become sober."
            */

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n\r\n ==============================================================================");
            Console.ResetColor(); Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }

        //METHODS

        //Split users input string
        public static string[] DrinkTextToArray(string drinkListString) {
            string[] drinkList = drinkListString.Split(',').Select(x => x.Trim()).ToArray();
            return drinkList;
        }

        //Prompt user for "DrinkType" Function
        public static string[] PromptForDrinkType(string[] drinkList) {

            string[] drinkType = new string[drinkList.Length];
            for (int i = 0; i < drinkList.Length; i++) {

                //Ask user for drink type
                Console.WriteLine("\r\n What kind of drink was the {0}?", drinkList[i]);
                Console.WriteLine(" Select the type of drink:\r\n   (1) For Mixed Drink\r\n   (2) For Wine\r\n   (3) For Beer\r\n   (4) For Non-Alcoholic");
                Console.Write(" ");
                drinkType[i] = Console.ReadLine();

                //1-4 value validation
                while (!(drinkType[i] == "1" || drinkType[i] == "2" || drinkType[i] == "3" || drinkType[i] == "4")) {
                    Console.WriteLine(" Opps! You did NOT enter a value 1-4.\r\n Please choose a value for the {0}: \r\n   (1) For Mixed Drink\r\n   (2) For Wine\r\n   (3) For Beer\r\n   (4) For Non-Alcoholic", drinkList[i]);
                    Console.Write(" ");
                    drinkType[i] = Console.ReadLine();
                }
            }
            return drinkType;
        }

        //Wait Time Function
        public static int WaitTimeTillSober(string[] drinkType) {

            //Number of occurances
            int one = drinkType.Count(one1 => one1.Equals("1"));
            int two = drinkType.Count(one2 => one2.Equals("2"));
            int three = drinkType.Count(one3 => one3.Equals("3"));
            int four = drinkType.Count(one4 => one4.Equals("4"));

            //Occurances * time
            int mixedDrinks = one * 60;
            int wine = two * 45;
            int beer = three * 30;
            int nonAlcoholic = four * 0;

            //Total time
            int totalMins = mixedDrinks + wine + beer + nonAlcoholic;

            return totalMins;
        }
    }
}
