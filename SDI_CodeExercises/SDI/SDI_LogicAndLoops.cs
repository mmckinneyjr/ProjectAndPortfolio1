using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_LogicAndLoops
    {
        public static void LogicAndLoops()
        {
            /*
            Mark Mckinney
            SDI Section 01
            Logic Loops
            10 June 2018
            Logic and Loops assignment
              - Determine when to use if, else, and else if conditional statements.
              - Formulate conditional statements for dynamic decision-making.
              - Employ relational operators to weigh conditions as true or false.
              - Utilize logical operators in order to combine multiple conditional statements.
              - Create logic to resolve a single solution from a selection of possible solutions.
              - Recall and distinguish the structure for while, for and for each loops.
              - Formulate loops to repeat blocks of code.
              - Recognize each type of loop and when to use them.
              - Employ repetition to solve complex problems.
              - Identify and use the components of a for loop.
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("     _              _         _    ___                     _ ");
            Console.WriteLine("    | |   ___  __ _(_)__ __ _| |  / _ \\ _ __  ___ _ _ __ _| |_ ___ _ _ ___");
            Console.WriteLine("    | |__/ _ \\/ _` | / _/ _` | | | (_) | '_ \\/ -_) '_/ _` |  _/ _ \\ '_(_-<");
            Console.WriteLine("    |____\\___/\\__, |_\\__\\__,_|_|  \\___/| .__/\\___|_| \\__,_|\\__\\___/_| /__/");
            Console.WriteLine("              |___/                    |_|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Logic and Loops\r\n");

            //PROBLEM 1 - LOGICAL OPERATORS: TIRE PRESSURE
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM 1 - LOGICAL OPERATORS: TIRE PRESSURE");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            //Front Right Tire 
            Console.Write(" Please enter tire pressure for FRONT RIGHT tire: ");
            string frontRightString = Console.ReadLine();
            double frontRight;
            while (!(double.TryParse(frontRightString, out frontRight))) {
                Console.Write(" Opps! Please enter a number value: ");
                frontRightString = Console.ReadLine();
                double.TryParse(frontRightString, out frontRight);
            }

            //Front Left Tire
            Console.Write(" Please enter tire pressure for FRONT LEFT tire: ");
            string frontLeftString = Console.ReadLine();
            double frontLeft;
            while (!(double.TryParse(frontLeftString, out frontLeft))) {
                Console.Write(" Opps! Please enter a number value: ");
                frontLeftString = Console.ReadLine();
                double.TryParse(frontLeftString, out frontLeft);
            }

            //Rear Right Tire
            Console.Write(" Please enter tire pressure for REAR RIGHT tire: ");
            string rearRightString = Console.ReadLine();
            double rearRight;
            while (!(double.TryParse(rearRightString, out rearRight))) {
                Console.Write(" Opps! Please enter a number value: ");
                rearRightString = Console.ReadLine();
                double.TryParse(rearRightString, out rearRight);
            }

            // Rear Left Tire --------------------------------------------------------//
            Console.Write(" Please enter tire pressure for REAR LEFT tire: ");
            string rearLeftString = Console.ReadLine();
            double rearLeft;
            while (!(double.TryParse(rearLeftString, out rearLeft))) {
                Console.Write(" Opps! Please enter a number value: ");
                rearLeftString = Console.ReadLine();
                double.TryParse(rearLeftString, out rearLeft);
            }

            double[] tirePressures = new double[] { frontRight, frontLeft, rearRight, rearLeft };
            Console.WriteLine("\r\n Your tire pressures are:\r\n   Front Right: {0}psi\r\n   Front Left: {1}psi\r\n   Rear Right: {2}psi\r\n   Rear Left: {3}psi", tirePressures[0], tirePressures[1], tirePressures[2], tirePressures[3]);

            if (tirePressures[0] == tirePressures[1] && tirePressures[2] == tirePressures[3]) {
                Console.WriteLine("\r\n The tires PASS spec!");
            }
            else {
                Console.WriteLine("\r\n Get your tires checked out!");
            }

            /*
            DATA SETS TO TEST:

            Front Left – 32
            Front Right – 32
            Back Left - 30 
            Back Right - 30
            Result: Tires OK

            Front Left – 36
            Front Right – 32
            Back Left - 25
            Back Right - 25
            Result: Check Tires

            Front Left – 35
            Front Right – 35
            Back Left - 23
            Back Right - 21
            Result: Check Tires
             */
            
            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();
            //PROBLEM 2 - LOGICAL OPERATORS: MOVIE TICKET PRICE
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM 2 - LOGICAL OPERATORS: MOVIE TICKET PRICE");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            //Age Question
            Console.Write(" What is your age?: ");
            string ageString = Console.ReadLine();
            int age;
            while (!int.TryParse(ageString, out age)) {
                Console.Write(" Opps! Please enter your age: ");
                ageString = Console.ReadLine();
                int.TryParse(ageString, out age);
            }

            //Time Questions
            Console.Write(" What time is your movie?: ");
            string timeString = Console.ReadLine();
            int time;
            while (!int.TryParse(timeString, out time)) {
                Console.Write(" Opps! Please enter your movie time: ");
                timeString = Console.ReadLine();
                int.TryParse(timeString, out time);
            }

            bool ageDis = age < 10 || age >= 55;
            bool timeDis = time >= 14 && time <= 17;

            if (ageDis || timeDis) {
                Console.WriteLine("\r\n Your ticket price is $7.00");
            }
            else {
                Console.WriteLine("\r\n Your ticket price is $12.00");
            }

            /*
            DATA SETS TO TEST:
            Age – 57
            Time – 20
            Ticket Price - $7.00

            Age – 9
            Time – 20
            Ticket Price - $7.00

            Age – 38
            Time – 20
            Ticket Price - $12.00
            
            Age – 25
            Time – 16
            Ticket Price - $7.00

            Age - 32
            Time - 18
            Ticket Price - $12.00
             */
            
            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            //PROBLEM 3 - FOR LOOP: ADD UP THE ODDS OR EVENS
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM 3 - FOR LOOP: ADD UP THE ODDS AND EVENS");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            int[] myInts = new int[] { 1, 12, 32, 44, 51, 61, 7, 92, 9, 5 };
            Console.WriteLine(" Here is an array {{{0}}}", string.Join(", ", myInts));

            Console.Write("\r\n Would you like to see the sum of my ODD or EVEN numbers?: ");
            string oddEvenString = Console.ReadLine().ToLower();

            while (!((oddEvenString == "even") ||  (oddEvenString == "odd"))) {
                Console.Write(" Opps! Please enter \"odd\" or \"even\": ");
                oddEvenString = Console.ReadLine().ToLower();
            }

            int sums = 0;
            for (int counter = 0; counter < myInts.Length; counter++) {
                if (myInts[counter] % 2 == 0 && (oddEvenString == "even")) {

                    sums = sums + myInts[counter];
                }

                else if (myInts[counter] % 2 == 1 && (oddEvenString == "odd")) {
                    sums = sums + myInts[counter];
                }
            }
            Console.WriteLine("\r\n The sum of the " + oddEvenString + " numbers in the array is: {0}.", sums);

            /*
            DATA SETS TO TEST:
            Array: {1,2,3,4,5,6,7}
            Sum of Evens – 12 
            Sum of Odds – 16
            
            Array: {12,13,14,15,16,17}
            Sum of Evens – 42
            Sum of Odds – 45
             
            Array: {1,12,32,44,51,61,7,92,9,5}
            Sum of Evens – 180
            Sum of Odds – 134
             */
            
            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            //PROBLEM 4 - WHILE LOOP: CHARGE IT!
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM 4 - WHILE LOOP: CHARGE IT!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.Write(" Please enter your credit limit: $");
            string creditLimitString = Console.ReadLine();
            decimal creditLimit;
            while (!decimal.TryParse(creditLimitString, out creditLimit)) {
                Console.Write(" Opps! Please enter a dollar amount: $");
                creditLimitString = Console.ReadLine();
                decimal.TryParse(creditLimitString, out creditLimit);
            }

            Console.Write(" Please enter your purchase amount: $");
            string purchaseAmountString = Console.ReadLine();
            decimal purchaseAmount;
            while (!decimal.TryParse(purchaseAmountString, out purchaseAmount)) {
                Console.Write(" Opps! Please enter a dollar amount: $");
                purchaseAmountString = Console.ReadLine();
                decimal.TryParse(purchaseAmountString, out purchaseAmount);
            }

            decimal creditLeft = creditLimit - purchaseAmount;
            while (creditLeft > 0) {
                Console.WriteLine(" You have ${0} left on your credit.", creditLeft);
                Console.Write(" Please enter your next purchase amount: $", creditLeft);
                purchaseAmountString = Console.ReadLine();
                decimal.TryParse(purchaseAmountString, out purchaseAmount);

                creditLeft -= purchaseAmount;
            }

            Console.WriteLine(" With your last purchase you have reached your credit limit and exceeded it by ${0}", -(creditLeft));

            /*
            DATA SETS TO TEST:
            Credit Limit – 20.00
                Purchase1- 5.00 - You can still spend $15.00
                Purchase2- 12.00 - You can still spend $3.00
                Purchase3- 7.00 - You have exceeded your limit by $4.00.
                
            Credit Limit - 500.00
                Purchase1- 3.27 - You can still spend $173.00
                Purchase2- 128.15 - You can still spend $44.85
                Purchase3- 92.00 - You have exceeded your limit by $47.15.
            */
            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }
    }
}
