using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_TipCalculator
    {
        public static void TipCalculator() {

            /*
            Mark Mckinney
            SDI Section 01
            Restaurant Calculator
            03 June 2018
            Create a tip calculator. Enter a number of meals and prices to calculate tip and total
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("             _____ _         ___      _         _      _ ");
            Console.WriteLine("            |_   _(_)_ __   / __|__ _| |__ _  _| |__ _| |_ ___ _ _ ");
            Console.WriteLine("              | | | | '_ \\ | (__/ _` | / _| || | / _` |  _/ _ \\ '_|");
            Console.WriteLine("              |_| |_| .__/  \\___\\__,_|_\\__|\\_,_|_\\__,_|\\__\\___/_|");
            Console.WriteLine("                    |_| ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" String Objects:\r\n");

            List<decimal> mDec = new List<decimal>();

            Console.Write(" How many meals were there?: ");
            string mealsString = Console.ReadLine();
            int meals;
            while (!(int.TryParse(mealsString, out meals)) || !(meals >= 1)) {
                Console.Write("    Please enter the number of meals: ");
                mealsString = Console.ReadLine();
                int.TryParse(mealsString, out meals);
            }

            //Meals loop
            int m = 1;
            while (m <= meals ) {
                Console.Write(" Enter the price of meal number {0}: $", m);
                string mealDecString = Console.ReadLine();
                decimal mealDec;
                while (!(decimal.TryParse(mealDecString, out mealDec))) {
                    Console.Write("    Opps, enter the price of meal number one: $");
                    mealDecString = Console.ReadLine();
                    decimal.TryParse(mealDecString, out mealDec);                   
                }
                m++;
                mDec.Add(mealDec);
            }          

            //Tip amount output to console
            Console.Write(" Enter a tip percentage: % ");
            string tipPercString = Console.ReadLine();
            decimal tipPerc;
            while (!(decimal.TryParse(tipPercString, out tipPerc))) {
                Console.Write("    Opps, enter a tip percentage: $");
                tipPercString = Console.ReadLine();
                decimal.TryParse(tipPercString, out tipPerc);
            }

            //Subtotal of meals
            decimal sub = mDec.Sum();
            decimal subTotal = sub;
            Console.WriteLine("\r\n Sub-Total: $" + Math.Round(subTotal,2));

            //Tip amount calculated as a percentage
            decimal tipTotal = subTotal * (tipPerc / 100);
            //decimals are rounded to two places for change purposes
            decimal tipTotalR = Math.Round(tipTotal, 2);
            Console.WriteLine(" Tip Amount: $" + tipTotalR);

            //Break
            Console.WriteLine();

            //Grand Total of tip + meal total
            decimal grandTotal = subTotal + tipTotal;
            //decimals are rounded to two places for change purposes
            decimal grandTotalR = Math.Round(grandTotal, 2);
            Console.WriteLine(" Total Amount: $" + grandTotalR);
  
            //Split Check
            decimal splitTotal = grandTotal / mDec.Count;
            //decimals are rounded to two places for change purposes
            decimal splitTotalR = Math.Round(splitTotal, 2);
            Console.WriteLine("\r\n Check split evenly {0} ways ${1}\r\n", mDec.Count, splitTotalR);

            /*
            Test #1
            • Check #1 – 10.00
            • Check#2 – 15.00
            • Check#3 – 25.00
            • Tip%-20
            • Sub-Total Without Tip – 50.00
            • Total Tip – 10.00
            • Grand total With Tip – 60.00
            • Cost per person – 20.00

            Test #2
            • Check #1 – 20.25
            • Check#2 – 17.75
            • Check#3 – 23.90
            • Tip%-10
            • Sub-Total Without Tip – 61.90
            • Total Tip – 6.19
            • Grand total With Tip – 68.09
            • Cost per person – 22.69666 or rounded 22.70
            */

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }
    }
}
