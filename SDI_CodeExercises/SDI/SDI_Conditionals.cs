using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_Conditionals
    {
        public static void Conditionals() {

            /*
            Mark Mckinney
            SDI Section 01
            Conditionals
            10 June 2018
            Conditionals: 
            Determine when to use if, else, and else if conditional statements.
            Formulate conditional statements for dynamic decision-making.
            Employ relational operators to weigh conditions as true or false.
            Create logic to resolve a single solution from a selection of possible solutions.
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                 ___             _ _ _   _               _ ");
            Console.WriteLine("                / __|___ _ _  __| (_) |_(_)___ _ _  __ _| |___");
            Console.WriteLine("               | (__/ _ \\ ' \\/ _` | |  _| / _ \\ ' \\/ _` | (_-<");
            Console.WriteLine("                \\___\\___/_||_\\__,_|_|\\__|_\\___/_||_\\__,_|_/__/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Conditionals:\r\n");

            //BAKING CONVERTER
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine(" BAKING CONVERTER grams & ounces");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();

            Console.Write(" Please enter the weight you would like to convert: ");
            string weightAmountString = Console.ReadLine();

            double weightAmount;
            while (!(double.TryParse(weightAmountString, out weightAmount))) {
                Console.Write(" Opps! A number needs to be typed for weight. \r\n Please enter a weight: ");
                weightAmountString = Console.ReadLine();
                double.TryParse(weightAmountString, out weightAmount);
            }

            Console.Write(" What was {0} measured in \"oz\" or \"g\"?: ", weightAmount);
            string weightMeasurementString = Console.ReadLine();
            weightMeasurementString = weightMeasurementString.ToLower();

            while (!((weightMeasurementString == "oz") || (weightMeasurementString == "ounces") || (weightMeasurementString == "g") || (weightMeasurementString == "grams"))) {
                Console.WriteLine("Opps! Please enter \"oz\" or \"g\"");
                weightMeasurementString = Console.ReadLine();
            }

            double ozWeight = Math.Round((1 / 28.34952f) * weightAmount, 5);
            double gWeight = Math.Round(28.34952f * weightAmount, 3);

            if ((weightMeasurementString == "g") || (weightMeasurementString == "grams")) {
                Console.WriteLine(" {0} grams equals {1} ounces",weightAmount, ozWeight);
            }

            if ((weightMeasurementString == "oz") || (weightMeasurementString == "ounces")) {
                Console.WriteLine(" {0} ounces equals {1} grams", weightAmount, gWeight);
            }

            /*
            DATA SETS TO TEST 

            Inputs – Weight =200 Units = "g"
            Results = "The weight is 7.05479 ounces”
            
            Inputs – Weight =12 Units = "oz"
            Results = "The weight is 340.194 grams"
           
            Inputs – Weight =50 Units = "OZ" 
            Results = "The weight is 1417.476 grams"

            Inputs - Weight =325 Units = "grams"
            Results = "The weight is 11.46404 grams"
            */
            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            //----------------------------------------------------------------------------------------------------------//

            //PIZZA PER PERSON
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n ------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine(" PIZZA PER PERSON");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.Write(" How many pizzas did you order?: ");
            string pizzaAmountString = Console.ReadLine();
            int pizzaAmount;
            while (!(int.TryParse(pizzaAmountString, out pizzaAmount))) {
                Console.Write(" Opps! you did not enter the number for pizzas. \r\n How many pizzas did you order?: ");
                pizzaAmountString = Console.ReadLine();
                int.TryParse(pizzaAmountString, out pizzaAmount);
            }

            Console.Write(" How many slices per pizza?: ");
            string pizzaSlicesString = Console.ReadLine();
            int pizzaSlices;
            while (!(int.TryParse(pizzaSlicesString, out pizzaSlices))) {
                Console.Write(" Opps! you did not enter the number of pizza slices. \r\n How many slices per pizza?: ");
                pizzaSlicesString = Console.ReadLine();
                int.TryParse(pizzaSlicesString, out pizzaSlices);
            }

            Console.Write(" How many guests will be at the party?: ");
            string guestsString = Console.ReadLine();
            int guests;
            while (!(int.TryParse(guestsString, out guests))) {
                Console.Write(" Opps! you did not enter how many guests. \r\n How many guests will be at the party?: ");
                guestsString = Console.ReadLine();
                int.TryParse(guestsString, out guests);
            }

            Console.Write(" How many slices will each guest eat?: ");
            string guestSlicesString = Console.ReadLine();
            int guestSlices;
            while (!(int.TryParse(guestSlicesString, out guestSlices))) {
                Console.Write(" Opps! you did not enter how many slices each guests will eat. \r\n How many slices will each guest eat?: ");
                guestSlicesString = Console.ReadLine();
                int.TryParse(guestSlicesString, out guestSlices);
            }

            int numSlices = pizzaAmount * pizzaSlices;
            int numEaten = guests * guestSlices;

            int extraSlices = numSlices - numEaten;
            int slicesNeeded = numEaten - numSlices;
            decimal pizzasNeeded = Math.Ceiling((decimal)slicesNeeded/pizzaSlices);

            if (extraSlices >= 0) {
                Console.WriteLine("\r\n Yes, you you have enough pizza for your guests with {0} slices left over.", extraSlices);
            }

            else {
                Console.WriteLine("\r\n You need at least {0} more slices of pizza that is {1} more pizzas.", slicesNeeded, pizzasNeeded);
            }

            /*
            DATA SETS TO TEST 
             
            Pizzas: 10
            Slices per Pizza: 8
            Guest Count: 11
            Slices per Guest: 5
            Result – “Yes, you have enough pizza for your guests with 25 slices left over.”

            Pizzas: 5
            Slices per Pizza: 6
            Guest Count: 8
            Slices per Guest: 5
            Result – “You need at least 10 more slices of pizza. You should order more pizza. ”

            Pizzas: 25
            Slices per Pizza: 8
            Guest Count: 48
            Slices per Guest: 4
            Result – “Yes, you you have enough pizza for your guests with 8 slices left over.”
            */

            //----------------------------------------------------------------------------------------------------------//

            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            //TAX BRACKETS
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n ------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine(" TAX BRACKETS");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();

            Console.Write(" Please enter your income for {0}: $", DateTime.Now.Year-1);
            string incomeString = Console.ReadLine();
            int income;
            while (!(int.TryParse(incomeString, out income))) {
                Console.WriteLine(" Opps! You did not enter a valid income amount. \r\n Please enter your income for {0}: $ ", DateTime.Now.Year - 1);
                incomeString = Console.ReadLine();
                int.TryParse(incomeString, out income);
            }

            //tier 1
            if (income <= 9000) {
                Console.WriteLine(" You have an income of ${0} which puts you in tier 1 and your tax rate is 10%.", income);
            }
            //tier 2
            else if (income < 37950) {
                Console.WriteLine(" You have an income of ${0} which puts you in tier 2 and your tax rate is 15%.", income);
            }
            //tier 3
            else if (income < 91900) {
                Console.WriteLine(" You have an income of ${0} which puts you in tier 3 and your tax rate is 25%.", income);
            }
            //tier 4
            else if (income < 191650)
            {
                Console.WriteLine(" You have an income of ${0} which puts you in tier 4 and your tax rate is 28%.", income);
            }
            //tier 5
            else if (income < 416700) {
                Console.WriteLine(" You have an income of ${0} which puts you in tier 5 and your tax rate is 33%.", income);
            }
            //tier 6
            else if (income < 418400) {
                Console.WriteLine(" You have an income of ${0} which puts you in tier 6 and your tax rate is 35%.", income);
            }
            //tier 7
            else if (income >= 418400) {
                Console.WriteLine(" You have an income of ${0} which puts you in tier 7 and your tax rate is 39.6%.", income);
            }

            /*
            DATA SETS TO TEST

            Income – $63234
            Result - “You have an income of $63234 which puts you in tier 3 and your tax rate is 25%.”

            Income – $200000
            Result - “You have an income of $200000 which puts you in tier 5 and your tax rate is 33%.” 
            
            Income – $500000
            Result - “You have an income of $500000 which puts you in tier 7 and your tax rate is 39.6%.”
            
            Income - 23787
            Result - "You have an income of 23787 which puts you in tier 2 and your tax rate is 15%."
             */


            //----------------------------------------------------------------------------------------------------------//
            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            //DISCOUNT DOUBLE CHECK
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n ------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine(" DISCOUNT DOUBLE CHECK");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();

            /*
            spend $100+ = 10% off
            spend $50-$99 = 5% off
            Spend <$50 = 0% off
            */

            //$ Item ONE
            Console.Write(" Cost of FIRST item: $");
            string firstItemString = Console.ReadLine();
            decimal firstItem;
            while (!(decimal.TryParse(firstItemString, out firstItem))) {
                Console.Write(" Opps! you did not type a dollar amount. \r\n Please enter the cost of your first item: $");
                firstItemString = Console.ReadLine();
                decimal.TryParse(firstItemString, out firstItem);
            }

            //$ Item TWO
            Console.Write(" Cost of SECOND item: $");
            string secondItemString = Console.ReadLine();
            decimal secondItem;
            while (!(decimal.TryParse(secondItemString, out secondItem))) {
                Console.Write(" Opps! you did not type a dollar amount. \r\n Please enter the cost of your second item: $");
                Console.Write("$"); secondItemString = Console.ReadLine();
                decimal.TryParse(secondItemString, out secondItem);
            }

            //Total of items
            decimal totalAmount = firstItem + secondItem;

            //discounts
            decimal dis10 = totalAmount - (10m / 100m) * totalAmount;
            decimal dis05 = totalAmount - (5m / 100m) * totalAmount;

            //Break Line
            Console.WriteLine();

            if (totalAmount < 50m) {
                Console.WriteLine(" Your total purchase is ${0}", totalAmount);
            }
            else if (totalAmount < 100m) {
                Console.WriteLine(" Your total purchase is ${0}, which includes your 5% discount.", dis05);
            }
            else if (totalAmount >= 100m) {
                Console.WriteLine(" Your total purchase is ${0}, which includes your 10% discount.", dis10);
            }

            /*
            DATA SETS TO TEST

            First Item Cost - $ 45.50
            Second Item Cost - $75.00
            Total - $108.45
            Results - “Your total purchase is $108.45, 
            which includes your 10%discount.”

            First Item Cost - $ 30.00
            Second Item Cost - $25.00
            Total - $52.25
            Results - “Your total purchase is $52.25, 
            which includes your 5% discount.”

            First Item Cost - $ 5.75
            Second Item Cost - $12.50
            Total - $18.25
            Results - “Your total purchase is $18.25.”

            First Item Cost - $ 92.50
            Second Item Cost - $6.50
            Total - $94.05
            Results - “Your total purchase is $94.05, which includes your 5% discount.”
             */

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
