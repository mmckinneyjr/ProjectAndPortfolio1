using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_Methods
    {
        public static void Methods() {

            /*
            Mark Mckinney
            17 June 2018
            SDI Section 01
            Methods Assignment
              - Identify reusability of code within functions.
              - Use arguments and parameters and returning to pass values and variables between functions.
              - Organize code into reusable blocks with functions.
              - Constructing parameters with appropriate data types.
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                         __  __     _   _            _ ");
            Console.WriteLine("                        |  \\/  |___| |_| |_  ___  __| |__");
            Console.WriteLine("                        | |\\/| / -_)  _| ' \\/ _ \\/ _` (_-<");
            Console.WriteLine("                        |_|  |_\\___|\\__|_||_\\___/\\__,_/__/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Methods:\r\n");

            //PROBLEM #1: PAINTING A WALL
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM #1: PAINTING A WALL");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            //Width
            Console.Write(" Let's calculate how many gallons of paint it would take to paint a wall.\r\n\r\n Please enter the Width of the wall (in feet): ");
            string widthString = Console.ReadLine();
            double width;
            while (!double.TryParse(widthString, out width)) {
                Console.Write(" Opps! Please enter the width (in feet): ");
                widthString = Console.ReadLine();
            }

            //Height
            Console.Write(" Enter the Height of the wall (in feet): ");
            string heightString = Console.ReadLine();
            double height;
            while (!double.TryParse(heightString, out height)) {
                Console.Write(" Opps! Enter the height (in feet): ");
                heightString = Console.ReadLine();
            }

            //Number of Coats
            Console.Write(" Enter the Number of Coats you want to apply: ");
            string numCoatsString = Console.ReadLine();
            double numCoats;
            while (!double.TryParse(numCoatsString, out numCoats)) {
                Console.Write(" Opps! Enter the number of coats to be applied: ");
                numCoatsString = Console.ReadLine();
            }

            //Area one gallon covers
            Console.Write(" How many square feet does a gallon of paint cover?: ");
            string areaCoverString = Console.ReadLine();
            double areaCover;
            while (!double.TryParse(areaCoverString, out areaCover)) {
                Console.Write(" Opps! Enter how many square feet a gallon of paint covers: ");
                areaCoverString = Console.ReadLine();
            }

            double numGallons = GallonsFunc(width, height, numCoats, areaCover);

            Console.WriteLine("\r\n For {0} coats of paint you will need {1} gallons of paint.", numCoats, Math.Round(numGallons, 2));

            /*
            DATA SETS TO TEST

            Width – 8
            Height – 10
            Coats – 2
            Surface Area - 300 ft2
            Results-“For 2 coats on the wall, you will need .53 gallons of paint.”

            Width – 30
            Height – 12.5
            Coats – 3
            Surface Area - 350 ft2
            Results-“For 3 coats on the wall, you will need 3.21 gallons of paint.”

            Width – 24
            Height – 9.25
            Coats – 3
            Surface Area - 300 ft2
            Results-“For 3 coats on the wall, you will need 2.22 gallons of paint.”
             */

            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            //PROBLEM #2: STUNG!
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM #2: STUNG!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            //Height
            Console.Write(" How many bee stings are needed to kill an animal?\r\n\r\n What is the animal's weight (in pounds):");
            string weightString = Console.ReadLine();
            double weight;
            while (!double.TryParse(weightString, out weight)) {
                Console.Write(" Opps! Please enter a weight (in pounds): ");
                weightString = Console.ReadLine();
            }

            double numOfBeeStings = BeeStings(weight);

            Console.WriteLine("\r\n It takes {0} bee stings to kill an animal {1} pounds.", numOfBeeStings, weight);

            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            //PROBLEM #3: REVERSE IT
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM #3: REVERSE IT");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            //My Array
            string[] myArray = new string[] { "Rembrandt", "Van Gogh", "Monet", "da Vinci", "Michelangelo" };

            //Array one 
            string array1 = MyJoinedArray(myArray);
            Console.WriteLine(" The original array was:\r\n {{{0}}}\r\n", array1);
            //Array two reversed
            MyArrayRevered(myArray);
            string array2 = MyJoinedArray(myArray);
            Console.WriteLine(" and now we reversed it as: \r\n {{{0}}}\r\n", array2);

            /*
            DATA SETS TO TEST
            Initial array – [“apple”, “pear”, “peach”, “coconut”, “kiwi”]
            Results - [“apple”, “pear”, “peach”, “coconut”, “kiwi”] 
            Reversed - [“kiwi”, “coconut”, “peach”, “pear”, “apple”]

            Initial array – [“red”, “orange”, “yellow”, “green”, “blue”, ”indigo”, “violet”] 
            Results - [“red”, “orange”, “yellow”, “green”, “blue”, ”indigo”, “violet”] 
            Reversed - [“violet”, “indigo”, “blue”, “green”, “yellow”, “orange”, “red”]

            Initial array - ["Rembrandt", "Van Gogh", "Monet", "da Vinci", "Michelangelo"]
            Results - ["Rembrandt", "Van Gogh", "Monet", "da Vinci", "Michelangelo"]
            Reversed - ["Michelangelo", "da Vinci", "Monet", "Van Gogh", [Rembrandt"]
             */

            Console.WriteLine("\r\n THE END!!!");

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }

        //METHODS

        //Problem #1
        public static double GallonsFunc(double wallWidth, double wallHeight, double coats, double coverage) {
            double wallArea = ((wallWidth * wallHeight) * coats) / coverage;
            return wallArea;
        }

        //Problem #2
        public static double BeeStings(double weight) {
            double numBeeStings = 9 * weight;
            return numBeeStings;
        }

        //Problem #3
        //Join Array
        public static string MyJoinedArray(string[] myArray) {
            string myJoinedArray = String.Join("\", \"", myArray);
            return myJoinedArray;
        }

        //Reverse Array
        public static void MyArrayRevered(string[] myArray) {
            int rev = myArray.Length;
            for (int i = 0; i < rev / 2; i++) {
                string reverse = myArray[i];
                myArray[i] = myArray[rev - i - 1];
                myArray[rev - i - 1] = reverse;
            }
        }
    }
}
